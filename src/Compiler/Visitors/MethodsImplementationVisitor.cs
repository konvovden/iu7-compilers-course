using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using TriAxis.RunSharp;

namespace Compiler.Visitors
{
    public class MethodsImplementationVisitor : MiniJavaBaseVisitor<bool>
    {
        private const string RANDOM_FIELD_NAME = "random";
        
        private readonly AssemblyGen _assemblyGen;
        private readonly Dictionary<string, TypeGen> _classes;
        private readonly Dictionary<string, Dictionary<string, MethodGen>> _classesMethods;

        private string _currentClassName;
        private string _currentMethodName;
        private CodeGen _currentCodeGen;
        private Operand _currentOperand;
        private Dictionary<string, Operand> _currentLocalVariables;
        private Dictionary<string, Operand> _currentClassFields;

        public MethodsImplementationVisitor(AssemblyGen assemblyGen,
            Dictionary<string, TypeGen> classes,
            Dictionary<string, Dictionary<string, MethodGen>> classesMethods)
        {
            _assemblyGen = assemblyGen;
            _classes = classes;
            _classesMethods = classesMethods;
        }

        public override bool VisitGoal(MiniJavaParser.GoalContext context)
        {
            Visit(context.mainClassDeclaration());

            foreach (var classDeclarationContext in context.classDeclaration())
                Visit(classDeclarationContext);

            return true;
        }

        public override bool VisitMainClassDeclaration(MiniJavaParser.MainClassDeclarationContext context)
        {
            _currentClassName = context.ID().Symbol.Text;
            _currentClassFields = new Dictionary<string, Operand>();

            VisitMainClassBody(context.mainClassBody());

            _currentClassName = null;
            _currentClassFields = null;

            return true;
        }

        public override bool VisitMainClassBody(MiniJavaParser.MainClassBodyContext context)
        {
            return VisitMainMethod(context.mainMethod());
        }

        public override bool VisitMainMethod(MiniJavaParser.MainMethodContext context)
        {
            VisitMainMethodDeclaration(context.mainMethodDeclaration());

            _currentCodeGen = _classesMethods[_currentClassName][_currentMethodName].GetCode();

            Visit(context.statement());

            _currentCodeGen = null;
            _currentMethodName = null;

            return true;
        }

        public override bool VisitMainMethodDeclaration(MiniJavaParser.MainMethodDeclarationContext context)
        {
            _currentMethodName = "Main";

            return true;
        }

        public override bool VisitClassDeclaration(MiniJavaParser.ClassDeclarationContext context)
        {
            _currentClassName = context.ID().Symbol.Text;
            _currentClassFields = new Dictionary<string, Operand>();

            Visit(context.classBody());

            _currentClassName = null;
            _currentClassFields = null;
            
            return true;
        }

        public override bool VisitClassBody(MiniJavaParser.ClassBodyContext context)
        {
            foreach (var fieldDeclarationContext in context.fieldDeclaration())
                Visit(fieldDeclarationContext);

            foreach (var methodDeclarationContext in context.methodDeclaration())
                Visit(methodDeclarationContext);

            return true;
        }

        public override bool VisitFieldDeclaration(MiniJavaParser.FieldDeclarationContext context)
        {
            var currentClass = _classes[_currentClassName];

            var fieldName = context.ID().Symbol.Text;
            var fieldType = GetTypeFromContext(context.type());

            _currentClassFields[fieldName] = currentClass.Protected.Field(fieldType, fieldName);
            
            return true;
        }

        public override bool VisitMethodDeclaration(MiniJavaParser.MethodDeclarationContext context)
        {
            _currentMethodName = context.ID().Symbol.Text;

            Visit(context.methodBody());
            
            return true;
        }

        public override bool VisitMethodBody(MiniJavaParser.MethodBodyContext context)
        {
            _currentCodeGen = _classesMethods[_currentClassName][_currentMethodName].GetCode();

            _currentLocalVariables = new Dictionary<string, Operand>();
            foreach (var varDeclarationContext in context.varDeclaration())
                Visit(varDeclarationContext);

            foreach (var statementContext in context.statement())
                Visit(statementContext);

            return true;
        }

        public override bool VisitIfElseStatement(MiniJavaParser.IfElseStatementContext context)
        {
            Visit(context.expression());
            
            _currentCodeGen.If(_currentOperand);

            Visit(context.statement()[0]);
            
            _currentCodeGen.Else();

            Visit(context.statement()[1]);
            
            _currentCodeGen.End();

            return true;
        }

        public override bool VisitWhileStatement(MiniJavaParser.WhileStatementContext context)
        {
            Visit(context.expression());
            
            _currentCodeGen.While(_currentOperand);

            Visit(context.statement());
            
            _currentCodeGen.End();

            return true;
        }

        
        public override bool VisitAssignStatement(MiniJavaParser.AssignStatementContext context)
        {
            var variableName = context.ID().Symbol.Text;

            Visit(context.expression());

            var target = GetOperandByName(variableName);
            
            _currentCodeGen.Assign(target, _currentOperand);

            return true;
        }

        public override bool VisitArrayAssignStatement(MiniJavaParser.ArrayAssignStatementContext context)
        {
            var variableName = context.ID().Symbol.Text;

            Visit(context.expression()[0]);
            var index = _currentOperand;

            Visit(context.expression()[1]);
            var value = _currentOperand;

            var target = GetOperandByName(variableName);
            
            _currentCodeGen.Assign(target[_currentCodeGen.TypeMapper, index], value);
            
            return true;
        }

        public override bool VisitVarDeclaration(MiniJavaParser.VarDeclarationContext context)
        {
            var variableType = GetTypeFromContext(context.type());
            var variableName = context.ID().Symbol.Text;

            _currentLocalVariables[variableName] = _currentCodeGen.Local(variableType);

            return true;
        }

        public override bool VisitMethodCallExpression(MiniJavaParser.MethodCallExpressionContext context)
        {
            var methodName = context.ID().Symbol.Text;
            
            Visit(context.expression());
            
            var targetOperand = _currentOperand;

            var argumentOperands = new List<Operand>();
            
            foreach (var argumentExpression in context.methodArgumentList().expression())
            {
                Visit(argumentExpression);
                argumentOperands.Add(_currentOperand);
            }
            
            _currentOperand = targetOperand.Invoke(methodName, _assemblyGen.TypeMapper, argumentOperands.ToArray());

            return true;
        }

        public override bool VisitObjectInstantiationExpression(MiniJavaParser.ObjectInstantiationExpressionContext context)
        {
            var className = context.ID().Symbol.Text;

            _currentOperand = _assemblyGen.ExpressionFactory.New(_classes[className]);

            return true;
        }

        public override bool VisitArrayInstantiationExpression(MiniJavaParser.ArrayInstantiationExpressionContext context)
        {
            Visit(context.expression());

            var arraySize = _currentOperand;

            _currentOperand = _assemblyGen.ExpressionFactory.NewArray(typeof(int), arraySize);
            
            return true;
        }

        public override bool VisitExpressionStatement(MiniJavaParser.ExpressionStatementContext context)
        {
            Visit(context.expression());
            
            _currentCodeGen.Eval(_currentOperand);

            return true;
        }

        public override bool VisitArrayAccessExpression(MiniJavaParser.ArrayAccessExpressionContext context)
        {
            Visit(context.expression()[0]);
            var array = _currentOperand;
            
            Visit(context.expression()[1]);
            var index = _currentOperand;

            _currentOperand = array[_currentCodeGen.TypeMapper, index];

            return true;
        }

        public override bool VisitArrayLengthExpression(MiniJavaParser.ArrayLengthExpressionContext context)
        {
            Visit(context.expression());

            _currentOperand = _currentOperand.ArrayLength();

            return true;
        }

        public override bool VisitAddExpression(MiniJavaParser.AddExpressionContext context)
        {
            Visit(context.expression()[0]);
            var firstExpressionOperand = _currentOperand;
            
            Visit(context.expression()[1]);
            var secondExpressionOperand = _currentOperand;

            _currentOperand = firstExpressionOperand.Add(secondExpressionOperand);
            
            return true;
        }

        public override bool VisitSubExpression(MiniJavaParser.SubExpressionContext context)
        {
            Visit(context.expression()[0]);
            var firstExpressionOperand = _currentOperand;
            
            Visit(context.expression()[1]);
            var secondExpressionOperand = _currentOperand;

            _currentOperand = firstExpressionOperand.Subtract(secondExpressionOperand);
            
            return true;
        }

        public override bool VisitMulExpression(MiniJavaParser.MulExpressionContext context)
        {
            Visit(context.expression()[0]);
            var firstExpressionOperand = _currentOperand;
            
            Visit(context.expression()[1]);
            var secondExpressionOperand = _currentOperand;

            _currentOperand = firstExpressionOperand.Multiply(secondExpressionOperand);
            
            return true;
        }

        public override bool VisitLtExpression(MiniJavaParser.LtExpressionContext context)
        {
            Visit(context.expression()[0]);
            var firstExpressionOperand = _currentOperand;
            
            Visit(context.expression()[1]);
            var secondExpressionOperand = _currentOperand;

            _currentOperand = firstExpressionOperand.Lt(secondExpressionOperand);
            
            return true;
        }

        public override bool VisitNegExpression(MiniJavaParser.NegExpressionContext context)
        {
            Visit(context.expression());

            _currentOperand = _currentOperand.Negate();

            return true;
        }

        public override bool VisitNotExpression(MiniJavaParser.NotExpressionContext context)
        {
            Visit(context.expression());

            _currentOperand = _currentOperand.LogicalNot();

            return true;
        }

        public override bool VisitAndExpression(MiniJavaParser.AndExpressionContext context)
        {
            Visit(context.expression()[0]);
            var firstExpressionOperand = _currentOperand;
            
            Visit(context.expression()[1]);
            var secondExpressionOperand = _currentOperand;

            _currentOperand = firstExpressionOperand.LogicalAnd(secondExpressionOperand);
            
            return true;
        }

        public override bool VisitIdentifierExpression(MiniJavaParser.IdentifierExpressionContext context)
        {
            var identifier = context.ID().Symbol.Text;

            _currentOperand = GetOperandByName(identifier);
            
            return true;
        }

        public override bool VisitReturnStatement(MiniJavaParser.ReturnStatementContext context)
        {
            Visit(context.expression());
            
            _currentCodeGen.Return(_currentOperand);

            return true;
        }

        public override bool VisitThisExpression(MiniJavaParser.ThisExpressionContext context)
        {
            _currentOperand = _currentCodeGen.This();

            return true;
        }

        public override bool VisitPrintStatement(MiniJavaParser.PrintStatementContext context)
        {
            Visit(context.expression());
            _currentCodeGen.WriteLine(_currentOperand);

            _currentOperand = null;

            return true;
        }
        
        public override bool VisitIntLitExpression(MiniJavaParser.IntLitExpressionContext context)
        {
            _currentOperand = int.Parse(context.INT().Symbol.Text);

            return true;
        }

        public override bool VisitBooleanLitExpression(MiniJavaParser.BooleanLitExpressionContext context)
        {
            _currentOperand = bool.Parse(context.BOOL().Symbol.Text);
            
            return true;
        }

        public override bool VisitRandomIntExpression(MiniJavaParser.RandomIntExpressionContext context)
        {
            Visit(context.expression());

            var maxValue = _currentOperand;

            Operand randomOperand;

            if (_currentClassFields.TryGetValue(RANDOM_FIELD_NAME, out var randomField))
            {
                randomOperand = randomField;
            }
            else
            {
                var newRandomOperand = _assemblyGen.ExpressionFactory.New(typeof(Random));
                randomOperand = _classes[_currentClassName].Protected.Field(typeof(Random), RANDOM_FIELD_NAME, newRandomOperand);

                _currentClassFields[RANDOM_FIELD_NAME] = randomOperand;
            }
                
            _currentOperand = randomOperand.Invoke("Next", _currentCodeGen.TypeMapper, maxValue);

            return true;
        }

        private Type GetTypeFromContext(MiniJavaParser.TypeContext context)
        {
            Type result = null;

            if (context.ID() != null)
                result = _classes[context.ID().Symbol.Text];
            else if (context.intArrayType() != null)
                result = typeof(int[]);
            else if (context.booleanType() != null)
                result = typeof(bool);
            else if (context.intType() != null)
                result = typeof(int);

            return result;
        }

        private Operand GetOperandByName(string name)
        {
            Operand result = null;

            if (_currentLocalVariables.TryGetValue(name, out var localVariable))
                result = localVariable;
            else if (_currentClassName != null && _currentMethodName != null &&
                     _classesMethods[_currentClassName][_currentMethodName].Parameters.Any(p => p.Name == name))
            {
                result = _currentCodeGen.Arg(name);
            }
            else result = _currentCodeGen.This().Field(name);
            

            return result;
        }
    }
}
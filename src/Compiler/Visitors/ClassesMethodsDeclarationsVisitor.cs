using System;
using System.Collections.Generic;
using TriAxis.RunSharp;

namespace Compiler.Visitors
{
    public class ClassesMethodsDeclarationsVisitor : MiniJavaBaseVisitor<bool>
    {
        public Dictionary<string, Dictionary<string, MethodGen>> ClassesMethods { get; }

        private readonly AssemblyGen _assemblyGen;
        private readonly Dictionary<string, TypeGen> _classes;

        private string _currentClass;

        public ClassesMethodsDeclarationsVisitor(AssemblyGen assemblyGen, 
            Dictionary<string, TypeGen> classes)
        {
            ClassesMethods = new Dictionary<string, Dictionary<string, MethodGen>>();
            _currentClass = null;
            
            _assemblyGen = assemblyGen;
            _classes = classes;
        }

        public override bool VisitMainClassDeclaration(MiniJavaParser.MainClassDeclarationContext context)
        {
            _currentClass = context.ID().Symbol.Text;
            ClassesMethods[_currentClass] = new Dictionary<string, MethodGen>();
            
            return base.VisitMainClassDeclaration(context);
        }

        public override bool VisitMainMethodDeclaration(MiniJavaParser.MainMethodDeclarationContext context)
        {
            var currentClass = _classes[_currentClass];

            var methodName = "Main";
            var returnType = typeof(void);

            var method = currentClass.Public.Static.Method(returnType, methodName);
            method.Parameter(typeof(string[]), context.ID().Symbol.Text);

            ClassesMethods[_currentClass][methodName] = method;
            
            return base.VisitMainMethodDeclaration(context);
        }

        public override bool VisitClassDeclaration(MiniJavaParser.ClassDeclarationContext context)
        {
            _currentClass = context.ID().Symbol.Text;
            ClassesMethods[_currentClass] = new Dictionary<string, MethodGen>();
            
            return base.VisitClassDeclaration(context);
        }

        public override bool VisitMethodDeclaration(MiniJavaParser.MethodDeclarationContext context)
        {
            var currentClass = _classes[_currentClass];

            var methodName = context.ID().Symbol.Text;
            var returnType = GetTypeFromContext(context.type());

            var method = currentClass.Public.Method(returnType, methodName);
            var parametersContext = context.formalParameters()?.formalParameterList()?.formalParameter();

            if (parametersContext != null)
            {
                foreach (var parameter in parametersContext)
                    method.Parameter(GetTypeFromContext(parameter.type()), parameter.ID().Symbol.Text);
            }
            
            ClassesMethods[_currentClass][methodName] = method;
            
            return base.VisitMethodDeclaration(context);
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
    }
}
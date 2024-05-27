using TriAxis.RunSharp;

namespace Compiler.Visitors;

public class CodeGenVisitor : MiniJavaBaseVisitor<bool>
{
    private readonly AssemblyGen _assemblyGen;
    private readonly Dictionary<string, TypeGen> _classes;
    
    private TypeGen? _currentClass;
    private MethodGen? _currentMethod;
    private CodeGen? _currentCodeGen;
    private Operand? _currentOperand;

    public CodeGenVisitor(string assemblyName)
    {
        var options = new CompilerOptions()
        {
            OutputPath = "./test"
        };
        
        _assemblyGen = new AssemblyGen(assemblyName, options);

        _classes = new Dictionary<string, TypeGen>();
        
        _assemblyGen.Save();
    }

    public override bool VisitGoal(MiniJavaParser.GoalContext context)
    {
        var MyClass = _assemblyGen.Public.Class("MyClass");
        CodeGen g = MyClass.Public.Static.Method(
            typeof(void), "Main");
        {
            Operand args = g.Arg(0);
            g.If(args.ArrayLength() > 0);
            {
                g.WriteLine("Hello " + args[0] + "!");
            }
            g.Else();
            {
                g.WriteLine("Hello World!");
            }
            g.End();
        }
        
        /*VisitMainClassDeclaration(context.mainClassDeclaration());

        foreach (var classDeclarationContext in context.classDeclaration())
        {
            VisitClassDeclaration(classDeclarationContext);
        }*/

        return true;
    }

    public override bool VisitMainClassDeclaration(MiniJavaParser.MainClassDeclarationContext context)
    {
        var className = context.ID().Symbol.Text;
        
        var typeGen = _assemblyGen.Class(className);
        _currentClass = typeGen;

        _classes[className] = typeGen;

        VisitMainClassBody(context.mainClassBody());

        _currentClass = null;

        return true;
    }

    public override bool VisitMainClassBody(MiniJavaParser.MainClassBodyContext context)
    {
        return VisitMainMethod(context.mainMethod());
    }

    public override bool VisitMainMethod(MiniJavaParser.MainMethodContext context)
    {
        VisitMainMethodDeclaration(context.mainMethodDeclaration());

        _currentCodeGen = _currentMethod!;
        
        VisitChildren(context.statement());
        
        _currentCodeGen = null;
        _currentMethod = null;
        
        return true;
    }

    public override bool VisitMainMethodDeclaration(MiniJavaParser.MainMethodDeclarationContext context)
    {
        var methodGen = _currentClass!.Public.Static.Method(typeof(void), "Main");
        methodGen.BeginParameter(typeof(string[]), "args");
        _currentMethod = methodGen;

        return true;
    }

    public override bool VisitPrintStatement(MiniJavaParser.PrintStatementContext context)
    {
        VisitChildren(context.expression());   
        _currentCodeGen!.WriteLine(_currentOperand);

        _currentOperand = null;
        
        return true;
    }

    public override bool VisitIntLitExpression(MiniJavaParser.IntLitExpressionContext context)
    {
        _currentOperand = int.Parse(context.INT().Symbol.Text);

        return true;
    }
}
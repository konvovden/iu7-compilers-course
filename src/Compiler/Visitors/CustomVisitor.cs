using Antlr4.Runtime.Tree;

namespace Compiler;

public class CustomVisitor : MiniJavaBaseVisitor<object>
{
    public override object VisitChildren(IRuleNode node)
    {
        Console.WriteLine(node.GetType().Name);
        return base.VisitChildren(node);
    }
}
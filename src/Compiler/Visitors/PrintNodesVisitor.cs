using System;
using Antlr4.Runtime.Tree;

namespace Compiler.Visitors
{
    public class PrintNodesVisitor : MiniJavaBaseVisitor<object>
    {
        public override object VisitChildren(IRuleNode node)
        {
            Console.WriteLine(node.GetType().Name);
            return base.VisitChildren(node);
        }
    }
}
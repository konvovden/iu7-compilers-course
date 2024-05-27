using Antlr4.Runtime;
using Compiler;
using Compiler.Visitors;

namespace Startup;

class Program
{
    static void Main(string[] args)
    {
        var exampleName = "hello";

        var input = new AntlrFileStream($"examples/{exampleName}.java");
        var lexer = new MiniJavaLexer(input);
        var tokenStream = new CommonTokenStream(lexer);
        var parser = new MiniJavaParser(tokenStream);

        var goalContext = parser.goal();

        var visitor = new CustomVisitor();
        visitor.Visit(goalContext);

        var codeGenVisitor = new CodeGenVisitor("test");
        codeGenVisitor.Visit(goalContext);

        
        Console.WriteLine("END");
    }
}
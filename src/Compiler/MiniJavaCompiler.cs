using Antlr4.Runtime;
using Compiler.Visitors;
using TriAxis.RunSharp;

namespace Compiler
{
    public class MiniJavaCompiler
    {
        public void Compile(string sourceFile, string assemblyName, string outputFile)
        {
            var input = new AntlrFileStream(sourceFile);
            var lexer = new MiniJavaLexer(input);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new MiniJavaParser(tokenStream);

            var printNodesVisitor = new PrintNodesVisitor();
            printNodesVisitor.Visit(parser.goal());
            parser.Reset();
            
            var assemblyGenerator = new AssemblyGen(assemblyName, new CompilerOptions()
            {
                OutputPath = outputFile
            });

            var classesDeclarations = new ClassDeclarationsVisitor(assemblyGenerator);
            classesDeclarations.Visit(parser.goal());

            var classes = classesDeclarations.Classes;

            var classesMethodsDeclarationsVisitor = new ClassesMethodsDeclarationsVisitor(assemblyGenerator, classes);
            parser.Reset();
            classesMethodsDeclarationsVisitor.Visit(parser.goal());

            var classesMethods = classesMethodsDeclarationsVisitor.ClassesMethods;

            var methodsImplementationVisitor = new MethodsImplementationVisitor(assemblyGenerator,
                classes,
                classesMethods);
            
            parser.Reset();
            methodsImplementationVisitor.Visit(parser.goal());
            
            assemblyGenerator.Save();
        }
    }
}


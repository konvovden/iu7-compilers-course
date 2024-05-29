using System;
using Antlr4.Runtime;
using Compiler;
using Compiler.Visitors;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleName = "linkedlist_reverse";

            Console.WriteLine(new Random().Next(10));
            Console.WriteLine(new Random().Next(10));
            
            var miniJavaCompiler = new MiniJavaCompiler();
            miniJavaCompiler.Compile($"examples/{exampleName}.java", exampleName, $"output/{exampleName}.exe");

            AppDomain.CurrentDomain.ExecuteAssembly($"output/{exampleName}.exe");
            
            Console.WriteLine("END");
        }
    }
}
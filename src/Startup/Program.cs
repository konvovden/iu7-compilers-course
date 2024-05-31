using System;
using System.IO;
using System.Linq;
using Antlr4.Runtime;
using Compiler;
using Compiler.Visitors;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAllTests();
            //RunTest("_inheritance");
        }

        private static void RunTest(string exampleName, bool executeAssembly = true)
        {
            Console.WriteLine($"Starting test for '{exampleName}'");
            
            var miniJavaCompiler = new MiniJavaCompiler();
            miniJavaCompiler.Compile($"examples/{exampleName}.java", exampleName, $"output/{exampleName}.exe");
            Console.WriteLine($"File {exampleName}.java successfully compiled to {exampleName}.exe");

            if (executeAssembly)
            {
                Console.WriteLine("Executing created assembly...");
                AppDomain.CurrentDomain.ExecuteAssembly($"output/{exampleName}.exe");
            }

            Console.WriteLine($"End test for '{exampleName}'\n");
        }

        private static void RunAllTests(bool executeAssembly = true)
        {
            var examples = Directory.EnumerateFiles("examples/", "*.java")
                .Select(f => f.Replace("examples/", ""))
                .Select(f => f.Replace(".java", ""));

            foreach (var example in examples)
                RunTest(example, executeAssembly);
            
        }
    }
}
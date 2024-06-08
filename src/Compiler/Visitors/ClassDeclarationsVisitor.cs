using System;
using System.Collections.Generic;
using TriAxis.RunSharp;

namespace Compiler.Visitors
{
    public class ClassDeclarationsVisitor : MiniJavaBaseVisitor<bool>
    {
        public Dictionary<string, TypeGen> Classes { get; }
        
        private readonly AssemblyGen _assemblyGen;

        public ClassDeclarationsVisitor(AssemblyGen assemblyGen)
        {
            _assemblyGen = assemblyGen;
            Classes = new Dictionary<string, TypeGen>();
        }

        public override bool VisitMainClassDeclaration(MiniJavaParser.MainClassDeclarationContext context)
        {
            var className = context.ID().Symbol.Text;

            var classGen = _assemblyGen.Public.Class(className);

            Classes[className] = classGen;
            
            return base.VisitMainClassDeclaration(context);
        }

        public override bool VisitClassDeclaration(MiniJavaParser.ClassDeclarationContext context)
        {
            var className = context.ID().Symbol.Text;
            
            TypeGen baseType = null;
            
            var typeContext = context.type();
            if (context.type() != null)
                baseType = Classes[typeContext.ID().Symbol.Text];

            var classGen = _assemblyGen.Public.Class(className, baseType ?? typeof(object));

            Classes[className] = classGen;
            
            return base.VisitClassDeclaration(context);
        }
    }
}
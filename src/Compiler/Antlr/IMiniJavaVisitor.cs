//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/konvovden/Study/10sem/iu7-compilers-course/src/Compiler/MiniJava.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419



using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MiniJavaParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IMiniJavaVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.goal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGoal([NotNull] MiniJavaParser.GoalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.mainClassDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMainClassDeclaration([NotNull] MiniJavaParser.MainClassDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassDeclaration([NotNull] MiniJavaParser.ClassDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.mainClassBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMainClassBody([NotNull] MiniJavaParser.MainClassBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.mainMethod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMainMethod([NotNull] MiniJavaParser.MainMethodContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.mainMethodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMainMethodDeclaration([NotNull] MiniJavaParser.MainMethodDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassBody([NotNull] MiniJavaParser.ClassBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.fieldDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFieldDeclaration([NotNull] MiniJavaParser.FieldDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.varDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDeclaration([NotNull] MiniJavaParser.VarDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodDeclaration([NotNull] MiniJavaParser.MethodDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodBody([NotNull] MiniJavaParser.MethodBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.formalParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormalParameters([NotNull] MiniJavaParser.FormalParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormalParameterList([NotNull] MiniJavaParser.FormalParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormalParameter([NotNull] MiniJavaParser.FormalParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] MiniJavaParser.TypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>nestedStatement</c>
	/// labeled alternative in <see cref="MiniJavaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNestedStatement([NotNull] MiniJavaParser.NestedStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ifElseStatement</c>
	/// labeled alternative in <see cref="MiniJavaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfElseStatement([NotNull] MiniJavaParser.IfElseStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>whileStatement</c>
	/// labeled alternative in <see cref="MiniJavaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatement([NotNull] MiniJavaParser.WhileStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>printStatement</c>
	/// labeled alternative in <see cref="MiniJavaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintStatement([NotNull] MiniJavaParser.PrintStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>assignStatement</c>
	/// labeled alternative in <see cref="MiniJavaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignStatement([NotNull] MiniJavaParser.AssignStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>arrayAssignStatement</c>
	/// labeled alternative in <see cref="MiniJavaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayAssignStatement([NotNull] MiniJavaParser.ArrayAssignStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>returnStatement</c>
	/// labeled alternative in <see cref="MiniJavaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] MiniJavaParser.ReturnStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>recurStatement</c>
	/// labeled alternative in <see cref="MiniJavaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRecurStatement([NotNull] MiniJavaParser.RecurStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ltExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLtExpression([NotNull] MiniJavaParser.LtExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>objectInstantiationExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObjectInstantiationExpression([NotNull] MiniJavaParser.ObjectInstantiationExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>arrayInstantiationExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayInstantiationExpression([NotNull] MiniJavaParser.ArrayInstantiationExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierExpression([NotNull] MiniJavaParser.IdentifierExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>methodCallExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodCallExpression([NotNull] MiniJavaParser.MethodCallExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpression([NotNull] MiniJavaParser.NotExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>booleanLitExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanLitExpression([NotNull] MiniJavaParser.BooleanLitExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parenExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenExpression([NotNull] MiniJavaParser.ParenExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>intLitExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntLitExpression([NotNull] MiniJavaParser.IntLitExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>andExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndExpression([NotNull] MiniJavaParser.AndExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>arrayAccessExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayAccessExpression([NotNull] MiniJavaParser.ArrayAccessExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>addExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddExpression([NotNull] MiniJavaParser.AddExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>thisExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitThisExpression([NotNull] MiniJavaParser.ThisExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>arrayLengthExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayLengthExpression([NotNull] MiniJavaParser.ArrayLengthExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>negExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNegExpression([NotNull] MiniJavaParser.NegExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>subExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubExpression([NotNull] MiniJavaParser.SubExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>mulExpression</c>
	/// labeled alternative in <see cref="MiniJavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMulExpression([NotNull] MiniJavaParser.MulExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.methodArgumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodArgumentList([NotNull] MiniJavaParser.MethodArgumentListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.intArrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntArrayType([NotNull] MiniJavaParser.IntArrayTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.booleanType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanType([NotNull] MiniJavaParser.BooleanTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniJavaParser.intType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntType([NotNull] MiniJavaParser.IntTypeContext context);
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dotne\source\repos\spectnetide\Assembler\AntlrZ80EvalGenerator\AntlrZ80EvalGenerator\Z80Eval.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Spect.Net.EvalParser.Generated {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="Z80EvalParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IZ80EvalVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompileUnit([NotNull] Z80EvalParser.CompileUnitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.formatSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormatSpec([NotNull] Z80EvalParser.FormatSpecContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] Z80EvalParser.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.orExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrExpr([NotNull] Z80EvalParser.OrExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.xorExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitXorExpr([NotNull] Z80EvalParser.XorExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.andExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndExpr([NotNull] Z80EvalParser.AndExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.equExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEquExpr([NotNull] Z80EvalParser.EquExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.relExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelExpr([NotNull] Z80EvalParser.RelExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.shiftExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShiftExpr([NotNull] Z80EvalParser.ShiftExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.addExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddExpr([NotNull] Z80EvalParser.AddExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.multExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultExpr([NotNull] Z80EvalParser.MultExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.unaryExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExpr([NotNull] Z80EvalParser.UnaryExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.literalExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralExpr([NotNull] Z80EvalParser.LiteralExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.symbolExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSymbolExpr([NotNull] Z80EvalParser.SymbolExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.z80Spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitZ80Spec([NotNull] Z80EvalParser.Z80SpecContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.reg8"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg8([NotNull] Z80EvalParser.Reg8Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.reg16"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReg16([NotNull] Z80EvalParser.Reg16Context context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.memIndirect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemIndirect([NotNull] Z80EvalParser.MemIndirectContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.wordMemIndirect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWordMemIndirect([NotNull] Z80EvalParser.WordMemIndirectContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80EvalParser.flags"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFlags([NotNull] Z80EvalParser.FlagsContext context);
}
} // namespace Spect.Net.EvalParser.Generated

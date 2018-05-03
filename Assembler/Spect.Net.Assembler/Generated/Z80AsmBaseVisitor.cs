//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dotne\source\repos\spectnetide\Assembler\AntlrZ80AsmParserGenerator\ParserGenerator\Z80Asm.g4 by ANTLR 4.6.4

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Spect.Net.Assembler.Generated {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IZ80AsmVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.4")]
[System.CLSCompliant(false)]
public partial class Z80AsmBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IZ80AsmVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.compileUnit"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCompileUnit([NotNull] Z80AsmParser.CompileUnitContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.asmline"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAsmline([NotNull] Z80AsmParser.AsmlineContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.label"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLabel([NotNull] Z80AsmParser.LabelContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.comment"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitComment([NotNull] Z80AsmParser.CommentContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.pragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPragma([NotNull] Z80AsmParser.PragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.directive"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirective([NotNull] Z80AsmParser.DirectiveContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStatement([NotNull] Z80AsmParser.StatementContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMacroStatement([NotNull] Z80AsmParser.MacroStatementContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroEndMarker"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMacroEndMarker([NotNull] Z80AsmParser.MacroEndMarkerContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.loopStatement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLoopStatement([NotNull] Z80AsmParser.LoopStatementContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.loopEndMarker"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLoopEndMarker([NotNull] Z80AsmParser.LoopEndMarkerContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroInvocation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMacroInvocation([NotNull] Z80AsmParser.MacroInvocationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.orgPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOrgPragma([NotNull] Z80AsmParser.OrgPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.entPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEntPragma([NotNull] Z80AsmParser.EntPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.xentPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitXentPragma([NotNull] Z80AsmParser.XentPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.dispPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDispPragma([NotNull] Z80AsmParser.DispPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.equPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEquPragma([NotNull] Z80AsmParser.EquPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.varPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVarPragma([NotNull] Z80AsmParser.VarPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defbPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDefbPragma([NotNull] Z80AsmParser.DefbPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defwPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDefwPragma([NotNull] Z80AsmParser.DefwPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defmPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDefmPragma([NotNull] Z80AsmParser.DefmPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.skipPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSkipPragma([NotNull] Z80AsmParser.SkipPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.externPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExternPragma([NotNull] Z80AsmParser.ExternPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defsPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDefsPragma([NotNull] Z80AsmParser.DefsPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.fillbPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFillbPragma([NotNull] Z80AsmParser.FillbPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.fillwPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFillwPragma([NotNull] Z80AsmParser.FillwPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.modelPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitModelPragma([NotNull] Z80AsmParser.ModelPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.alignPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAlignPragma([NotNull] Z80AsmParser.AlignPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.tracePragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTracePragma([NotNull] Z80AsmParser.TracePragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.rndSeedPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRndSeedPragma([NotNull] Z80AsmParser.RndSeedPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.defgPragma"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDefgPragma([NotNull] Z80AsmParser.DefgPragmaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.operation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOperation([NotNull] Z80AsmParser.OperationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.trivialOperation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTrivialOperation([NotNull] Z80AsmParser.TrivialOperationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.compoundOperation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCompoundOperation([NotNull] Z80AsmParser.CompoundOperationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.trivialNextOperation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTrivialNextOperation([NotNull] Z80AsmParser.TrivialNextOperationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.operand"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOperand([NotNull] Z80AsmParser.OperandContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg8"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReg8([NotNull] Z80AsmParser.Reg8Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg8Idx"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReg8Idx([NotNull] Z80AsmParser.Reg8IdxContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg8Spec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReg8Spec([NotNull] Z80AsmParser.Reg8SpecContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg16"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReg16([NotNull] Z80AsmParser.Reg16Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg16Idx"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReg16Idx([NotNull] Z80AsmParser.Reg16IdxContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.reg16Spec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReg16Spec([NotNull] Z80AsmParser.Reg16SpecContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.regIndirect"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRegIndirect([NotNull] Z80AsmParser.RegIndirectContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.cPort"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCPort([NotNull] Z80AsmParser.CPortContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.memIndirect"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMemIndirect([NotNull] Z80AsmParser.MemIndirectContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.indexedAddr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIndexedAddr([NotNull] Z80AsmParser.IndexedAddrContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.condition"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCondition([NotNull] Z80AsmParser.ConditionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpr([NotNull] Z80AsmParser.ExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.orExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOrExpr([NotNull] Z80AsmParser.OrExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.xorExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitXorExpr([NotNull] Z80AsmParser.XorExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.andExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAndExpr([NotNull] Z80AsmParser.AndExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.equExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEquExpr([NotNull] Z80AsmParser.EquExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.relExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRelExpr([NotNull] Z80AsmParser.RelExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.shiftExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitShiftExpr([NotNull] Z80AsmParser.ShiftExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.addExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAddExpr([NotNull] Z80AsmParser.AddExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.multExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMultExpr([NotNull] Z80AsmParser.MultExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.unaryExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitUnaryExpr([NotNull] Z80AsmParser.UnaryExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.functionInvocation"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunctionInvocation([NotNull] Z80AsmParser.FunctionInvocationContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.literalExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLiteralExpr([NotNull] Z80AsmParser.LiteralExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.symbolExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSymbolExpr([NotNull] Z80AsmParser.SymbolExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80AsmParser.macroParam"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMacroParam([NotNull] Z80AsmParser.MacroParamContext context) { return VisitChildren(context); }
}
} // namespace Spect.Net.Assembler.Generated

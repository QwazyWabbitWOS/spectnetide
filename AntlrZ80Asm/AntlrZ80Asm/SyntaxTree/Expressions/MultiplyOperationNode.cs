namespace AntlrZ80Asm.SyntaxTree.Expressions
{
    /// <summary>
    /// This class represents the multiplication operation
    /// </summary>
    public sealed class MultiplyOperationNode : BinaryOperationNode
    {
        /// <summary>
        /// Calculates the result of the binary operation.
        /// </summary>
        /// <param name="evalContext">Evaluation context</param>
        /// <returns>Result of the operation</returns>
        public override ushort Calculate(IEvaluationContext evalContext)
            => (ushort)(LeftOperand.Evaluate(evalContext) 
                * RightOperand.Evaluate(evalContext));
    }
}
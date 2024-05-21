namespace A8;
public abstract class UnaryOperator : Expression, IOperator
{
    protected Expression Operand;

    public UnaryOperator()
    {
        throw new NotImplementedException();
    }

    public UnaryOperator(TextReader reader)
    {
        this.Operand = Expression.GetNextExpression(reader);
    }
    public sealed override string ToString() => $"{this.OperatorSymbol}{this.Operand}";

    public abstract string OperatorSymbol { get; }
}

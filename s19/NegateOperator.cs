namespace A8;
public class NegateOperator : UnaryOperator
{
    public NegateOperator(TextReader reader)
    : base(reader)
    {
    }

    public override string OperatorSymbol => "-";

    public override double Evaluate() => -this.Operand.Evaluate();
}

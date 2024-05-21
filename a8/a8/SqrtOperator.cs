namespace A8;
public class SqrtOperator : UnaryOperator
{
    public SqrtOperator(TextReader reader)
    : base(reader)
    {
    }

    public override string OperatorSymbol => "Sqrt";

/// ino naneveshtam chon nemidoonam radikal chie . 
    public override double Evaluate() => Math.Sqrt(this.Operand.Evaluate());
}

namespace A8;
public class SqrtOperator : UnaryOperator
{
    public SqrtOperator(TextReader reader)
    : base(reader)
    {
    }

    public override string OperatorSymbol => "rad";

/// ino naneveshtam chon nemidoonam radikal chie . 
    public override double Evaluate() => this.Operand.Evaluate();
}

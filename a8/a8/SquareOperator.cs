namespace A8;
public class SquareOperator : UnaryOperator
{
    public SquareOperator(TextReader reader)
    : base(reader)
    {
    }

    public override string OperatorSymbol => "Square";

/// <summary>
/// inam naeveshtam
/// </summary>
/// <returns></returns>
/// <exception cref="NotImplementedException"></exception>
    public override double Evaluate() => Math.Pow(this.Operand.Evaluate(),2);

}

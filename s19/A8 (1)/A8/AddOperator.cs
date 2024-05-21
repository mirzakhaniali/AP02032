namespace A8;

public class AddOperator : BinaryOperator
{
    public AddOperator(TextReader reader)
    {
        exper
    }

    public override string OperatorSymbol => throw new NotImplementedException();

    public override double Evaluate() =>
        this.LHS.Evaluate() + this.RHS.Evaluate();
}

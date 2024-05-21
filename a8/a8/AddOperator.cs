using System.Diagnostics.CodeAnalysis;

namespace A8;

public class AddOperator : BinaryOperator
{
    public AddOperator(TextReader reader)
    : base(reader)
    {
    }


    public override string OperatorSymbol => "+";

    public override double Evaluate() =>
        this.LHS.Evaluate() + this.RHS.Evaluate();
}

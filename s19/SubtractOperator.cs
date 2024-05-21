﻿namespace A8;
public class SubtractOperator : BinaryOperator
{
    public SubtractOperator(TextReader reader)
    : base(reader)
    {
    }

    public override string OperatorSymbol => "-";

    public override double Evaluate() => this.LHS.Evaluate()-this.RHS.Evaluate();
}

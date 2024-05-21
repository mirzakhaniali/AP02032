﻿namespace A8;
public class DivideOperator : BinaryOperator
{
    public DivideOperator(TextReader reader)
    : base(reader)
    {
    }

    public override string OperatorSymbol => "/";

    public override double Evaluate() => this.LHS.Evaluate()/this.RHS.Evaluate();
}
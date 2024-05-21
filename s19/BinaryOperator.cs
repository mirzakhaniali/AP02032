using System;
using System.IO;

namespace A8;
public abstract class BinaryOperator : Expression, IOperator
{
    protected Expression LHS;
    protected Expression RHS;

    public BinaryOperator()
    {
    }

    public BinaryOperator(TextReader reader)
    {
        this.LHS=Expression.GetNextExpression(reader);
        this.RHS= Expression.GetNextExpression(reader);
    }

    public abstract string OperatorSymbol { get; }

    public sealed override string ToString() => this.LHS.ToString()+this.OperatorSymbol+this.RHS.ToString();

}

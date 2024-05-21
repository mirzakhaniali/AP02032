namespace A8;
public class NumberExpression : Expression
{
    protected double Number;

    public NumberExpression(string line)
    {
        Number=int.Parse(line);
    }

    public override double Evaluate() => this.Number;

    public override string ToString() => this.Number.ToString();
}

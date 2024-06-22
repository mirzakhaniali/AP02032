namespace E2.Calc
{
    /// <summary>
    /// ماشین حساب وقتی که جواب یک محاسبه
    /// را نشان میدهد وارد این وضعیت میشود
    /// </summary>
    public class ComputeState : CalculatorState
    {
        public ComputeState(Calculator calc) : base(calc) { }

        public override IState EnterEqual()
        {
            Calc.DisplayError("Syntax Error");
            return new ErrorState(this.Calc);
        }

        public override IState EnterNonZeroDigit(char c)
        {
            if(char.IsDigit(c))
                this.Calc.Display+=c;
            return new AccumulateState(Calc);
        }

        public override IState EnterZeroDigit()
        {
            if(this.Calc.Display!="0")
                this.Calc.Display="0";
            return new AccumulateState(Calc);
        }

        // #5 لطفا
        public override IState EnterOperator(char c) => null;

        public override IState EnterPoint()
        {
            Calc.Display = "0.";
            return new PointState(this.Calc);
        }

    }
}
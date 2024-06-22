namespace E2.Calc
{
    public class AccumulateState : CalculatorState
    {
        public AccumulateState(Calculator calc) : base(calc) { }

        // #7 لطفا
        public override IState EnterEqual() => this.ProcessOperator(new ComputeState(this.Calc));
        public override IState EnterZeroDigit() => EnterNonZeroDigit('0');
        public override IState EnterNonZeroDigit(char c)
        {
            if(!char.IsDigit(c))
                return new ErrorState(this.Calc);
            this.Calc.Display+=c;
            this.Calc.Accumulation=double.Parse(c.ToString());
            return new AccumulateState(this.Calc);
        }

        // #9 لطفا!
        public override IState EnterOperator(char c) => this.ProcessOperator(new ComputeState(this.Calc) , c);

        // #10 لطفا!
        public override IState EnterPoint()
        {
            return new AccumulateState(this.Calc);
        }
    }
}
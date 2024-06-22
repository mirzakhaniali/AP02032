namespace E2.Calc
{
    /// <summary>
    /// این وضعیت نشان دهنده حالتی است که نقطه زده شده
    /// این وضعیت شبیه وضعیت
    /// Accumulate
    /// است
    /// تنها فرقش این است که نقطه جدیدی نمی شود زد.
    /// تغییرات لازم را برای این کار بدهید.
    /// </summary>
    public class PointState : AccumulateState
    {
        public PointState(Calculator calc) : base(calc) { }

        public override IState EnterZeroDigit()
        {
            return EnterNonZeroDigit('0');
        }

        public override IState EnterNonZeroDigit(char c)
        {
            if(!char.IsDigit(c))    
                return new ErrorState(this.Calc);
            this.Calc.Display += c.ToString();
            this.Calc.Accumulation=double.Parse(c.ToString());
            return new PointState(this.Calc);
        }

        public override IState EnterOperator(char c) => 
            ProcessOperator(new PointState(this.Calc), c);

        public override IState EnterPoint()
        {
            this.Calc.Display = "0.";
            return new PointState(this.Calc);
        }
    }
}
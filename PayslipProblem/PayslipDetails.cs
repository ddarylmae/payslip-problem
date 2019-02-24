namespace PayslipProblem
{
    public class PayslipDetails
    {
        public string Name { get; set; }
        public string PayPeriod { get; set; }
        public uint GrossIncome { get; set; }
        public uint IncomeTax { get; set; }
        public uint NetIncome { get; set; }
        public uint Super { get; set; }
    }
}
namespace PayslipProblem
{
    public interface IPayslipGenerator
    {
        PayslipDetails GetPayslipDetails(EmployeeDetails employee);
        void DisplayPayslipDetails(PayslipDetails payslip);
        uint CalculateGrossIncome(uint annualIncome);
        uint CalculateIncomeTax(uint annualIncome);
        uint CalculateNetIncome(uint annualIncome);
        uint CalculateSuper(uint netIncome, uint superRate);
    }
}
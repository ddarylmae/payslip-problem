namespace PayslipProblem
{
    public interface IPayslipGenerator
    {
        PayslipDetails GetPayslipDetails(EmployeeDetails employee);
        void DisplayPayslipDetails(PayslipDetails payslip);
        int CalculateGrossIncome(int annualIncome);
        int CalculateIncomeTax(int annualIncome);
        int CalculateNetIncome(int annualIncome);
        int CalculateSuper(int netIncome, int superRate);
    }
}
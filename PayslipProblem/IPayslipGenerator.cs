namespace PayslipProblem
{
    public interface IPayslipGenerator
    {
        PayslipDetails GetPayslipDetails(EmployeeDetails employee);
        void DisplayPayslipDetails(PayslipDetails payslip);
        int CalculateGrossIncome(int annualIncome);
        int CalculateIncomeTax(int annualSalary);
        int CalculateNetIncome(int grossIncome, int incomeTax);
        int CalculateSuper(int grossIncome, float superRate);
    }
}
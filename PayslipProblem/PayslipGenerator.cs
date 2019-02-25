using System;

namespace PayslipProblem
{
    public class PayslipGenerator : IPayslipGenerator
    {
        public PayslipDetails GetPayslipDetails(EmployeeDetails employee)
        {
            return null;
        }
        
        public void DisplayPayslipDetails(PayslipDetails payslip)
        {
            Console.WriteLine($"Name: {payslip.Name} \n" + 
                              $"Pay period: {payslip.PayPeriod}");
        }

        public int CalculateGrossIncome(int annualIncome)
        {
            return (int) Math.Round(annualIncome / 12.0);
        }

        public int CalculateIncomeTax(int annualIncome)
        {
            return 0;
        }

        public int CalculateNetIncome(int annualIncome)
        {
            return 0;
        }

        public int CalculateSuper(int netIncome, int superRate)
        {
            return 0;
        }
    }
}
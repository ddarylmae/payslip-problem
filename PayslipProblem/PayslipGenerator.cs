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

        public uint CalculateGrossIncome(uint annualIncome)
        {
            return (uint) Math.Round(annualIncome / 12.0);
        }

        public uint CalculateIncomeTax(uint annualIncome)
        {
            throw new NotImplementedException();
        }

        public uint CalculateNetIncome(uint annualIncome)
        {
            throw new NotImplementedException();
        }

        public uint CalculateSuper(uint netIncome, uint superRate)
        {
            throw new NotImplementedException();
        }
    }
}
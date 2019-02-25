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
            int netIncome;
            
            if (annualIncome > 180000)
            {
                netIncome = (int) Math.Round((annualIncome - 180000) * 0.45 + 54232);
            }
            else if (annualIncome > 87000)
            {
                netIncome = (int) Math.Round((annualIncome - 87000) * 0.37 + 19822);
            }
            else if(annualIncome > 37000)
            {
                netIncome = (int) Math.Round((annualIncome - 37000) * 0.325 + 3572);
            }
            else if(annualIncome > 18200)
            {
                netIncome = (int) Math.Round((annualIncome - 18200) * 0.19);
            }
            else
            {
                netIncome = 0;
            }

            return netIncome;
        }

        public int CalculateNetIncome(int grossIncome, int incomeTax)
        {
            return grossIncome - incomeTax;
        }

        public int CalculateSuper(int netIncome, float superRate)
        {
            return (int) Math.Round(netIncome * (superRate/100));
        }
    }
}
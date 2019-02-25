using System;

namespace PayslipProblem
{
    public class PayslipGenerator : IPayslipGenerator
    {
        public PayslipDetails GetPayslipDetails(EmployeeDetails employee)
        {
            var payslip = new PayslipDetails
            {
                Name = $"{employee.FirstName} {employee.Surname}",
                PayPeriod = $"{employee.StartDate} - {employee.EndDate}",
                GrossIncome = CalculateGrossIncome(employee.AnnualSalary),
                IncomeTax = CalculateIncomeTax(employee.AnnualSalary)
            };

            payslip.NetIncome = CalculateNetIncome(payslip.GrossIncome, payslip.IncomeTax);
            payslip.Super = CalculateSuper(payslip.GrossIncome, employee.SuperRate);

            return payslip;
        }
        
        public void DisplayPayslipDetails(PayslipDetails payslip)
        {
            Console.WriteLine($"Name: {payslip.Name} \n" + 
                              $"Pay Period: {payslip.PayPeriod} \n"+
                              $"Gross Income: {payslip.GrossIncome} \n" + 
                              $"Income Tax: {payslip.IncomeTax} \n" + 
                              $"Net Income: {payslip.NetIncome} \n" +
                              $"Super: {payslip.Super} \n\n" + 
                              "Thank you for using MYOB!");
        }

        public int CalculateGrossIncome(int annualIncome)
        {
            return (int) Math.Round(annualIncome / 12.0);
        }

        public int CalculateIncomeTax(int annualSalary)
        {
            if (annualSalary > 180000)
            {
                return (int) Math.Round(((annualSalary - 180000) * 0.45 + 54232) / 12);
            }
            if (annualSalary > 87000)
            {
                return (int) Math.Round(((annualSalary - 87000) * 0.37 + 19822) / 12);
            }
            if(annualSalary > 37000)
            {
                return (int) Math.Round(((annualSalary - 37000) * 0.325 + 3572) / 12);
            }
            if(annualSalary > 18200)
            {
                return (int) Math.Round((annualSalary - 18200) * 0.19 / 12);
            }

            return 0;
        }

        public int CalculateNetIncome(int grossIncome, int incomeTax)
        {
            return grossIncome - incomeTax;
        }

        public int CalculateSuper(int grossIncome, float superRate)
        {
            return (int) Math.Round(grossIncome * (superRate/100));
        }
    }
}
using System;

namespace PayslipProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeService employeeService = new EmployeeService();
            var employee = employeeService.GetEmployeeDetailsFromUser();
            
            IPayslipGenerator payslipGenerator = new PayslipGenerator();
            var payslip = payslipGenerator.GetPayslipDetails(employee);
            payslipGenerator.DisplayPayslipDetails(payslip);
        }
    }
}
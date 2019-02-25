using System;

namespace PayslipProblem
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeDetails GetEmployeeDetailsFromUser()
        {
            var employee = new EmployeeDetails();
            
            Console.WriteLine("Please input your first name: ");
            employee.FirstName = Console.ReadLine();
            
            Console.WriteLine("Please input your surname: ");
            employee.Surname = Console.ReadLine();

            Console.WriteLine("Please enter your annual salary: ");
            string salaryInput = Console.ReadLine();
            int salary;
            while (!int.TryParse(salaryInput, out salary) || salary < 0)
            {
                Console.WriteLine("Please enter a valid annual salary value: ");
                salaryInput = Console.ReadLine();
            }

            employee.AnnualSalary = salary;
            
            Console.WriteLine("Please enter your super rate: ");
            var superRateInput = Console.ReadLine();
            float rate;
            while (!float.TryParse(superRateInput, out rate) || rate < 0 || rate > 50)
            {
                Console.WriteLine("Please enter a valid super rate value (0-50): ");
                superRateInput = Console.ReadLine();
            }
            employee.SuperRate = rate;
            
            Console.WriteLine("Please enter your payment start date: ");
            employee.StartDate = Console.ReadLine();
            
            Console.WriteLine("Please enter your payment end date: ");
            employee.EndDate = Console.ReadLine();
            
            return employee;
        }
    }
}
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
            
            if (int.TryParse(salaryInput, out var salary) && salary >= 0)
            {
                employee.AnnualSalary = (uint) salary;
            }
            else
            {
                Console.WriteLine("Invalid salary");
            }
            
            Console.WriteLine("Please enter your super rate: ");
            string superRate = Console.ReadLine();
            if(float.TryParse(superRate, out var rate))
            {
                employee.SuperRate = rate;
            }
            
            Console.WriteLine("Please enter your payment start date: ");
            employee.StartDate = Console.ReadLine();
            
            Console.WriteLine("Please enter your payment end date: ");
            employee.EndDate = Console.ReadLine();
            
            // TODO Remove display details
            Console.WriteLine($"\nDetails: {employee.FirstName} {employee.Surname} \n{employee.AnnualSalary}\n{employee.SuperRate}" + 
                              $"\n{employee.StartDate}\n{employee.EndDate}");

            return employee;
        }
    }
}
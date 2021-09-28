using System;

namespace Holiday_Park_latest_payroll_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("Welcome to Rotorua Thermal Holiday Park's payroll system");
            Console.WriteLine("********************************************************");
            // The above shows Welcome message for staff members in Rotorua Thermal Holiday Park. 

            Employee employee1 = new Employee(); //object of Employee class with an appropriate name

            Console.WriteLine("Please enter employee's name? ");
            employee1.EmployeeName = Console.ReadLine();

            Console.WriteLine("Please enter employee's gross annual salary? ");
            employee1.AnnualGrossSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter tax rate in two decimal places instead of percentage? ");
            employee1.TaxRate = Convert.ToDouble(Console.ReadLine());

            employee1.CalcNet();
            Console.WriteLine("The employee's name is {0}\nThe employee's gross salary is {1}\nThe employee's tax rate is {2}\nThe employee's net salary is {3}", employee1.EmployeeName, employee1.AnnualGrossSalary.ToString("$0.00"), employee1.TaxRate.ToString("0.00"), employee1.NetSalary.ToString("$0.00"));
            //This CalNet method is suppose to calculate your net salary after entering your Annual Gross Salary. Furthermore, entering tax rate in two decimal places instead percentages. 

            Console.ReadKey();

            //This program is meant for staff members who are responsible for other employees in the business getting paid when they are getting netsalary. - Rahul Khatri
        }
    }
}
    


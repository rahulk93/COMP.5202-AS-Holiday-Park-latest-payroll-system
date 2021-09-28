using System;
using System.Collections.Generic;
using System.Text;

namespace Holiday_Park_latest_payroll_system
{
    class Employee
    {
        private string employeeName;
        private double annualgrossSalary;
        private double Taxrate;
        private double netSalary;
        // The above are private instance variables

        // The below is public constructor
        public Employee()
        {
            Console.WriteLine("Employee record created");
        }

        // This below are public properties
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public double AnnualGrossSalary
        {
            get { return annualgrossSalary; }
            set { annualgrossSalary = value; }
        }

        public double TaxRate
        {
            get { return Taxrate; }
            set { Taxrate = value; }
        }

        public double NetSalary
        {
            get { return netSalary; }
            set { netSalary = value; }
        }

        //This below is CalcNet method and besy formula to calculate Net Salary. 
        public void CalcNet()
        {
            netSalary = annualgrossSalary - (annualgrossSalary * Taxrate);
        }



    }
}

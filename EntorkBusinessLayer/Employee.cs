using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntorkBusinessLayer
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public double Salary { get; set; }

        public Employee(int employeeId, string name, string contactNumber,
            double salary)
        {
            EmployeeId = employeeId;
            Name = name;
            ContactNumber = contactNumber;
            Salary = salary;
        }

        public virtual string GetEmployeeInfo()
        {
            return EmployeeId + " " + Name + " " + ContactNumber + " " + Salary;
        }

        public virtual double CalculateSalary()
        {
            return Salary;
        } 
    }
}

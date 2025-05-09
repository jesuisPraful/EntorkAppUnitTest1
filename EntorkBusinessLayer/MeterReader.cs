using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntorkBusinessLayer
{
    public class MeterReader : Employee
    {
        public int MetersCheckedPerDay { get; set; }

        public MeterReader(int employeeId, string name,
            string contactNumber, double salary, int metersCheckedPerDay) 
            : base(employeeId, name, contactNumber, salary)
        {
            MetersCheckedPerDay = metersCheckedPerDay;
        }

        public override string GetEmployeeInfo()
        {
            string info = base.GetEmployeeInfo();
            return info + " " + MetersCheckedPerDay;
        }

        public override double CalculateSalary()
        {
            double totalSalary = base.CalculateSalary();

            if(MetersCheckedPerDay > 10)
            {
                int extraMeters = MetersCheckedPerDay - 10;
                totalSalary = totalSalary + (extraMeters * 250);
            }
            Salary = totalSalary;
            return totalSalary;
        }
    }
}

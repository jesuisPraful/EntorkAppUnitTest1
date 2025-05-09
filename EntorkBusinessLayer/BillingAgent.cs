using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntorkBusinessLayer
{
    public class BillingAgent : Employee
    {
        public int BillsProcessedPerDay { get; set; }
        public string BaseWorkLocation { get; set; }
        public BillingAgent(int employeeId, string name, string contactNumber,
            double salary, int billsProcessedPerDay, string baseWorkLocation) 
            : base(employeeId, name, contactNumber, salary)
        {
            BillsProcessedPerDay = billsProcessedPerDay;
            BaseWorkLocation = baseWorkLocation;
        }

        public override string GetEmployeeInfo()
        {
            string info = base.GetEmployeeInfo();
            return info + " " + BaseWorkLocation + " " + BillsProcessedPerDay;
        }

        public override double CalculateSalary()
        {
            double totalSalary = base.CalculateSalary();
            
            if(BaseWorkLocation == "New York" || BaseWorkLocation == "London")
            {
                if(BillsProcessedPerDay > 20)
                {
                    totalSalary = totalSalary + (BillsProcessedPerDay * 100);
                }
                else if (BillsProcessedPerDay > 10)
                {
                    totalSalary = totalSalary + (BillsProcessedPerDay * 75);
                }
                else
                {
                    totalSalary = totalSalary + (BillsProcessedPerDay * 50);
                }
            }
            else
            {
                if (BillsProcessedPerDay > 20)
                {
                    totalSalary = totalSalary + (BillsProcessedPerDay * 80);
                }
                else if (BillsProcessedPerDay > 10)
                {
                    totalSalary = totalSalary + (BillsProcessedPerDay * 60);
                }
                else
                {
                    totalSalary = totalSalary + (BillsProcessedPerDay * 40);
                }
            }
            Salary = totalSalary;
            return totalSalary;
        }
    }
}

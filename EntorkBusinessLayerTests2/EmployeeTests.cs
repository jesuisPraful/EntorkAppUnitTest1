using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntorkBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntorkBusinessLayer.Tests
{
    [TestClass()]
    public class EmployeeTests
    {
        [TestMethod()] 
        public void TestEmployeeConstructor()
        {
            Employee employee = new Employee(1, "Jhon", "1234567890", 38900);

            Assert.AreEqual(1, employee.EmployeeId);
            Assert.AreEqual("Jhon", employee.Name);
            Assert.AreEqual("1234567890", employee.ContactNumber);
            Assert.AreEqual(38900, employee.Salary);
        }


        [TestMethod()]
        public void TestGetEmployeeInfo()
        {
            Employee employee = new Employee(1, "Jhon", "1234567890", 38900);
            string expectedInfo = "1 Jhon 1234567890 38900";
            Assert.AreEqual(expectedInfo, employee.GetEmployeeInfo());
        }

        [TestMethod()]
        public void TestCalculateSalary()
        {
            Employee employee = new Employee(1, "Jhon", "1234567890", 38900);
            double expectedSalary = 38900;
            Assert.AreEqual(expectedSalary, employee.CalculateSalary());
        }
    }
}
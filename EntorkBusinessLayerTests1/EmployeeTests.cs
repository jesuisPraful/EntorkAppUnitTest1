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
        [TestMethod]
        public void TestEmployeeConstructor()
        {
            Employee employee = new Employee(1,"Jhon","1234567890",38900);
            Assert.IsNotNull(employee);
            
            int expectedEmployeeId = 1;
            int actualEmployeeId = employee.EmployeeId;
            Assert.AreEqual(expectedEmployeeId, actualEmployeeId);

            string expectedName = "Jhon";
            string actualName = employee.Name;
            Assert.AreEqual(expectedName, actualName);

            string expectedContactNumber = "1234567890";
            string actualContactNumber = employee.ContactNumber;
            Assert.AreEqual(expectedContactNumber,actualContactNumber);

            double expectedSalary = 38900;
            double actualSalary = employee.Salary;
            Assert.AreEqual(expectedSalary,actualSalary);

        }
        [TestMethod]
        public void  TestGetEmployeeInfo()
        {
            Employee employee = new Employee(1, "Jhon", "1234567890", 38900);
            string expected = "1 Jhon 1234567890 38900";
            string actual = employee.GetEmployeeInfo();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCalculateSalary()
        {
            Employee employee = new Employee(1, "Jhon", "1234567890", 38900);
            double expectedSalary = 38900;
            double actualSalary = employee.Salary;
            Assert.AreEqual(expectedSalary, actualSalary);

        }
    }
}
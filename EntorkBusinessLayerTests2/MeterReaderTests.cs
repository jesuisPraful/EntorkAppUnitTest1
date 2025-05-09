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
    public class MeterReaderTests
    { 
        [TestMethod()]
        public void TestMeterReader()
        {
            MeterReader meterReader = new MeterReader(1, "Jhon", "1234567890", 38900, 20);

            Assert.AreEqual(1, meterReader.EmployeeId);
            Assert.AreEqual("Jhon", meterReader.Name);
            Assert.AreEqual("1234567890", meterReader.ContactNumber);
            Assert.AreEqual(38900, meterReader.Salary);
            Assert.AreEqual(20, meterReader.MetersCheckedPerDay);
        }

        [TestMethod()]
        public void TestGetEmployeeInfo()
        {
            MeterReader meterReader = new MeterReader(1, "Jhon", "1234567890", 38900, 20);
            string expectedInfo = "1 Jhon 1234567890 38900 20";
            Assert.AreEqual(expectedInfo, meterReader.GetEmployeeInfo());
        }

        [TestMethod()]
        public void TestCalculateSalaryEmployeeCheckMoreThan10()
        {
            MeterReader meterReader = new MeterReader(1, "Jhon", "1234567890", 38900, 20);
            double expectedSalary = 38900 + (10 * 250); // 10 extra meters
            Assert.AreEqual(expectedSalary, meterReader.CalculateSalary());
        }

        [TestMethod()]
        public void TestCalculateSalaryEmployeeCheckLessThan10()
        {
            MeterReader meterReader = new MeterReader(1, "Jhon", "1234567890", 38900, 5);
            double expectedSalary = 38900; // No extra meters
            Assert.AreEqual(expectedSalary, meterReader.CalculateSalary());
        }
    }
}
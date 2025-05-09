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
        public void TestMeterReaderConstructor()
        {
            MeterReader meterReader = new MeterReader(1, "Jhon", "1234567890", 38900,20);
            Assert.IsNotNull(meterReader);
            int expectedEmployeeId = 1;
            int actualEmployeeId = meterReader.EmployeeId;
            Assert.AreEqual(expectedEmployeeId, actualEmployeeId);

            string expectedName = "Jhon";
            string actualName = meterReader.Name;
            Assert.AreEqual(expectedName, actualName);

            string expectedContactNumber = "1234567890";
            string actualContactNumber = meterReader.ContactNumber;
            Assert.AreEqual(expectedContactNumber, actualContactNumber);

            double expectedSalary = 38900;
            double actualSalary = meterReader.Salary;
            Assert.AreEqual(expectedSalary, actualSalary);


            int expectedMetersCheckedPerDay = 20;
            int actualMetersCheckedPerDay = meterReader.MetersCheckedPerDay;
            Assert.AreEqual(expectedMetersCheckedPerDay,actualMetersCheckedPerDay);
        }

        [TestMethod]
        public void TestGetEmployeeInfo()
        {
            MeterReader meterReader = new MeterReader(1, "Jhon", "1234567890", 38900, 20);
            string expected = "1 Jhon 1234567890 38900 20";
            string actual = meterReader.GetEmployeeInfo();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculateSalarysEmployeeCheckedMoreThan10() {
            
            MeterReader meterReader = new MeterReader(1, "Jhon", "1234567890", 38900, 20);
            int metereChekedPerDay = 20;
            double expectedSalary = 38900 + (metereChekedPerDay - 10)*250;
            double actualSalary = meterReader.CalculateSalary();
            Assert.AreEqual(expectedSalary, actualSalary);
        }
        [TestMethod]
        public void TestCalculateSalarysEmployeeCheckedLessThan10()
        {

            MeterReader meterReader = new MeterReader(1, "Jhon", "1234567890", 38900, 10);

            double expectedSalary = 38900;
            double actualSalary = meterReader.CalculateSalary();
            Assert.AreEqual(expectedSalary, actualSalary);

            
        }

    }
}
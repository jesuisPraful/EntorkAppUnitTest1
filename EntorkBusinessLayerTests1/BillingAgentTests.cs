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
    public class BillingAgentTests
    {
        [TestMethod]
        public void TestBillingAgentsConstructor()
        {
            BillingAgent billingAgent = new BillingAgent(1, "Jhon", "1234567890", 38900,10,"New York");

            Assert.IsNotNull(billingAgent);
            int expectedEmployeeId = 1;
            int actualEmployeeId = billingAgent.EmployeeId;
            Assert.AreEqual(expectedEmployeeId, actualEmployeeId);

            string expectedName = "Jhon";
            string actualName = billingAgent.Name;
            Assert.AreEqual(expectedName, actualName);

            string expectedContactNumber = "1234567890";
            string actualContactNumber = billingAgent.ContactNumber;
            Assert.AreEqual(expectedContactNumber, actualContactNumber);

            double expectedSalary = 38900;
            double actualSalary = billingAgent.Salary;
            Assert.AreEqual(expectedSalary, actualSalary);

            int expectedBillsProcessedPerDay = 10;
            int actualBillsProcessedPerDay = billingAgent.BillsProcessedPerDay;
            Assert.AreEqual(expectedBillsProcessedPerDay,actualBillsProcessedPerDay);

            string expectedBaseWorkLocation = "New York";
            string actualBaseWorkLocation = billingAgent.BaseWorkLocation;
            Assert.AreEqual(expectedBaseWorkLocation, actualBaseWorkLocation);

        }
        [TestMethod]
        public void TestGetEmployeeInfo()
        {
            BillingAgent billingAgent = new BillingAgent(1, "Jhon", "1234567890", 38900, 10, "New York");
            string expectedInfo ="1 Jhon 1234567890 38900 New York 10";
            string actualInfo = billingAgent.GetEmployeeInfo();
            Assert.AreEqual(expectedInfo, actualInfo);
        }

        [TestMethod]
        public void TestCalculateSalaryBaseWorkLocationNewYorkAndLondonBillsProcessedPerDayMoreThan20()
        {
            
            BillingAgent billingAgent = new BillingAgent(1, "Jhon", "1234567890", 38900, 30, "New York");
            
            double expectedSalary = 38900 + 30 * 100;
            double actualSalary = billingAgent.CalculateSalary();
            Assert.AreEqual(expectedSalary,actualSalary);

        }

        [TestMethod]
        public void TestCalculateSalaryBaseWorkLocationNewYorkAndLondonBillsProcessedPerDayMoreThan10EqualToLessThan20()
        {

            BillingAgent billingAgent = new BillingAgent(1, "Jhon", "1234567890", 38900, 15, "New York");
            double expectedSalary = 38900 + 15 * 75;
            double actualSalary = billingAgent.CalculateSalary();
            Assert.AreEqual(expectedSalary, actualSalary);
        }

        [TestMethod]
        public void TestCalculateSalaryBaseWorkLocationNewYorkAndLondonBillsProcessedPerDayEqualToLessThan10()
        {

            BillingAgent billingAgent = new BillingAgent(1, "Jhon", "1234567890", 38900, 5, "New York");
            double expectedSalary = 38900 + 5 * 50;
            double actualSalary = billingAgent.CalculateSalary();
            Assert.AreEqual(expectedSalary, actualSalary);
        }

        [TestMethod]
        public void TestCalculateSalaryBaseWorkLocationNotNewYorkAndLondonBillsProcessedPerDayMoreThan20()
        {

            BillingAgent billingAgent = new BillingAgent(1, "Jhon", "1234567890", 38900, 30, "Sydney");

            double expectedSalary = 38900 + 30 * 80;
            double actualSalary = billingAgent.CalculateSalary();
            Assert.AreEqual(expectedSalary, actualSalary);

        }

        [TestMethod]
        public void TestCalculateSalaryBaseWorkLocationNotNewYorkAndLondonBillsProcessedPerDayMoreThan10EqualToLessThan20()
        {

            BillingAgent billingAgent = new BillingAgent(1, "Jhon", "1234567890", 38900, 15, "Sydney");
            double expectedSalary = 38900 + 15 * 60;
            double actualSalary = billingAgent.CalculateSalary();
            Assert.AreEqual(expectedSalary, actualSalary);
        }

        [TestMethod]
        public void TestCalculateSalaryBaseWorkLocationNotNewYorkAndLondonBillsProcessedPerDayEqualToLessThan10()
        {

            BillingAgent billingAgent = new BillingAgent(1, "Jhon", "1234567890", 38900, 5, "Sydney");
            double expectedSalary = 38900 + 5 * 40;
            double actualSalary = billingAgent.CalculateSalary();
            Assert.AreEqual(expectedSalary, actualSalary);
        }


    }
}
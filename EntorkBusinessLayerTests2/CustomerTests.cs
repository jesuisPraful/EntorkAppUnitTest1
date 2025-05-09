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
    public class CustomerTests
    {
        [TestMethod()]
        public void TestCustomerConstructor()
        {
            Customer customer = new Customer(1,"Daniel","Sydney","1234567890");
            Assert.IsNotNull(customer);

            Assert.AreEqual(1,customer.CustomerId);
            Assert.AreEqual("Daniel",customer.CustomerName);
            Assert.AreEqual("Sydney",customer.Address);
            Assert.AreEqual("1234567890", customer.PhoneNumber);
        }

        [TestMethod()]
        public void TestGetCustomerInfo()
        {
            Customer customer = new Customer(1, "Daniel", "Sydney", "1234567890");
            string expectedInfo = "1 Daniel Sydney 1234567890";
            Assert.AreEqual(expectedInfo,customer.GetCustomerInfo());
        }

        [TestMethod()]
        public void TestAddCustomerReading()
        {
            MeterReader meterReader = new MeterReader(1, "Jhon", "1234567890", 38900, 20);
            MeterReading meterreading = new MeterReading(1, 203, DateTime.Now, meterReader);
            Customer customer = new Customer(1, "Daniel", "Sydney", "1234567890");
            bool check = customer.AddCustomerReading(meterreading);

            Assert.AreEqual(1, customer.Readings[0].MeterReadingId);
            Assert.AreEqual(203, customer.Readings[0].UnitsConsumed);
            Assert.AreEqual(1, customer.Readings[0].Reader.EmployeeId);
            Assert.AreEqual("Jhon", customer.Readings[0].Reader.Name);
            Assert.AreEqual("1234567890", customer.Readings[0].Reader.ContactNumber);
            Assert.AreEqual(38900, customer.Readings[0].Reader.Salary);
            Assert.AreEqual(20, customer.Readings[0].Reader.MetersCheckedPerDay);

            Assert.IsTrue(check);
        }
    }
}
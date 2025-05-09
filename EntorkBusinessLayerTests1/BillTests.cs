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
    public class BillTests
    {
        [TestMethod()]
        public void BillTest()
        {

        }
        //[TestMethod()]
        // public void TestGenerateBillReadingIsNotNullAndrMeterReadingIdEqualreadingMeterReadingIdUnitConsumedEqualToZero()
        // {

        //    Bill bill = new Bill();
        //    MeterReader reader = new MeterReader(1, "Jhon", "1234567890", 38900, 20);
        //    MeterReading meterreading = new MeterReading(1, 0, DateTime.Now, reader);
        //    BillingAgent  billingAgent = new BillingAgent(1, "Jhon", "1234567890", 38900, 10, "New York");
        //    Customer customer = new Customer(1, "Daniel", "Sydney", "1234567890");
        //    string expectedMessage = $"Bill successfully generated for Customer: {customer.CustomerName} with Bill ID: B1001";
        //    //Assert.AreEqual(100, bill.BillAmount);
        //    string actualMessage = bill.GenerateBill(customer, meterreading, billingAgent);
        //    Assert.AreEqual(expectedMessage, actualMessage);
        // }
    }
}
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
    public class MeterReadingTests
    {
        [TestMethod]
        public void TestMeterReadingTestsCustomer()
        {
            MeterReader meterReader = new MeterReader();
            MeterReading meterReading = new MeterReading(1,100.5,DateTime.Now, meterReader);
            Assert.IsNotNull(meterReading);
        }
    }
}
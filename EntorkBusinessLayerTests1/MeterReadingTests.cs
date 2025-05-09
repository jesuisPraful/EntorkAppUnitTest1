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
        [TestMethod()]
        public void TestMeterReadingConstructor()
        {
            MeterReader meterReader = new MeterReader(1, "Jhon", "1234567890", 38900, 20);

            Assert.IsNotNull(meterReader);
            DateTime d = DateTime.Now;
            MeterReading meterreading = new MeterReading(1,203,d,meterReader);

            int expectedMeterReadingId = 1;
            int actualMeterReadingId = meterreading.MeterReadingId;
            Assert.AreEqual(actualMeterReadingId, expectedMeterReadingId);

            double expectedConsumedUnit = 203;
            double actualConsumedUnit = meterreading.UnitsConsumed;
            Assert.AreEqual(actualConsumedUnit, expectedConsumedUnit);


             
            Assert.IsInstanceOfType(d, typeof(DateTime));

            Assert.AreSame(meterReader, meterreading.Reader);
          
        }

        

         
    }
}
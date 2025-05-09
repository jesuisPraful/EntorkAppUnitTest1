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

            MeterReading meterReading = new MeterReading(1, 203, DateTime.Now, meterReader);
            DateTime d = DateTime.Now;

            Assert.IsNotNull(meterReading);

            Assert.AreEqual(1, meterReading.MeterReadingId);
            Assert.AreEqual(203, meterReading.UnitsConsumed);

            Assert.IsInstanceOfType(d, typeof(DateTime));
            Assert.AreSame(meterReader, meterReading.Reader);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntorkBusinessLayer
{
    public class MeterReading
    {
        public int MeterReadingId { get; set; }
        public double UnitsConsumed { get; set; }
        public DateTime ReadingDate { get; set; }
        public MeterReader Reader { get; set; }

        public MeterReading(int meterReadingId, double unitsConsumed, DateTime readingDate, MeterReader reader)
        {
            MeterReadingId = meterReadingId;
            UnitsConsumed = unitsConsumed;
            ReadingDate = readingDate;
            Reader = reader;
        }

        public string GetMeterReadingInfo()     
        {
            return MeterReadingId + " " + UnitsConsumed + " " + ReadingDate;
        }
    }
}

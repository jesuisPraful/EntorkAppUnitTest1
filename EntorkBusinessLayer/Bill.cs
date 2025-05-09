using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntorkBusinessLayer
{
    public class Bill
    {
        public string BillId { get; set; }
        public double BasePrice { get; set; }
        public double PricePerUnit { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public double BillAmount { get; set; }
        public MeterReader Reader { get; set; }
        public BillingAgent Agent { get; set; }

        private static int counter;

        static Bill()
        {
            counter = 1000;
        }

        public Bill()
        {
            SetBaseTariff();
        }

        public string GenerateBill(Customer customer, MeterReading reading, 
            BillingAgent agent)
        {
            string billMessage = "";

            try
            {
                if(customer.Readings != null)
                {
                    foreach (var r in customer.Readings)
                    {
                        if(r.MeterReadingId == reading.MeterReadingId)
                        {
                            Reader = reading.Reader;
                            Agent = agent;
                            BillId = "B" + ++counter;
                            BillDate = DateTime.Now;
                            DueDate = DateTime.Now.AddDays(30);
                            Status = "Pending";

                            if (reading.UnitsConsumed == 0)
                                BillAmount = BasePrice;
                            else if (reading.UnitsConsumed > 0)
                            {
                                BillAmount = BasePrice + (reading.UnitsConsumed + PricePerUnit);
                            }

                            billMessage = "Bill successfully generated for Customer: " + customer.CustomerName + 
                                "with Bill ID: " + BillId;
                            return billMessage;
                        }
                    }
                }

                billMessage = "Bill could not be generated";
            }
            catch (Exception ex)
            {
                billMessage = "Something went wrong, please try again later!";
            }
            return billMessage;
        }

        public void SetBaseTariff()
        {
            BasePrice = 100;
            PricePerUnit = 4;
        }
    }
}

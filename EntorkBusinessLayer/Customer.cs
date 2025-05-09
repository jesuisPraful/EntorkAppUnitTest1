namespace EntorkBusinessLayer
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<MeterReading> Readings { get; set; }

        public Customer(int customerId, string customerName, string address, 
            string phoneNumber)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Address = address;
            PhoneNumber = phoneNumber;
            Readings = new List<MeterReading>();
        }

        public string GetCustomerInfo()
        {
            return CustomerId + " " + CustomerName + " " + Address + " " + PhoneNumber;
        }

        public bool AddCustomerReading(MeterReading reading)
        {
            Readings.Add(reading);
            return true;
        }

    }
}

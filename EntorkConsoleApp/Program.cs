using EntorkBusinessLayer;

namespace EntorkConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Customer One
            
            Console.WriteLine("------------------------------Customer One Bill Generation----------------------------");

            Customer customerOne = new Customer(101, "Lily Elizabeth", "London", "9999999999");

            MeterReader readerOne = new MeterReader(1, "Philip Dunphy", "8888888888", 18000, 6);

            MeterReading readingOne = new MeterReading(1, 145, DateTime.Now, readerOne);

            //Assign reading to customer
            customerOne.AddCustomerReading(readingOne);

            //Display details
            Console.WriteLine("Customer Details: ");
            Console.WriteLine(customerOne.GetCustomerInfo());

            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.WriteLine("Customer Readings: ");
            foreach (var item in customerOne.Readings)
            {
                Console.WriteLine(item.MeterReadingId + " " + item.UnitsConsumed + " " + item.ReadingDate);
                Console.WriteLine(".................................................");
            }

            Console.WriteLine("--------------------------------------------------------------------------------------");

            //Calculate Reader Salary
            readerOne.CalculateSalary();

            Console.WriteLine("Meter Reader Details: ");
            Console.WriteLine(readerOne.GetEmployeeInfo());

            Console.WriteLine("--------------------------------------------------------------------------------------");

            BillingAgent agentOne = new BillingAgent(2, "Margaret Townsend", "7777777777", 22000, 20, "Chicago");

            //Calculate Agent Salary
            agentOne.CalculateSalary();

            Console.WriteLine("Billing Agent Details: ");
            Console.WriteLine(agentOne.GetEmployeeInfo());

            Console.WriteLine("--------------------------------------------------------------------------------------");

            Bill billOne = new Bill();

            Console.WriteLine("Generating Bill...");
            string message = billOne.GenerateBill(customerOne, readingOne, agentOne);
            
            Console.WriteLine(message);

            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.WriteLine("Bill Details");

            Console.WriteLine("Bill Id : " + billOne.BillId);
            Console.WriteLine("Bill Amount : " + billOne.BillAmount);
            Console.WriteLine("Bill Date : " + billOne.BillDate);
            Console.WriteLine("Due Date : " + billOne.DueDate);
            Console.WriteLine("Bill Status : " + billOne.Status);
            Console.WriteLine("Base Price  : " + billOne.BasePrice);
            Console.WriteLine("Price Per Unit : " + billOne.PricePerUnit);
            Console.WriteLine("Meter Reader : " + billOne.Reader.Name);
            Console.WriteLine("Billing Agent : " + billOne.Agent.Name);

            Console.WriteLine("--------------------------------------------------------------------------------------");

            #endregion

            #region Customer Two

            Console.WriteLine("-----------------------Customer Two Bill Generation----------------------");

            Customer customerTwo = new Customer(102, "Alex Pritchett", "New York", "9876789687");

            MeterReading readingTwo = new MeterReading(2, 89, DateTime.Now, readerOne);

            //Assign reading to customer
            customerTwo.AddCustomerReading(readingTwo);

            //Display details
            Console.WriteLine("Customer Details: ");
            Console.WriteLine(customerTwo.GetCustomerInfo());

            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.WriteLine("Customer Readings: ");
            foreach (var item in customerTwo.Readings)
            {
                Console.WriteLine(item.MeterReadingId + " " + item.UnitsConsumed + " " + item.ReadingDate);
                Console.WriteLine(".................................................");
            }

            Console.WriteLine("--------------------------------------------------------------------------------------");

            Bill billTwo = new Bill();

            Console.WriteLine("Generating Bill...");
            message = billTwo.GenerateBill(customerTwo, readingTwo, agentOne);

            Console.WriteLine(message);

            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.WriteLine("Bill Details");

            Console.WriteLine("Bill Id : " + billTwo.BillId);
            Console.WriteLine("Bill Amount : " + billTwo.BillAmount);
            Console.WriteLine("Bill Date : " + billTwo.BillDate);
            Console.WriteLine("Due Date : " + billTwo.DueDate);
            Console.WriteLine("Bill Status : " + billTwo.Status);
            Console.WriteLine("Base Price  : " + billTwo.BasePrice);
            Console.WriteLine("Price Per Unit : " + billTwo.PricePerUnit);
            Console.WriteLine("Meter Reader : " + billTwo.Reader.Name);
            Console.WriteLine("Billing Agent : " + billTwo.Agent.Name);

            Console.WriteLine("--------------------------------------------------------------------------------------");

            #endregion
        }
    }
}

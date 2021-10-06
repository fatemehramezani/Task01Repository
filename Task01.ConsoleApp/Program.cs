using System;
using Task01.Data.Repository;

namespace Task01.ConsoleApp
{
    class Program
    {
        public const string baseURL = @"https://api-dev.channelengine.net/api/v2/orders?apikey=541b989ef78ccb1bad630ea5b85c6ebff9ca3322";
        static void Main(string[] args)
        {
            Console.WriteLine("PLEASE SELECT ONE OPTION: \r\n ============================ \r\n\r1. List of InProgress orders\r\n\r2. List of 5 top products");
            var key = System.Console.ReadKey().Key;

            var dataCollection = new DataCollection(baseURL);

            if (key == ConsoleKey.D1)
            {
                //Task #1: ● Fetch all orders with status IN_PROGRESS from the API                
                var inPrgressOrders = dataCollection.MerchantOrderRepository.GetOrdersByStatus();
                Console.WriteLine($"\n'{inPrgressOrders.Count}' orders are in progress");
            }
            else if (key == ConsoleKey.D2)
            {
                //Task #2: ● From these orders, compile a list of the top 5 products sold(product name, GTIN and total quantity), order these by the total quantity sold in descending order.
                var inPrgressOrders = dataCollection.MerchantOrderRepository.GetOrdersByStatus();

            }
            else if (key == ConsoleKey.D3)
            {

                //Task #3: ● Pick one of the products from these orders and use the API to set the stock of this product to 25.
            }
            else
            {

            }

            Console.ReadKey();
        }
    }
}

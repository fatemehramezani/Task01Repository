using System;
using System.Linq;
using Task01.Data.Repository;

namespace Task01.ConsoleApp
{
    class Program
    {
        public const string baseURL = @"https://api-dev.channelengine.net/api/v2/{0}?apikey=541b989ef78ccb1bad630ea5b85c6ebff9ca3322";
        static void Main(string[] args)
        {
            Console.WriteLine("This app will:\n1. List of InProgress orders\r\n\r2. List of 5 top products\r\n\r3. Change Stock of a random product\r\n\r============================ \r\n");
            var key = System.Console.ReadKey().Key;

            var dataCollection = new DataCollection(baseURL);
            //Task #1: ● Fetch all orders with status IN_PROGRESS from the API                
            var inPrgressOrders = dataCollection.MerchantOrderRepository.GetOrdersByStatus();
            Console.WriteLine($"\n'{inPrgressOrders.Count}' orders are in progress");

            //Task #2: ● From these orders, compile a list of the top 5 products sold(product name, GTIN and total quantity), order these by the total quantity sold in descending order.
            var soldProducts = dataCollection.MerchantProductRepository.GetProducts(top: 5);
            var customProducts = soldProducts.Select(c => new { c.Name, c.Ean, c.Price }).OrderByDescending(c=>c.Price);
            Console.WriteLine($"\n'{soldProducts.Count}' product are selected and top based on price is '{customProducts.First().Name}'");

            //Task #3: ● Pick one of the products from these orders and use the API to set the stock of this product to 25.
            
            var topProduct = soldProducts.FirstOrDefault();
            dataCollection.MerchantProductRepository.UpdateProductName(topProduct.MerchantProductNo, $"UPDATED-{topProduct.Name}");
            Console.WriteLine($"\n'{topProduct.MerchantProductNo}' is update");
            Console.ReadKey();
        }
    }
}

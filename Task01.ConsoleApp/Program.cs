using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Task01.ConsoleApp
{
    class Program
    {
        public const string baseURL = @"https://api-dev.channelengine.net/api/v2/orders?apikey=541b989ef78ccb1bad630ea5b85c6ebff9ca3322";
        static void Main(string[] args)
        {
            Console.WriteLine("PLEASE SELECT ONE OPTION: \r\n 1. List of InProgress orders");
            var key = System.Console.ReadKey().Key;

            //Task #1
            if (key == ConsoleKey.D1)
            {
                var request = new ApiConnection.Requests(baseURL);
                request.GetOrders();
            }
        }
    }
}

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace StockBuySell
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Section 1 reading csv file-----------------------------------------------------------

            /* 
             List<string> readFile = new List<string>();
             using (var reader = new StreamReader(@"dataset.csv"))
             {
                 while (!reader.EndOfStream)
                 {
                     var line = reader.ReadLine();
                     var values = line.Split(';');
                     readFile.Add(values[0]);

                 }

             }

             List<double> openingBalancesList = new List<double>();
             double temp;
             openingBalancesList = readFile.Select(x => double.TryParse(x, out temp) ? temp : 0).ToList();
             */

            // Section 1-----------------------------------------------------------

            //Section 2 (we can use the following dataset if we not uploading the csv file)-------------------------------------
            
            double[] openingBalancesList = { 19.55, 19.15, 16.15, 18.35, 17.38, 18.39, 18.88, 17.87, 17.77, 17.37, 18.39, 18.88, 17.87, 19.15, 16.15, 18.39, 17.39, 18.39, 17.87, 17.77, 17.39, 18.37, 18.88, 19.15, 16.15, 18.35, 16.13, 19.15, 16.15, 18.39 };
            
            //Section 2-----------------------------------------------------------


            //minimum stock and day value
            double minStockValue = openingBalancesList.Min();
            int minStockValueDay = openingBalancesList.ToList().IndexOf(minStockValue) + 1;

            //maximum stock and day value
            double maxStockValue = openingBalancesList.Max();
            int maxStockValueDay = openingBalancesList.ToList().IndexOf(maxStockValue) + 1;

            //output display on console
            Console.WriteLine($"\n{minStockValueDay}({minStockValue}), {maxStockValueDay}({maxStockValue})");
            

            
        }
    }
}

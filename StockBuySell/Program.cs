using System;
using System.Linq;

namespace StockBuySell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Highest Opening Balance and Lower Opening Balance from provided list");
            double[] openingBalancesList = { 19.15, 18.30, 18.88, 17.93, 15.95, 19.03, 19.00, 20.00, 16.75, 25.19, 13.49 };
            
            for (int i=0; i < openingBalancesList.Length; i++)
            {
                Console.Write(openingBalancesList[i]+ ", ");
            }

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

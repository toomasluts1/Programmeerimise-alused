using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne_2
{
    class Tab
    {
        private decimal sum;

        public Tab()
        {
            Console.WriteLine("--------------------------------------------------");
        }

        public void Add(double price)
        {
            sum = sum + (decimal)price;
            Console.WriteLine($"Price of food item: {price}");
        }

        public decimal Getsum()
        {
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne_2
{
    class Receipt
    {
        private decimal subtotal;
        private decimal gratuity;
        private decimal total;

        public Receipt(decimal sub)
        {
            Console.WriteLine("--------------------------------------------------");
            subtotal = sub;
            gratuity = (decimal)0.15 * sub;
            total = (decimal)0.85 * sub;
        }

        public override string ToString()
        {
            string print = $"Subtotal: £{Math.Round(subtotal, 2)}\n" +
                $"15.00 % Gratuity: £{Math.Round(gratuity, 2)}\n" +
                $"Total: £{Math.Round(total,2)}\n";

            return print;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne_2
{
    class Restaurant
    {
        private string name;
        private string address;

        public Restaurant(string n, string a)
        {
            name = n;
            address = a;
            Console.WriteLine(n);
            Console.WriteLine(a);
        }

        public Receipt GetReceipt(Tab tab)
        {
            return new Receipt(tab.Getsum());
        }
    }
}

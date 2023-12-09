using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFoodDelivery
{
    internal class Customer
    {
        public string name;
        public string address;
        public List<Point> points = new List<Point>();

        public Customer(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

    }
}

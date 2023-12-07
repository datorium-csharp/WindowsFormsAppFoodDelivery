using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFoodDelivery
{
    internal class Food
    {
        public string name;
        public string description;
        public string type;
        public double price;

        public Food(string name, string description, string type, double price)
        {
            this.name = name;
            this.description = description;
            this.type = type;
            this.price = price;
        }
    }
}

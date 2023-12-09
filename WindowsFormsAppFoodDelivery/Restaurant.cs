using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFoodDelivery
{
    internal class Restaurant
    {
        public string name;
        public string address;
        public List<Food> menu = new List<Food>();

        public Restaurant(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public override string ToString() 
        { 
            return $"{this.name}; {this.address}";   
        }

        public void AddMenuItem(Food food)
        {
            menu.Add(food);
        }
    }
}

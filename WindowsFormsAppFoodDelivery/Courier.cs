using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFoodDelivery
{
    internal class Courier
    {
        public string id;
        public string type;

        public Courier(string id, string type)
        {
            this.id = id;
            this.type = type;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFoodDelivery
{
    internal class Point
    {
        public string type;
        public int value;

        public Point(string type)
        {
            this.type = type;
            this.value = 0;
        }

    }
}

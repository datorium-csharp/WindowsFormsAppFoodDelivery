using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFoodDelivery
{
    public partial class Form1 : Form
    {
        List<Restaurant> restaurants = new List<Restaurant>();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddRestaurant_Click(object sender, EventArgs e)
        {
            //back-end coding
            var restaurant = new Restaurant(
                    textBoxRestaurantName.Text, 
                    textBoxRestaurantAddress.Text
                );

                restaurants.Add(restaurant);

            //front-end coding
            listBoxRestaurants.Items.Add(restaurant);
        }
    }
}

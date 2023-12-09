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

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            //back-end coding
            if (
                    String.IsNullOrEmpty(textBoxFoodName.Text) ||
                    String.IsNullOrEmpty(textBoxFoodDescription.Text) ||
                    String.IsNullOrEmpty(textBoxFoodType.Text) ||
                    String.IsNullOrEmpty(textBoxFoodPrice.Text)
                )
            {
                return;
            }
            
            var food = new Food(
                    textBoxFoodName.Text,
                    textBoxFoodDescription.Text,
                    textBoxFoodType.Text,
                    Convert.ToDouble(textBoxFoodPrice.Text)
                );

            if (listBoxRestaurants.SelectedIndex != -1)
            {
                var selectedIndex = listBoxRestaurants.SelectedIndex;
                restaurants[selectedIndex].AddMenuItem(food);
            }

        }
    }
}

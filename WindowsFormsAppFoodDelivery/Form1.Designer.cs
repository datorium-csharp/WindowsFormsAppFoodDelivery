namespace WindowsFormsAppFoodDelivery
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxRestaurants = new System.Windows.Forms.ListBox();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.buttonAddRestaurant = new System.Windows.Forms.Button();
            this.textBoxRestaurantName = new System.Windows.Forms.TextBox();
            this.textBoxRestaurantAddress = new System.Windows.Forms.TextBox();
            this.textBoxFoodName = new System.Windows.Forms.TextBox();
            this.textBoxFoodDescription = new System.Windows.Forms.TextBox();
            this.textBoxFoodType = new System.Windows.Forms.TextBox();
            this.textBoxFoodPrice = new System.Windows.Forms.TextBox();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRestaurants
            // 
            this.listBoxRestaurants.FormattingEnabled = true;
            this.listBoxRestaurants.Location = new System.Drawing.Point(25, 31);
            this.listBoxRestaurants.Name = "listBoxRestaurants";
            this.listBoxRestaurants.Size = new System.Drawing.Size(200, 173);
            this.listBoxRestaurants.TabIndex = 0;
            this.listBoxRestaurants.SelectedIndexChanged += new System.EventHandler(this.listBoxRestaurants_SelectedIndexChanged);
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(275, 31);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(200, 173);
            this.listBoxMenu.TabIndex = 1;
            // 
            // buttonAddRestaurant
            // 
            this.buttonAddRestaurant.Location = new System.Drawing.Point(25, 306);
            this.buttonAddRestaurant.Name = "buttonAddRestaurant";
            this.buttonAddRestaurant.Size = new System.Drawing.Size(200, 47);
            this.buttonAddRestaurant.TabIndex = 2;
            this.buttonAddRestaurant.Text = "Add Restaurant";
            this.buttonAddRestaurant.UseVisualStyleBackColor = true;
            this.buttonAddRestaurant.Click += new System.EventHandler(this.buttonAddRestaurant_Click);
            // 
            // textBoxRestaurantName
            // 
            this.textBoxRestaurantName.Location = new System.Drawing.Point(25, 244);
            this.textBoxRestaurantName.Name = "textBoxRestaurantName";
            this.textBoxRestaurantName.Size = new System.Drawing.Size(200, 20);
            this.textBoxRestaurantName.TabIndex = 3;
            // 
            // textBoxRestaurantAddress
            // 
            this.textBoxRestaurantAddress.Location = new System.Drawing.Point(25, 270);
            this.textBoxRestaurantAddress.Name = "textBoxRestaurantAddress";
            this.textBoxRestaurantAddress.Size = new System.Drawing.Size(200, 20);
            this.textBoxRestaurantAddress.TabIndex = 4;
            // 
            // textBoxFoodName
            // 
            this.textBoxFoodName.Location = new System.Drawing.Point(275, 244);
            this.textBoxFoodName.Name = "textBoxFoodName";
            this.textBoxFoodName.Size = new System.Drawing.Size(200, 20);
            this.textBoxFoodName.TabIndex = 5;
            // 
            // textBoxFoodDescription
            // 
            this.textBoxFoodDescription.Location = new System.Drawing.Point(275, 270);
            this.textBoxFoodDescription.Name = "textBoxFoodDescription";
            this.textBoxFoodDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxFoodDescription.TabIndex = 6;
            // 
            // textBoxFoodType
            // 
            this.textBoxFoodType.Location = new System.Drawing.Point(275, 296);
            this.textBoxFoodType.Name = "textBoxFoodType";
            this.textBoxFoodType.Size = new System.Drawing.Size(200, 20);
            this.textBoxFoodType.TabIndex = 7;
            // 
            // textBoxFoodPrice
            // 
            this.textBoxFoodPrice.Location = new System.Drawing.Point(275, 322);
            this.textBoxFoodPrice.Name = "textBoxFoodPrice";
            this.textBoxFoodPrice.Size = new System.Drawing.Size(200, 20);
            this.textBoxFoodPrice.TabIndex = 8;
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Location = new System.Drawing.Point(275, 360);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(200, 47);
            this.buttonAddFood.TabIndex = 9;
            this.buttonAddFood.Text = "Add Food";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            this.buttonAddFood.Click += new System.EventHandler(this.buttonAddFood_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 447);
            this.Controls.Add(this.buttonAddFood);
            this.Controls.Add(this.textBoxFoodPrice);
            this.Controls.Add(this.textBoxFoodType);
            this.Controls.Add(this.textBoxFoodDescription);
            this.Controls.Add(this.textBoxFoodName);
            this.Controls.Add(this.textBoxRestaurantAddress);
            this.Controls.Add(this.textBoxRestaurantName);
            this.Controls.Add(this.buttonAddRestaurant);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.listBoxRestaurants);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRestaurants;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Button buttonAddRestaurant;
        private System.Windows.Forms.TextBox textBoxRestaurantName;
        private System.Windows.Forms.TextBox textBoxRestaurantAddress;
        private System.Windows.Forms.TextBox textBoxFoodName;
        private System.Windows.Forms.TextBox textBoxFoodDescription;
        private System.Windows.Forms.TextBox textBoxFoodType;
        private System.Windows.Forms.TextBox textBoxFoodPrice;
        private System.Windows.Forms.Button buttonAddFood;
    }
}


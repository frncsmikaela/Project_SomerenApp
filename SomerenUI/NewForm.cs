using SomerenLogic;
using SomerenModel;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;

namespace SomerenUI
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtDrinkName.Text == "" && txtDrinkNum.Text == "" && txtSold.Text == "" && txtDrinkType.Text == "" && txtPrice.Text == "" && txtStock.Text == "")
            {
                MessageBox.Show("Some fields are empty, please fill fields that are empty");
            }
            else
            {
                Drink drink = new Drink();
                //get the drink from the user, and store it in Drink fields 
                drink.DrinkName = txtDrinkName.Text;
                drink.DrinkNumber = int.Parse(txtDrinkNum.Text);
                drink.DrinksSold = int.Parse(txtSold.Text);
                drink.DrinkType = txtDrinkType.Text;
                drink.Price = decimal.Parse(txtPrice.Text);
                drink.StockAmount = int.Parse(txtStock.Text);
                Drink_Service drinkService = new Drink_Service();
                drinkService.InsertNewDrink(drink);
                //hide the form after clicking the submit button 
                this.Close();
            }


        }
    }
}

using SomerenLogic;
using SomerenModel;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;

namespace SomerenUI
{
    public partial class EditDrinkForm : Form
    {
        private Drink drink;
        public EditDrinkForm(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
            EditDrink(drink);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        public void EditDrink(Drink drink)
        {
            this.drink = drink;
            txtEditName.Text = drink.DrinkName;
            txtEditNumber.Text = drink.DrinkNumber.ToString();
            txtEditPrice.Text = drink.Price.ToString();
            txtEditSold.Text = drink.DrinksSold.ToString();
            txtEditStock.Text = drink.StockAmount.ToString();
            txtEditType.Text = drink.DrinkType;   
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //get the field that the user wants to edit 
            drink.DrinkName = txtEditName.Text;
            drink.DrinksSold = int.Parse(txtEditSold.Text);
            drink.DrinkType = txtEditType.Text;
            drink.Price = decimal.Parse(txtEditPrice.Text);
            drink.StockAmount = int.Parse(txtEditStock.Text);
            Drink_Service drinkService = new Drink_Service();
            drinkService.UpdateDrink(drink);
            //hide the form
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Drink_Service drinkService = new Drink_Service();
            drinkService.DeleteADrink(drink);
            //hide the form 
            this.Close();
        }
    }
}

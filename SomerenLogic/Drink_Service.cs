using System;
using System.Collections.Generic;
using SomerenDAL;
using SomerenModel;
using System.Windows.Forms;

namespace SomerenLogic
{
    public class Drink_Service
    {
        Drink_DAO drink_db = new Drink_DAO();
        public List<Drink> GetDrinks()
        {
            try
            {
                List<Drink> drinks = drink_db.Db_Get_All_Drinks();
                return drinks;
            }
            catch (Exception)
            {
                // add list of fake drinks
                List<Drink> drinks = new List<Drink>();
                Drink a = new Drink(12, 6M, "A", 3, "Drink 1", 5);
                drinks.Add(a);

                Drink b = new Drink(13, 8M, "N", 12, "Drink 2", 10);
                drinks.Add(b);

                MessageBox.Show("Someren couldn't connect to the database");
                return drinks;
            }
        }



        //this is part of variant A from assignment 3
        //this is part of variant A from assignment 3
        //for inserting new drink
        public void InsertNewDrink(Drink drink)
        {
            drink_db.Db_Insert_Drink(drink);
        }
        //for editing a drink
        public void UpdateDrink(Drink drink)
        {
            drink_db.Db_Update_Drink(drink);
        }
        //for deleting a drink
        public void DeleteADrink(Drink drink)
        {
            drink_db.Db_Delete_Drink(drink);
        }



        //this is a part of variant B from assignment 3
        //this is a part of variant B from assignment 3
        //update stock of drink
        public void SaleDrink(Drink drink)
        {
            drink_db.DB_Sale_Drink(drink);
        }
    }
}

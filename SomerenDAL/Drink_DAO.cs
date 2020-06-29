using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class Drink_DAO : Base
    {
        public List<Drink> Db_Get_All_Drinks()
        {
            string query = "SELECT drinkNumber, price , drinkType,stockAmount,drinkName,drinksSold FROM DRINK WHERE stockAmount > 1 AND price > 1 AND drinkName NOT IN ('Water', 'Orangeade', 'Cherry Juice') ORDER BY stockAmount, price, drinksSold";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        //this is part of variant A from assignment 3
        //this is part of variant A from assignment 3
        public void Db_Insert_Drink(Drink drink)
        {
            string query = String.Format("INSERT INTO DRINK VALUES({0}, {1}, '{2}', {3}, '{4}', {5})", drink.DrinkNumber, drink.Price, drink.DrinkType, drink.StockAmount, drink.DrinkName, drink.DrinksSold);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Db_Update_Drink(Drink drink)
        { 
            string query = String.Format("UPDATE DRINK SET price = {0}, drinkType = '{1}', stockAmount = {2}, drinkName = '{3}', drinksSold = {4} WHERE drinkNumber = {5}",
                drink.Price,drink.DrinkType,drink.StockAmount,drink.DrinkName,drink.DrinksSold, drink.DrinkNumber);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Db_Delete_Drink(Drink drink)
        {
            string query = String.Format("DELETE FROM DRINK WHERE drinkNumber = {0}",drink.DrinkNumber);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        //this is part of variant B from assignment 3
        //this is part of variant B from assignment 3
        public void DB_Sale_Drink(Drink drink)
        {
            string query = String.Format("UPDATE DRINK SET stockAmount = stockAmount - 1, drinksSold = drinksSold + 1 WHERE drinkNumber = {0}",
                drink.DrinkNumber);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink((int)dr["drinkNumber"], (decimal)dr["price"], dr["drinkType"].ToString(), (int)dr["stockAmount"], dr["drinkName"].ToString(), (int)dr["drinksSold"]);
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}

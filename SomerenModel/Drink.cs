using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int DrinkNumber { get; set; }
        public decimal Price { get; set; }
        public String DrinkType { get; set; }
        public int StockAmount { get; set; }
        public String DrinkName { get; set; }
        public int DrinksSold { get; set; }

        //constructor
        public Drink()
        {
        }
        public Drink(int drinkNumber, decimal price, String drinkType, int stockAmount, String drinkName, int drinksSold)
        {
            DrinkNumber = drinkNumber;
            Price = price;
            DrinkType = drinkType;
            StockAmount = stockAmount;
            DrinkName = drinkName;
            DrinksSold = drinksSold;
        }
    }
}

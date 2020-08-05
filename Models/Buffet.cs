using System;
using System.Collections.Generic;


namespace HungryNinja.Models
{
    public class Buffet
    {
        public List<IConsumable> Menu;
    
    
    //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("SpicyRamen", 800, true, false),
                new Food("KimChiFries", 400, true, false),
                new Food("NinjaProtienBar", 100, false, true),
                new Food("SpicyFriedRice", 600, false, true),
                new Food("StirFriedVegetables", 500, false, false),
                new Food("SideOfGinger", 50, true, false),
                new Food("NinjaSandwhich", 400, false, false),
                new Drink("NinjaSmoothie", 150, false),
                new Drink("GingerBrew", 50, true),
                new Drink("CocaCola", 80, false),
                new Drink("PowerAid", 75, false),
                new Drink("Fanta", 80, false),
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            int RandNum = rand.Next(Menu.Count);
            var RandFood = Menu[RandNum];
            Console.WriteLine(RandFood.Name);
            return RandFood;
        }
    }
}
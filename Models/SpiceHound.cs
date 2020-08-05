using System;
using System.Collections.Generic; 


namespace HungryNinja.Models
{
    class SpiceHound : Ninja
    {
        public override bool IsFull {
            get
            {
                return (calorieIntake > 1200);
            }
        }
        public SpiceHound(string name) : base(name)
            {
                name = Name;
            }
        public override void Consume(IConsumable item)
        {
            if (IsFull == false)
            {
                if (item.IsSpicy == true){
                    calorieIntake -= 5;
                }
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
                Console.WriteLine($"You have consumed {calorieIntake} so far");
                Console.WriteLine("---------------------------");
            }
            else
            {
                Console.WriteLine("You are becomming too fat, Ninja. You cannot consume more.");
            }
        }
    }
}



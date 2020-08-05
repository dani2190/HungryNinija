using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    class SweetTooth : Ninja
    {

        public override bool IsFull {
            get
            {
                return (calorieIntake > 1500);
            }
        }
        public override void Consume(IConsumable item)
        {
            if (IsFull == false)
            {
                if (item.IsSweet == true){
                    calorieIntake += 10;
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
        public SweetTooth(string name) : base(name)
        {
            name = Name;
        }
    }
}
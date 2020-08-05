using System;
using System.Collections.Generic;
using HungryNinja.Models;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of the Ninja Buffet!");
            Buffet NinjaBuffet = new Buffet();
            IConsumable item = NinjaBuffet.Serve();
            IConsumable item1 = NinjaBuffet.Serve();
            IConsumable item2 = NinjaBuffet.Serve();
            SweetTooth naruto = new SweetTooth("Naruto");
            naruto.Consume(item);
            naruto.Consume(item);
            naruto.Consume(item);
            naruto.Consume(item);
            naruto.Consume(item);
            naruto.Consume(item);
            naruto.Consume(item1);
            naruto.Consume(item1);
            naruto.Consume(item1);
            naruto.Consume(item1);
            naruto.Consume(item1);
            naruto.Consume(item1);
            naruto.Consume(item2);
            naruto.Consume(item2);
            SpiceHound noriko = new SpiceHound("Noriko");
            Console.WriteLine(" ");
            noriko.Consume(item);
            noriko.Consume(item);
            noriko.Consume(item);
            noriko.Consume(item1);
            noriko.Consume(item1);
            noriko.Consume(item1);
            noriko.Consume(item1);
            noriko.Consume(item2);
            noriko.Consume(item2);
            noriko.Consume(item2);
            noriko.Consume(item2);
            

        }
    }
}
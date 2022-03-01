using PA2.Interfaces;
using System;
namespace PA2
{
    public class Character
    {
        public string name {get;set;}
        public int maxPower{get;set;}
        public double hp{get;set;}
        public double atkStr{get;set;}
        public double defPwr{get;set;}
        public IAtk attackBehavior;
        public IDef defenseBehavior;

        public Character()
        {
            var r = new Random();
            maxPower = r.Next(1,100);

            hp = 100;

            atkStr = r.Next(1, maxPower);
            defPwr = r.Next(1, maxPower);
        }
        public void SetAttackBehavior (IAtk x)
        {
            attackBehavior = x;
        }
        public void SetDefenseBehavior (IDef x) 
        {
            defenseBehavior = x;
        }
        public void Stats()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("_____________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Name: " + name +" | " + "Health Points: " + hp + " | " + "Attack Power: " + atkStr + " | " + "Defense Power: " + defPwr);
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void DefStats()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("_________________________________________");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Name: " + name +" | "+"Defense Power: " + defPwr + "\t|");
            Console.WriteLine("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void DamageDealt(double attackPower) //whole game logic 
        {
            //Console.WriteLine("test: " + power);
            attackPower = attackPower - defPwr;
            if (attackPower > 0) 
            {
            hp -= attackPower;
            Console.WriteLine($"{attackPower} damage done to {this.name}!");
            }
            else //if defpwr is more than atkStr no damage is done to the character
            {
            Console.WriteLine($"{this.name} defended the attack!");
            }
            Console.WriteLine();
            Console.WriteLine("Press Any key to continue");
            Console.ReadKey();
            Console.Clear();
        }


        


    }
}
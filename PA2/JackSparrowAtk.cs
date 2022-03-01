using PA2.Interfaces;
using System;
namespace PA2
{
    public class JackSparrowAtk: IAtk
    {
        public void Atk(Character primary, Character secondary)
        {
            Console.WriteLine(primary.name + " used a distraction!");
            //Console.WriteLine(primary.atkStr); //test
            double attackPower;
            if(secondary.name=="Will Turner")
            {
                Console.WriteLine("The attack is 20% more effective!");
                attackPower = primary.atkStr * 1.2;
               // Console.WriteLine(attackPower); //test

            }
            else
            {
                attackPower = primary.atkStr;
            }

            
            secondary.DamageDealt(attackPower);
            
        }
    }
}   
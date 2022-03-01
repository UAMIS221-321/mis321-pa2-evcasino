using PA2.Interfaces;
using System;
namespace PA2
{
    public class DavyJonesAtk: IAtk
    {
        public void Atk(Character primary, Character secondary)
        {
            Console.WriteLine(primary.name + " hit you with cannon fire!");
            double attackPower;
            if(secondary.name=="Jack Sparrow")
            {
                Console.WriteLine("The attack is 20% more effective!");
                attackPower = primary.atkStr * 1.2;

            }
            else
            {
                attackPower = primary.atkStr;
            }

    
            secondary.DamageDealt(attackPower);
        }
    }
}
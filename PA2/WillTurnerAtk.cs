using PA2.Interfaces;
using System;
namespace PA2
{
    public class WillTurnerAtk: IAtk
    {
        public void Atk(Character primary, Character secondary)
        {
            Console.WriteLine(primary.name + " slashed you with his sword!");
            double attackPower;
            if(secondary.name=="Davy Jones")
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
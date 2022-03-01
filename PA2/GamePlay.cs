using System;
using System.Collections.Generic;
using System.IO;

namespace PA2
{
    public class GamePlay
    {
        public static void Play()
        {
            
            Character primary = new Character();
            Character secondary = new Character();
            
            string primaryInput = "";
            string secondaryInput = "";
            string primaryName ="";  //
            string secondaryName ="";



            while(primaryInput != "4")
            {
            Console.WriteLine("Player 1, what is your name?");
            primaryName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("1st Player, Choose your character!");
            Console.WriteLine("1:\tJack Sparrow");
            Console.WriteLine("2:\tWill Turner");
            Console.WriteLine("3:\tDavy Jones");
            Console.WriteLine();
            Console.WriteLine("4:\tExit Program ");

            Console.Write("Enter number: ");
            primaryInput = Console.ReadLine();

            switch (primaryInput)
                {
                    case "1":
                        primary = CharacterChoice.JackSparrow(); 
                        primaryInput = "4";
                        break;
                    case "2":
                        primary = CharacterChoice.WillTurner(); 
                        primaryInput = "4";
                        break;
                    case "3":
                        primary = CharacterChoice.DavyJones(); 
                        primaryInput = "4";
                        break;
                    case "4":
                        Console.WriteLine("You have exited the program");
                        primaryInput = "4";
                        break;
                    default:
                        Console.WriteLine("Please Enter a valid option: ");
                        break;
                }
            }

            while(secondaryInput != "4")
            {
            Console.Clear();
            Console.WriteLine("Player 2, what is your name?");
            secondaryName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("2nd Player, Choose your character!");
            Console.WriteLine("1:\tJack Sparrow");
            Console.WriteLine("2:\tWill Turner");
            Console.WriteLine("3:\tDavy Jones");
            Console.WriteLine();
            Console.WriteLine("4:\tExit Program ");

            Console.Write("Enter number: ");
            secondaryInput = Console.ReadLine();

            switch (secondaryInput)
                {
                    case "1":
                        secondary = CharacterChoice.JackSparrow(); 
                        secondaryInput = "4";
                        break;
                    case "2":
                        secondary = CharacterChoice.WillTurner(); 
                        secondaryInput = "4";
                        break;
                    case "3":
                       secondary = CharacterChoice.DavyJones(); 
                       secondaryInput = "4";
                        break;
                    case "4":
                        Console.WriteLine("You have exited the program");
                        secondaryInput = "4";
                        break;
                    default:
                        Console.WriteLine("Please Enter a valid option: ");
                        break;
                }
            }
            
            Game(primary,secondary,primaryName,secondaryName);
            
        }
        public static void Game(Character primary, Character secondary, string playerOne, string playerTwo)
        {
            Console.Clear();
            var r = new Random();
            int num = r.Next(0,2);

            if(num== 0)
            {
                Console.WriteLine($"{playerOne}--First Player: {primary.name} moves first!"); //
            }
            else
            {
                Console.WriteLine($"{playerTwo}--Second Player: {secondary.name} moves first!");
            }
            

            while (primary.hp > 0 && secondary.hp > 0) //fix
            {
                
                if(num == 0)
                {
                    primary.Stats();
                    secondary.DefStats();
                    primary.attackBehavior.Atk(primary, secondary);
                    
                    secondary.Stats();
                    primary.DefStats();
                    secondary.attackBehavior.Atk(secondary, primary);
                } 
                else
                {
                    secondary.Stats();
                    primary.DefStats();
                    secondary.attackBehavior.Atk(secondary, primary);
                    
                    primary.Stats();
                    secondary.DefStats();
                    primary.attackBehavior.Atk(primary, secondary);
                    
                }
                primary.atkStr = r.Next(1, primary.maxPower); 
                primary.defPwr = r.Next(1, primary.maxPower);
                secondary.atkStr = r.Next(1, primary.maxPower);
                secondary.defPwr = r.Next(1, primary.maxPower);
            }

            

            if(primary.hp > 0)
            {
                Console.WriteLine($"{playerOne} won using {primary.name}!");
            }
            else
            {
                Console.WriteLine($"{playerTwo} won using {secondary.name}!");
            }

        }
    }
}
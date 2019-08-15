using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    class Human : Player
    {
        

        public Human(string Name) : base(Name)
        {

        }
      
        public override string GenerateRoshambo()
        {
            Console.WriteLine("Please select from the following: ");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");


            string input = Console.ReadLine().Trim().ToUpper();

            if (input == "1" || input=="ROCK")
            {
                return Roshambo.ROCK.ToString().ToUpper();
            }
            else if (input == "2")
            {
                return Roshambo.PAPER.ToString().ToUpper();
            }
            else if (input == "3")
            {
                return Roshambo.SCISSORS.ToString().ToUpper();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong!! try again!");
                return GenerateRoshambo();
            }
        }
    }
}
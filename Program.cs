using System;
using System.Collections.Generic;

namespace RPS
{
    class Program
    {

      //  List<string> player = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            string name = GetPlayerName();
            int userScore = 0;
            int pcScore = 0;
            bool repeat = true;
            while (repeat)
            {
                string pc = GetOpponentChoise();
                string user = PlayerChoice(name);
                Console.WriteLine("\n" + name + ":" + user);
                Console.WriteLine("PC:" + pc);
                string winner = GetWinner(user, pc);

                if (winner == "User")
                {
                    Console.WriteLine("\n" + name + " Wins!!");
                    userScore += 1;
                }
                else if(winner=="draw")
                {
                    Console.WriteLine("Draw");
                }
                else
                {
                    Console.WriteLine("\n PC Wins!!");
                    pcScore += 1;
                }
                Console.WriteLine("\nScores");
                Console.WriteLine("PC: {0}", pcScore);
                Console.WriteLine("User: {0}", userScore);
                Console.WriteLine("Again?  y/n");
                string again = Console.ReadLine().Trim().ToUpper();
                while (again!="Y" && again !="N")
                {
                    Console.WriteLine("Invalid entry, try y or n");
                    again = Console.ReadLine();
                }
                if (again=="N")
                {
                    repeat = false;
                }
            } 
       }
        //---------------------------------------------------------------------------------------------------
        static public string GetPlayerName()
        {
            Console.WriteLine("What is your name");
            string Name = Console.ReadLine();
            return Name;
        }
        //---------------------------------------------------------------------------------------------------
         static public int GetPlayer()
        {

            //TODO:  make smaller 
            List<string> player = new List<string>();

            player.Add("Rocky Balboa");
            player.Add("Dwayne Johnson");
            
            Console.WriteLine("Would You like to play against?");

            int i = 1;
            int against = 0;
            foreach (var p in player)
            {
                Console.WriteLine(i+"."+p);
                i++;
            }
            string a = Console.ReadLine().Trim();
            try
            {
                 against = int.Parse(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return against;
        }
        //---------------------------------------------------------------------------------------------------
        static public string PlayerChoice(string User)
        {
            Human human = new Human(User);
            string user = human.GenerateRoshambo().ToUpper().Trim();
            return user;
        }
        // ---------------------------------------------------------------------------------------------------

         static public string GetOpponentChoise()
        {
            int against = GetPlayer();
            string pc = "";
            if (against == 1)
            {
                Rocky rocky = new Rocky("Rocky");

                 pc = rocky.GenerateRoshambo().ToUpper().Trim();
                return pc;
            }

            if (against == 2)
            {
                RandomPlayer h = new RandomPlayer("Dwayne Johnson");
                 pc = h.GenerateRoshambo().Trim().ToUpper();
                return pc;
            }
            else
            {
                return GetOpponentChoise();
            }
        }
        static public string GetWinner(string pc, string user)
        {
           
            if (pc == "ROCK" && user == "PAPER")
            {
                return "User";
            }
            if (pc == "ROCK" && user == "SCISSORS")
            {
                return "PC";
            }
            if (pc == "PAPER" && user == "SCISSORS")
            {
                return "User";
            }
             if (pc == "PAPER" && user == "ROCK")
            {
                return "PC";
            }
             if (pc == "SCISSORS" && user == "ROCK")
            {
                return "User";
            }
            if (pc == "SCISSORS" && user == "PAPER")
            {
                return "PC";
            }
            else  
            {
                return "DRAW";
            }
        }
    }
}


        
  
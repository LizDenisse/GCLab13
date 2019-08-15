using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    class RandomPlayer : Player
    {
        Random Rando = new Random();

        public RandomPlayer(string Name) : base(Name)
        {
        }
        public RandomPlayer(string Name, Random Rando) : base(Name)
        {
            this.Rando = Rando;
        }
        public override string GenerateRoshambo()
        {

            int pick = Rando.Next(1, 4);

            if (pick == 1)
            {
                return Roshambo.ROCK.ToString().ToUpper();
            }
            else if (pick == 2)
            {
                return Roshambo.PAPER.ToString().ToUpper();
            }
            else if (pick == 3)
            {
                return Roshambo.SCISSORS.ToString().ToUpper();
            }
            else
            {
                return "-1";
            }

        }
    }
}
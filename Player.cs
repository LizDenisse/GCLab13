using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    abstract class Player
    {
        public string Name { get; set; }

        public Player(string Name)
        {
            this.Name = Name;
        }
        public virtual string GenerateRoshambo()
        {
            return Roshambo.ROCK.ToString().ToUpper(); 
        }

    }
}


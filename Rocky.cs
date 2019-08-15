using System;
using System.Collections.Generic;
using System.Text;

namespace RPS
{
    class Rocky : Player
    {

        public Rocky(string Name) : base(Name)
        {

        }
        public override string GenerateRoshambo()
        {
            return Roshambo.ROCK.ToString().ToUpper();
        }
    }
}
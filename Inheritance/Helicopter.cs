using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_MatthewVargas
{
    internal class Helicopter(string color, int numofmovers) : Air(color)
    {
        public int Numofspinnies { get => numofmovers; protected set => numofmovers = value; }

        public override string ToString()
        {
            return $"Helicopter.{base.ToString()} | {numofmovers} propellers";
        }
    }
}


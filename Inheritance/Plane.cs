using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_MatthewVargas
{
    internal class Plane(string color, int numofmovers) : Air(color)
    {
        private int _numofmovers = numofmovers;
        
        public override string ToString()
        {
            return $"Plane.{base.ToString()} | Number of Jets: {_numofmovers}";
        }

    }
}

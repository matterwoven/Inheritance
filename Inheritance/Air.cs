using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_MatthewVargas
{
    internal class Air(string color) : Vehicle(color)
    {
        public override string ToString()
        {
            return $"Air.{base.ToString()}";
        }
    }
}

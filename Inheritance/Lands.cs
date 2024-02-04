using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_MatthewVargas
{
    internal class Land(string color, int numofmovers) : Vehicle(color)
    {

        private int _numofwheels = numofmovers;
        private string _color = color;


        public int numofwheels { get => _numofwheels; protected set => _numofwheels = value; }

        public override string ToString() 
        {
            return $"Land.{base.ToString()} | Number of Wheels {_numofwheels}";
        }
    }
}

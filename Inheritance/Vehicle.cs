using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_MatthewVargas
{
    public class Vehicle(string color)
    { 
        string _color = color;
          
        public override string ToString()
        {
            return $"Vehicle.Color: {color}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_MatthewVargas
{
    internal class Sea(string color, string nameofvehicle) : Vehicle(color)
    {

        private string _nameofvehicle = nameofvehicle;

        public string nameofvehicle { get => _nameofvehicle; protected set => _nameofvehicle = value; }

        public override string ToString()
        {
            return $"Sea.{base.ToString()} | It is a {_nameofvehicle}";
        }
    }
}

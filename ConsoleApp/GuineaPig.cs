using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp
{
    public class GuineaPig : Animal
    {

        public string Squeak()
        {
            return "Eeee";
        }

        public override string DietaryRequirements()
        {
            return "Plant based";
        }
    }
}

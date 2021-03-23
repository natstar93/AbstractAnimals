using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp
{
    public class Dog : Animal
    {
        public string Bark()
        {
            return "Woof";
        }

        public override string DietaryRequirements()
        {
            return "Anything including your socks";
        }
    }
}

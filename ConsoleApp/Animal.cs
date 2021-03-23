using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public abstract class Animal
    {
        public string Name
        {
            get;
            set;
        }

        public abstract string DietaryRequirements();


    }
}

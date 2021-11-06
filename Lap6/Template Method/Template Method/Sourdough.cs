﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Sourdough : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking the Sourdough Bread.(20 minutes) ");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for Sourdough Bread.");
        }
    }
}

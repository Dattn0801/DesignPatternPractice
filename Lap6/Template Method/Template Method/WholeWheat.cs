using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class WholeWheat : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking the wholewheat Bread.(15 minutes) ");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for WholeWheat Bread.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Animal.Comopsition.Core
{
    public class Animal
    {
        public string Color { get; set; }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
}

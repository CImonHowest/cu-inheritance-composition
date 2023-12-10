using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Animal.Comopsition.Core
{
    public class Dog : Animal
    {

        public string Owner { get; set; }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Dog is eating");
        }

        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
}

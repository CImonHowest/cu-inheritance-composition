using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Animal.Comopsition.Core
{
    public class Lion : Animal
    {

        public string JungleName { get; set; }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Lion is eating");
        }

        public void Roar()
        {
            Console.WriteLine("Lion is roaring");
        }
    }
}

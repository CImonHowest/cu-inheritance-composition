using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Animal.Comopsition.Core
{
    public class Lion
    {
        public string JungleName { get; set; }

        private Animal _animal;

        public string Color
        {
            get { return _animal.Color; }
            set { _animal.Color = value; }
        }

        public Lion()
        {
            _animal = new Animal();
        }

        public void Eat()
        {
            _animal.Eat();
            Console.WriteLine("...like a lion");
        }

        public void Roar()
        {
            Console.WriteLine("Roar!");
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Animal.Comopsition.Core
{
    public class Dog
    {
        private Animal _animal;

        public string Color
        {
            get { return _animal.Color; }
            set { _animal.Color = value; }
        }

        public Dog()
        {
            _animal = new Animal();
        }

        public void Eat()
        {
            _animal.Eat();
            Console.WriteLine("...like a dog");
        }

        public void Bark()
        {
            Console.WriteLine("Woof!");
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{

      class Animal
    {
        //protected member
        protected string Sound;

        //protected method
        protected void Makesound()
        {
            Console.WriteLine($"Animal Makes Sound :{Sound}");
        }

    }

    class Dog : Animal
    {
        public Dog()
        {
            Sound  = "Bark";
        }

        public void DisplaySound()
        {
            Makesound();

        }
    }

    class Cat : Animal
    {
        public Cat()
        {
            Sound = "xyz";
        }
        public void DisplaySound()
        {
            Makesound();


        }

    }

    internal class Protected
    {


        static void Main()
        {


        }

    }
}

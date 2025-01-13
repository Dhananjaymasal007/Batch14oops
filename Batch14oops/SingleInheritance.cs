using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    class Vehical // Base class or parent class or super class
    {
        public string brand { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{brand} is Driving");
        }

    }
    class Car  : Vehical             // deriverd class or chield class or sub class
    { 
        public int NumberofDoors { get; set; }
        
        public void ShowCarInfor()
        {
            Console.WriteLine($"{brand} car has {NumberofDoors} door");

        }

    }

    internal class SingleInheritance
    {
        static void Main()
        {
            Car mycar = new Car();
            mycar.brand = "Hundai";
            mycar.NumberofDoors =4;
            mycar.Drive();
            mycar.ShowCarInfor();
            
        }
    }
}

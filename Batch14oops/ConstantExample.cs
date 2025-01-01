using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{


    class Constantex
    {
        //normal variable declaration
        public int a = 10;
        public string name = "Test";

        //declaration of constant varaiable
        public const double pi = 3.15455;
        const string AppName = "XYZ";

        public void PrintConstants()
        {


            Console.WriteLine(name);

            Console.WriteLine($"The value of pi is :{pi}");
            Console.WriteLine($"The value of AppName is : {AppName}");
            name = "test1";
            Console.WriteLine(name);
          // AppName ="xyz1";
        }
    }
    internal class ConstantExample
    {
        static void Main()
        {
            Constantex cons = new Constantex();
            cons.PrintConstants();


        }


    }
}

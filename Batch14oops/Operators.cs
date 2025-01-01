using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    internal class Operators
    {
        static void Main()
        {

            PublicExampleTest obj1 = new PublicExampleTest();
          // obj1.PublicProperty = 5;
            obj1.Show();
            obj1.Display();




            //Arithmatic Operator

            int a = 10;
            int b = 11;

            Console.WriteLine("Arithmatic Operator");
            Console.WriteLine($"Addition {a+b}");
            Console.WriteLine($"Substraction {a-b}");
            Console.WriteLine($"Multiplication {a*b}");
            Console.WriteLine($"Division {a/b}");
            Console.WriteLine($"Mod{a % b}");

            // Comparision or Relational Operator
            Console.WriteLine("Comparision Operator");
            Console.WriteLine($"a == b: {a ==b}");
            Console.WriteLine($"a !=b: {a!=b}");
            Console.WriteLine($"a < b: {a < b}");
            Console.WriteLine($"a> b: {a>b}");
            Console.WriteLine($"a<= b: {a<=b}");
            Console.WriteLine($"a >= b: {a>=b}");
            Console.WriteLine("End");

            //logical operator 
            bool x = true;
            bool y = true;


            Console.WriteLine("Logical Opertor");
            Console.WriteLine($"x && y :{ x && y}");
            Console.WriteLine($"x || y : {x || y}");
            Console.WriteLine($"!x:{!x}");







        }
    }
}

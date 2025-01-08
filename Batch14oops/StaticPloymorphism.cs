using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    //method name same class also same but diffenent parameter
    //static polymorphsim or  method overloading or compile  time polymorphism or early binding

    
    class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, int b) 
        {
         return a + b;
        }
    }

    internal class StaticPloymorphism
    {
        static void Main()
        {
            MathOperations math = new MathOperations();

            // calling the overload methods

            int sum = math.Add(2, 4);
            double sum1 = math.Add(3.5,4);

            Console.WriteLine("$Sum of Integers : "+sum);

            Console.WriteLine("$Sum of Doubles : "+sum1);


        }
    }
}

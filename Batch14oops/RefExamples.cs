using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    internal class RefExamples
    {
        //Ref Example
       // public int c = 0;
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a= b;
            b= temp;
            //int  c  = a + b;
            //  Console.WriteLine($"addition is {c}");

        }
        static void Main()
        {

            int x = 10;
            int y = 20;
           // int z; // =10;

            Console.WriteLine($"Before swap Values:x={x},y={ y}");
            Swap( ref  x, ref  y);
            Console.WriteLine($"after  swap Values:x={x},y={y}");   

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    internal class OutExamples
    {

        static void Main()
        {
            //declare variable in out
            int result1;//= 10;
            int result2,result3,result4;
            int x =50, y = 10;

            //call method with out parameter

            BasicOperations(x, y, out result1, out result2, out result3, out result4);

            //Display calculations
            Console.WriteLine("addition is :"+ result1);
            Console.WriteLine("Substraction is :"+ result2);
            Console.WriteLine("Multiplication is :"+ result3);
            Console.WriteLine("division is :"+ result4);



        }


        static void BasicOperations(int x,int y,out int Addtion,out int Substraction,out int Multiplications,out int Divisions)
        {
            Addtion = x+ y;
            Substraction = x-y;
            Multiplications = x*y;
            Divisions = x/y;
        }

    }
}

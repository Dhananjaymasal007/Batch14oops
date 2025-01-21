using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{

    internal class GenericDelegate
    {

        // Func  Delegate 

             
        public static double AddNumber1(int a, float b, double c)
        {

            return a + b + c;
          
        }

        //Action Delegate
        public static void AddNumber2(int x , float y, double z)
        {       
            Console.WriteLine(x + y + z);

        }
      
        //Predicate Delegate
        public static bool CheckLength(string str)
        {
            if (str.Length>5)
                return true;
            return false;

        }

        static void Main()
        {
            // func delegate


            Func<int, float, double, double> obj1 = AddNumber1;
            double result = obj1.Invoke(100, 125, 102.35);
            Console.WriteLine(result);

            //Action

            Action<int, float, double> obj2 = AddNumber2;
            obj2.Invoke(200, 125, 225.21);

            //predicate
            Predicate<string> obj3 = CheckLength;
            bool status = obj3.Invoke("Hello");
            Console.WriteLine(status);



        }
    }
}

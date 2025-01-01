using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{


    class ReadOnlyEx
    {

        // property fields
        public readonly int Initialvalue;
        public static readonly double pi;
        public static string test = "Test";
        public ReadOnlyEx(int initialvalue)
        {
            Initialvalue=initialvalue;
            Initialvalue = 20;

        }

        static ReadOnlyEx()
        {
            pi = 3.15365;
        }

        public void PrintValues()
        {
            Console.WriteLine($"initial values:{Initialvalue}");
            Console.WriteLine($"value of pi:{pi}");
        }

    }
    internal class ReadOnlyExample
    {
        static void Main()
        {
           // int value = 5;
            ReadOnlyEx re = new ReadOnlyEx(5);
            re.PrintValues();
        }

    }
}

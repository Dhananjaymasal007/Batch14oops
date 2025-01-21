using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    internal class ExceptionsHandlings
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3 };
            int index = 3;


            //try-- it execute always
            //catch - it execute once error occoured--we can use multiple catch bolock
            //finaly - it execute always either error occoured or not

            try
            {
                int value = numbers[index];
                Console.WriteLine($"value at index  {index} is : {value}");

            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"An error Occoured for index out of boun : {ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error Occoured : {ex.Message}");
            }



            finally
            {
                Console.WriteLine("this code always execute");
            }



            //divide by zero

            int num = 10;
            int deno = 0;
            double result = 0;


            try
            {
                result = num/deno;
                Console.WriteLine($"Result of division:{result}");

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message} cannot be divide by zero");
            }


            //custom exception
            try
            {
                Dataprocessiong(null);

            }
            catch (ArgumentNullException ex)
            {

            }
        }

        static void Dataprocessiong(string data)
        {
            if ( data == null)
            { throw new ArgumentNullException(nameof(data), "Data cannot be null");
            }

        }


    }
}

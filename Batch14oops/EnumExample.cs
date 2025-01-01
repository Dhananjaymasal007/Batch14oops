using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    internal class EnumExample
    {
         enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday

        }


        enum HTTPStatusCode
        {
            OK =  200,
            BadRequest = 400,
            Unauthorized = 401,
            Forbideen = 500,
            NotFound = 400

        }


        static void Main()
        {

            Days today = Days.Saturday;


            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("Todays is Sunday");
                    break;
                case Days.Monday:
                    Console.WriteLine("Today is Monday");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Today is Wedensaday");
                    break;
                case Days.Thursday:
                    Console.WriteLine("Today is Thurdays");
                    break;
                case Days.Friday:
                    Console.WriteLine("Today is Firday");
                    break;
                case Days.Saturday:
                    Console.WriteLine("Today is Saturday");
                    break;

            }  
            
                    if (today == Days.Sunday || today == Days.Saturday)
                    {
                        Console.WriteLine("It's Weekend");
                    }
                    else
                    {
                        Console.WriteLine("It's a week day");   
                    }


            HTTPStatusCode code = HTTPStatusCode.OK;
            Console.WriteLine("HTTP status code:" + code);

            int codenumber = (int)code;
            Console.WriteLine("HTTP Status code number:" + codenumber);
            



        }

    }
}

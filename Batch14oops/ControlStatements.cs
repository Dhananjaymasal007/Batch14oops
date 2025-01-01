using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    internal class ControlStatements
    {

        static void Main()
        {

            //if statement

            int Number = 0;

            string userName = "Sachin";
            if (Number > 0)
            {
                Console.WriteLine("The Number is Positive");
            }


            //if else statement

            if (userName == "Sachin1")
            {
                Console.WriteLine("The Number is Negative");
            }
            else
            {
                Console.WriteLine("The Number is Positive");
            }


            //if else if statement
            int Numbernew = 50;
            if (Numbernew > 0)
            {
                Console.WriteLine("The Number is Positive");
            }
            else if (Numbernew < 0)
            {

                Console.WriteLine("The Number is Negative");

            }

            else if (Numbernew > 100 && Numbernew < 200)
            {

                Console.WriteLine("The Number is Negative");

            }

            else
            {
                Console.WriteLine("The Number is zero");
            }


            //Switch case statement

            int Day = 6;


            switch (Day)
            {

                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Weeekend");
                    break;


            }


            /// for loop
           //int n = 5;
            for (int n = 0; n<5; n++)
            {

                Console.WriteLine("Iteration"+n);

            }



            //while loop



            int i = 0;
            while (i >5)
            {
                Console.WriteLine("Iteration in  while loop"+ i);
                i++;
            }

            //do while loop

            int j = 0;
            do
            {
                Console.WriteLine("Iteration in do while loop"+j);
                j++;
            } while (j >5);



            //continue


            for (i=0; i < 5; i++)
            {

                if (i==3)
                {
                    continue;
                }
                Console.WriteLine("Iteration: "+i);
            }

            //go to statement
            int count = 0;
            startloop:
            
            if(count < 5)
            {
                Console.WriteLine($"count is {count}");
                count++;
                goto startloop;
                Console.WriteLine($"After go to count is {count} ");
            }

            Console.WriteLine("loop with goto is finished");



            //for each statement


            string[] fruits = { "Apple", "Mango", "Banana", "Orange", "Watermelanon", "Strawberry" };

            foreach( string  fruit in fruits ) 
            {
                Console.WriteLine("The Fruit is "+fruit);
            
            }













        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    internal class Arrays
    {

        static void Main()
        {
            //declare the array

            string[] mobile = new string[4];


            ////assigning values

            //mobile[0] = "Apple";
            //mobile[1]= "Sansung";
            //mobile[2] = "Nokia";
            //mobile[3] = "OnePLus";

            //// string[] Mobiles = { "Apple", "Samgang", "Nokia", "VIVO", "RealMe" };

            ////Access values from 

            //for (int i = 0; i < mobile.Length; i++)
            //{
            //    Console.WriteLine("Mobile Names: " + mobile[i]);

            //}

            ////Reverse Number

            //int[] Numbers = { 1, 2, 3, 4, 5 ,6,7,8};



            //Console.WriteLine(Numbers);
            //Print(Numbers);

            ////Reverse

            //Reverse(Numbers);

            //Console.WriteLine("Print Reversed Array: " + Numbers);

            //Print(Numbers);



            //multi dimentional array

            //initialize Multidimentional Array

            int[,] matrix = new int[,]   //int [] number 
            {
                { 1, 2, 3, },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            //Accesssing values from multidimentional arrays

            Console.WriteLine("Element at(0,0):"+ matrix[0, 0]);
            Console.WriteLine("Element at (1,2):"+ matrix[1, 2]);

            //Print all the elements from array

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j<3; j++)
                {

                    Console.Write(matrix[i, j]+ ", ");
                }

                Console.WriteLine();
            }


            // Jagged Array

            //declation of jagged array

            int[][] jaggedarray = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8, 9,10, 11}

              };

            //accessing elements from jagged array
            Console.WriteLine("Element at [0][1:]"+ jaggedarray[0][1]);
            

            for( int i = 0; i < jaggedarray.Length; i++) 
            {
            
                for (int j = 0; j<jaggedarray[i].Length; j++)

                {
                    Console.Write(jaggedarray[i][j]+ " ");
                }

                Console.WriteLine();
            }




        }

        public static void Print(int[] numbers)
            {

                foreach (var num in numbers)
                {
                    Console.WriteLine(num + "");
                }

            }



            public static void Reverse(int[] numbers)
            {
                int start = 0;
                int end = numbers.Length -1;


                while (start < end)
                {
                    // element swaping

                    // int temp = numbers[start];
                    numbers[start] = numbers[end];
                    //numbers[end] = temp;


                    start++;
                    end--;
                }

            }
        }
    }

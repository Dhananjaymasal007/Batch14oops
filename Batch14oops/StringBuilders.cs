using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    internal class StringBuilders
    {

        static void Main()
        {

            //string 
            string str = "Hello World";
           Console.WriteLine(str);

            str = "test";
            Console.WriteLine(str);

            string FirstName = "Sangram";
            string LastName = "Zanje ";
             
            string FullName = FirstName +  LastName;
            Console.WriteLine(FullName);

            //string builder

            StringBuilder sb = new StringBuilder();

            sb.Append("My Name ");
            sb.Append("is ");
            sb.Append("Sangram ");
            sb.Append("Zanje ");
            


            //remove value to string builder in speecific index
           // sb.Remove(3, 3);

            //insert value to string builder in specific index

            sb.Insert(11, "Mr.");

            //replace value in specific index using string builder

            sb.Replace("Sangram", "Sangramsingh");



            Console.Write(sb.ToString());

            sb.Clear();


            //boxing = it is a process of converting value type to object type 
            int x = 10;
            object y = x; //boxing
            


            //Uboxking == it is process of converting object type to value type 
            object o = 10;
                 int i = (int)o; //performs unboxing




        }
    }
}

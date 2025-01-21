using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    internal class Nongeneric
    {
        static void Main()
        {
            //non generic collection

            //**************Arraylist***************//
            //Creating object of an array list 
            ArrayList lst = new ArrayList();


            // adding elements in to array list
            lst.Add(1);
            lst.Add("Hello");
            lst.Add(false);

            //accsing element 
            Console.WriteLine("arrylist elements");
            foreach (var item in lst)
            {
                Console.WriteLine(item);

            }
            lst.RemoveAt(1);
            // lst.RemoveAt()
            Console.WriteLine("arrylist elements");
            foreach (var item in lst)
            {
                Console.WriteLine(item);

            }




            //************hashtable*************//

            Hashtable ht = new Hashtable();

            //add element

            ht.Add(101, "java");
            ht.Add(102, "DOTNET");
            ht.Add(103, 9890);
            ht.Add(104, true);

            //accesssing elements although typecasting

            string value1 = (string)ht[101];
            string value2 = (string)ht[102];
            string value3 = Convert.ToString((int)ht[103]);
            bool value4 = (bool)ht[104];


        }
    }
}

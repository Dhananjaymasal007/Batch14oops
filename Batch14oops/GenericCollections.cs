using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    internal class GenericCollections
    {
        /// Generic Collection
        //1) List
        static void Main()
        {

            //***************LIST*******************//

            //List initialization
            List<int> numbers = new List<int>();
            numbers.Add(11);
            numbers.Add(25);
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers[1]);


            //****************DIctionary**************//

            //initialize dictionary

            Dictionary<string,int> namedict = new Dictionary<string,int>();

            //add key-value pairs to the dictionary

            namedict.Add("Rohit", 25);
            namedict.Add("Ajay", 28);
            namedict.Add("Sachin", 30);

            Console.WriteLine("All elements added in the dictionary");

            foreach(KeyValuePair<string,int> KVP in namedict)
            {
                Console.WriteLine($"{KVP.Key}: {KVP.Value}");

            }


            //modify dict


            namedict["Rohit"]=29;


            Console.WriteLine("All elements added in the dictionary");

            foreach (KeyValuePair<string, int> KVP in namedict)
            {
                Console.WriteLine($"{KVP.Key}: {KVP.Value}");

            }

            //remove elemement in dictionary

            namedict.Remove("Sachin");

            //search element in the ditionary



            if (namedict.ContainsKey("Rohit"))
            {
                Console.WriteLine("exist in dictionary");
            }
            else
            {
                Console.WriteLine("not exist in dictionary");
            }




            //*****************queue**********************//

            Queue qu = new Queue();
            //FIFO- first in first out


            //add element in queue
            qu.Enqueue("Ajay");
            qu.Enqueue(989898989);
            qu.Enqueue(true);

            //remove element in queue
            object firstelement = qu.Dequeue();
            object secondelement = qu.Dequeue();
            object Thirdelement = qu.Dequeue();


            //display
            Console.WriteLine("Dequed Elements");
            Console.WriteLine(firstelement);
            Console.WriteLine(secondelement);
            Console.WriteLine(Thirdelement);



        }



    }
}

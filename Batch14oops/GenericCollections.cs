using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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

            //list
            //dictionary
            //stack
            //queue
            //hasset

            //List initialization
            List<int> numbers = new List<int>();
            numbers.Add(11);
            numbers.Add(2);
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers[1]);


            //****************DIctionary**************//

            //initialize dictionary

            Dictionary<string, int> namedict = new Dictionary<string, int>();

            //add key-value pairs to the dictionary

            namedict.Add("Rohit", 25);
            namedict.Add("Ajay", 28);
            namedict.Add("Sachin", 35);

            Console.WriteLine("All elements added in the dictionary");

            foreach (KeyValuePair<string, int> KVP in namedict)
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



            //*******************Stack****************//
            // LIFO - Last in first out
            Stack st = new Stack();
            st.Push("TOP");
            st.Push(42);
            st.Push(false);
            st.Push(9994343);

            Console.WriteLine(st);


            object topelement = st.Pop();
            object secondelements = st.Pop();
            object thridelements = st.Pop();


            //***********Hasset****************//

            //create hasset
            HashSet<int> numbers2 = new HashSet<int>();

            //add element to the hasset
            numbers2.Add(1);
            numbers2.Add(2);
            numbers2.Add(3);
            numbers2.Add(4);
            numbers2.Add(5);
            numbers2.Add(5);//duplicate elements

            Console.WriteLine("Hasset Elements");
            foreach(int i in numbers2)
            {
                Console.WriteLine(i);
            }
            //find elemet in hasset

            bool containstwo = numbers2.Contains(2);
            Console.WriteLine("Hasset Elements 2:"+ containstwo);

            //remove elements for hasset

            numbers2.Remove(3);

            foreach (int i in numbers2)
            {
                Console.WriteLine(i);
            }

            HashSet<int> hastest = new HashSet<int> { 1,2,3,4,5};

            numbers2.UnionWith(hastest);

            foreach(int i in numbers)
            {
                Console.WriteLine(i);

            }







        }





    }
}

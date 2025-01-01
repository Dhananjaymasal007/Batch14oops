using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch14oops
{


    public class CopyConstructorExample
    {
        //paramater declaration

        public string Name { get; set; }
        public int Age { get; set; }
        public string NameNew { get; set; }
        public int AgeNew { get; set; }



        //parameter Constructor

        public CopyConstructorExample(string name, int age)
        {
            Name = name;
            Age = age;
        }


        //copy constructor
        public CopyConstructorExample(CopyConstructorExample copyex)
        {
            NameNew = copyex.Name;
            AgeNew = copyex.Age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age : {Age}");

        }

        public void DiplayInfoNew()
        {


            Console.WriteLine($"Namenew: {NameNew}, Agename : {AgeNew}");

        }

        
        // 32333 - xyz added new method

        public void abc()
        {


            Console.WriteLine($"Namenew: {NameNew}, Agename : {AgeNew}");

        }
    }
    internal class CopyConstructor
    {
        static void Main()
        {
            //creating objectwith pass the value for paameterized constructor
            CopyConstructorExample obj = new CopyConstructorExample("Ajay", 25);
            obj.DisplayInfo();


            //creating another object using copy constructor

            CopyConstructorExample obj2 = new CopyConstructorExample(obj);

            obj2.DiplayInfoNew();


        }

    }

}

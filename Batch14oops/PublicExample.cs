using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    public class PublicExampleTest
    {
        public int PublicProperty { get; set; }

        public void Show()
        {
            Console.WriteLine("Public Property Value:"+ PublicProperty);
        }
        public void Display()
        {
            Console.WriteLine("Hello");
        }

    }

    public class PublicExample
    {
        static void Main()
        {

            // object creation
           PublicExampleTest obj = new PublicExampleTest();

            obj.PublicProperty = 1;


            obj.Show();
            obj.Display();



            // object cration for another class 
            Internal objinternal = new Internal();
            objinternal.sound = " XYZ";
            objinternal.MakeSound();



        }

    }





}

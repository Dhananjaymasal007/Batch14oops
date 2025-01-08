using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{

    //dynamic polymorphism  // method overriding  // late binding
    //method name same parameter also same but different classes and follows parent child relation ship

    // Base class

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }


    //deried class 1
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");

        }
    }
    //derived class 2
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

    }

    internal class DynamicPolymorphism
    {
        static void Main()
        {

            Shape shape1 = new Shape();
            Shape shape2 = new Circle();
            Shape shape3 = new Rectangle();


            //calling method
            shape1.Draw();
            shape2.Draw();
            shape3.Draw();


        }



    }
}

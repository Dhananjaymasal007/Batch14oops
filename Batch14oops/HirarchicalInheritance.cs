using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{



    class MyShape  ///Base class
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Shape");

        }
    }

    class Circle1 : MyShape
    {
        public void DrawCircle()
        {
            Console.WriteLine("drawing a circle");
        }
    }
    class Rectange : MyShape
    {
        public void DrawRectangle()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

    class Trangle : MyShape
    {
        public void DrawTriangle()
        {
            Console.WriteLine("Drawing a trangle");
        }
    }
    internal class HirarchicalInheritance
    {
        static void Main()
        {
            Circle1 mycircle = new Circle1();
            mycircle.Draw();   /// inherite from base
            mycircle.DrawCircle();  //inherite from derived

            Rectange myrectangle = new Rectange();
            myrectangle.Draw();
            myrectangle.DrawRectangle();

            Trangle mytrangle = new Trangle();
            mytrangle.Draw();
            mytrangle.DrawTriangle();



        }

    }
}

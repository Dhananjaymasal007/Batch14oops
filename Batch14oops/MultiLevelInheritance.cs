using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{

    class A  //base class
    {

        public void start()
        {
            Console.WriteLine("The vehical is started");
        }

    }

    class B : A // derived- base class
    {
        public void Drive()
        {
            Console.WriteLine("car is driving");
        }

    }

    class C :B //
    {
        public void Turboboost()
        {
            Console.WriteLine("the sport car is in the Turbo mode");
        }
    }
    internal class MultiLevelInheritance
    {   

        static void Main()
        {
            C cls = new C();
            cls.start();
            cls.Drive();
            cls.Turboboost();

        }
    }
}

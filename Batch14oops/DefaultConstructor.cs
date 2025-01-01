using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{

    public class DefaultConstructorExample
    {

        public int value;
        //default constructor
        public DefaultConstructorExample()
        {
            value =12;

        }
        //normal method
        public void Disiplay()
        {
            Console.WriteLine("Test  "+value);
        }

    }


    internal class DefaultConstructor
    {
        static void Main()
        {

            //instance creation
            DefaultConstructorExample example = new DefaultConstructorExample();
            //method calling
            example.Disiplay();


        }


    }
}

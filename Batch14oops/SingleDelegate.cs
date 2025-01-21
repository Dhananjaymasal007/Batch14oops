using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{


    //    [<modifier>] delegate returntype|void<name>([<parameterlist>]}
    //delegate declaration
    public delegate void AddDelegate(int a, int b);
    public delegate string DsiplayDelegate(string str);


    class MyDelegate
    {
        public void AddNumbers (int a,int b)
            {
            Console.WriteLine(a+b);
            }
        public static string display(string Str)
        {
            return "Hello"+ Str;

        }

}


internal class SingleDelegate
    {
        static void Main()
        {
            //calling delegate
            MyDelegate md = new MyDelegate();
            AddDelegate ad = new AddDelegate(md.AddNumbers);
            ad(10, 50);



            DsiplayDelegate dp = new DsiplayDelegate(MyDelegate.display);
            string str = dp("Hello");
            Console.WriteLine(str);



        }

    }
}

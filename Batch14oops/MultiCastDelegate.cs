using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{

    public delegate void Notify();

    class MDelegate
    {
        public void StartProcess()
        {
            Console.WriteLine("Process Started..........");

        }
        public void StopProcess() 
        {
            Console.WriteLine("Process ended.......");
        
        }
    }
    internal class MultiCastDelegate
    {
        static void Main()
        {
            //class object
           MDelegate MD = new MDelegate();

            //crate the delegate instance 

            Notify notifydelegate = MD.StartProcess;

            notifydelegate += MD.StopProcess;

            notifydelegate +=() => Console.WriteLine("All process are stopped");
            notifydelegate();




            
        }

    }
}

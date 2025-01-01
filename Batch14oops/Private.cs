using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    
    class PrivateClass
    {
        private int PrivateField;

        private void setField(int value)
        {
            PrivateField = value;
        }

        private void Show()
        {
            Console.WriteLine("Private Filed value"+PrivateField);

        }
    }
    
     class Private
    {
        private int PrivateField;

        private void setField(int value)
        {
            PrivateField = value;
        }

        private void Show()
        {
            Console.WriteLine("Private Filed value  "+PrivateField);

        }



        static void Main()
        {
            Private obj = new Private();

         //   PrivateClass obj = new PrivateClass();
            obj.setField(10);
            obj.PrivateField = 1;
            obj.Show();
  // object cration for another class 
            Internal objinternal = new Internal();
            objinternal.sound = " Roar";
            objinternal.MakeSound();





          

        }



    }
}

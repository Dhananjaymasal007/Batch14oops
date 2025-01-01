using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    internal class Internal
    {

        //internal member
        internal string sound;

        //internal method

        internal void MakeSound()
        {
            Console.WriteLine($"Animal makes Sound:{sound}");
        }

}
}

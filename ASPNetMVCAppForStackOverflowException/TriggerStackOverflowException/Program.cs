using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerStackOverflowException
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            Console.WriteLine(++i);
            while (true) Main(null);
        }
    }
}

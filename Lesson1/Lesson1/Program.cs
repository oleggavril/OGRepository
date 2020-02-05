using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TestInNewBranch");
        }

        static void Method1()
        {
            //change line for master
            Console.WriteLine("TestNewBranchMasterOnly");
        }

        static void Method2()
        {
            Console.WriteLine("Some another text for conflict here");
        }
    }
}

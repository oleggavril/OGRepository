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
            //CHANGE HERE FOR MASTER
            Console.WriteLine("TestNewBranchMasterOnly");
        }

        static void Method2()
        {
            Console.WriteLine("Some another text for conflict here");
        }
    }
}

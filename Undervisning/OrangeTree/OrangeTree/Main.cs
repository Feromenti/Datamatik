using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using OrangeTreeSim;

namespace OrangeTreeMain
{
    class MainMethod
    {

        static void Main(string[] args)
        {
            OrangeTree orangeTree = new OrangeTree();

            orangeTree.SetAge(1);
            int age = orangeTree.GetAge();
            

            Console.WriteLine(age);
        }
    }
}

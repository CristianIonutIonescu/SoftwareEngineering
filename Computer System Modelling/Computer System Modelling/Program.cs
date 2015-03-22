using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_System_Modelling
{
    class Program
    {
        static void Main(string[] args)
        {
            LCG test = new LCG(5648,35,489,4589);

            for(int i = 0;i<10;i++)
            {
                Console.WriteLine(test.Next());
            }

            Console.ReadLine();
        }
    }
}

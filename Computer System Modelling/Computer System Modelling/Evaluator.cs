using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_System_Modelling
{
    class Evaluator
    {
        private iGenerator myGen;

        public Evaluator(iGenerator myGen)
        {
            this.myGen = myGen;
        }

        public double Evaluate(int n)
        {
            UInt64 Np = 0;
            UInt64 Nc = 0;

            for(int i =0;i<n;i++)
            {
                double x = myGen.Next();
                double y = myGen.Next();
                if(x*x + y*y < 1.0)
                {
                    Nc++;
                }
                Np++;
            }

            return (double)Nc / Np;
        }
    }
}

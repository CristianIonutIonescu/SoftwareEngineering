using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_System_Modelling
{
    class LCG:Generator
    {
        private UInt32 a;
        private UInt32 c;
        private UInt32 m;

        public LCG(UInt64 seed, UInt32 a, UInt32 c, UInt32 m)
        {
            this.seed = seed;
            this.a = a;
            this.c = c;
            this.m = m;
        }

        public override double Next()
        {
            seed = (a * seed + c) % m;
            return (double)seed / m;
        }
    }
}

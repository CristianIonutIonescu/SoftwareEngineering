using System;

namespace Computer_System_Modelling
{
    class MidSquare: Generator
    {
        public MidSquare( UInt64 seed)
        {
            this.seed = seed;
        }

        public override double Next()
        {
            ushort seedDigits = (ushort)seed.ToString().Length;
            seed = seed * seed;
            seed /= (UInt64)System.Math.Pow(10,seedDigits/2);
            seed %= (UInt64)System.Math.Pow(10, seedDigits);
            return (double)seed/Math.Pow(10,seedDigits);
        }
    }
}

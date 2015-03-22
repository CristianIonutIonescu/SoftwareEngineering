using System;

namespace Computer_System_Modelling
{
    public abstract class Generator: iGenerator
    {
        protected UInt64 seed;
        public abstract double Next();
    }
}

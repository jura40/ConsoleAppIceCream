using ConsoleAppIceCream.Factory.ConcreteFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppIceCream
{
    public abstract class SizeFactory
    {
        public abstract ISize GetSize(string sizeType);

        public static SizeFactory CreateSizeFactory(string factoryType)
        {
            if (factoryType.ToLower() == "Yes")
                return new YesFactory();

            return new NoFactory();
        }
    }
}

using ConsoleAppIceCream.Size;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppIceCream
{
    public class NoFactory : SizeFactory
    {
        public override ISize GetSize(string sizeType)
        {
            if (sizeType.ToLower() == "medium")
                return new Medium();

            return null;
        }
    }
}

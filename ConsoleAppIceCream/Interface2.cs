using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppIceCream
{
    public interface ICommand
    {
        void Execute(Stack<IceCream> order, IceCream newIceCream);
    }
}

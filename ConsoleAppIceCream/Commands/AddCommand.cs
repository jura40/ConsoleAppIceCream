using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppIceCream.Commands
{
    public class AddCommand : ICommand
    {
        public void Execute(Stack<IceCream> iceCreams, IceCream newIceCream)
        {
            iceCreams.Push(newIceCream);
        }
    }
}

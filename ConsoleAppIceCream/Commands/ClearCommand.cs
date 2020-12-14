using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppIceCream.Commands
{
    public class ClearCommand : ICommand
    {
        public void Execute(Stack<IceCream> iceCreams, IceCream newIceCream = null)
        {
            iceCreams.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppIceCream.Commands
{
    public class RedoCommand : ICommand
    {
        public void Execute(Stack<IceCream> iceCreams, IceCream newIceCream = null)
        {
            iceCreams.Push(iceCreams.Peek());
        }
    }
}

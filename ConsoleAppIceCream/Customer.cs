using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppIceCream
{
    class Customer
    {
        private IceCream _iceCream;
        private ICommand _command;
        private Order _order;

        public Customer()
        {
            _order = new Order();
        }

        public void SetCommandOption(int option)
        {
            _command = CommandFactory.GetCommand(option);
        }

        public void SetIceCream(IceCream iceCream)
        {
            _iceCream = iceCream;
        }

        public void RunCommand()
        {
            _order.RunCommand(_command, _iceCream);
        }

        public void ShowOrder()
        {
            _order.ShowCurrentIceCream();
        }
    }
}

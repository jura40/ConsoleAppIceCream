using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppIceCream
{
    public class Order
    {
        public Stack<IceCream> listOficeCreams { get; set; }

        public Order()
        {
            listOficeCreams = new Stack<IceCream>();
        }

        public void RunCommand(ICommand command, IceCream iceCream)
        {
            command.Execute(listOficeCreams, iceCream);
        }

        public void ShowCurrentIceCream()
        {
            foreach (var prod in listOficeCreams)
            {
                prod.DisplayIceCream();
            }

            if (!listOficeCreams.Any())
            {
                Console.WriteLine("\nEmpty shopping list :(\n");
            }

            Console.WriteLine("----------------------------------");
        }
    }
}

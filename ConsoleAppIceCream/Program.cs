using System;

namespace ConsoleAppIceCream
{
    class Program

    {
        static void Main(string[] args)
        {
            var user = new Customer();

            user.SetCommandOption(1); //add
            user.SetIceCream(new IceCream("Chokolade", 20, 2));
            user.RunCommand();

            user.SetCommandOption(1); //add
            user.SetIceCream(new IceCream("Vanile", 30, 3));
            user.RunCommand();
            user.ShowOrder();

            SetSize("yes", "Medium");

            user.SetCommandOption(2 ); //redo
            user.RunCommand();
            user.ShowOrder();

            SetSize("yes", "Big");

            user.SetCommandOption(3); //undo
            user.RunCommand();
            user.ShowOrder();

            SetSize("yes", "Smal");

            user.SetCommandOption(4); //clear
            user.RunCommand();
            user.ShowOrder();

            Console.ReadLine();
        }

        private static void SetSize(string sizeType, string bankCard)
        {
            var type = SizeFactory.CreateSizeFactory(sizeType);
            var sort = type.GetSize(bankCard);
            Console.WriteLine(sort.Size() + "\n----------------------------------");
        }
    }
}

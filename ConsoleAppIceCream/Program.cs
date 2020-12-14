using System;

namespace ConsoleAppIceCream
{
    class Program

    {
        static void Main(string[] args)
        {
            var user = new Customer();

            user.SetCommandOption(1 /*Add command*/);
            user.SetIceCream(new IceCream("Dining table", 1500, 2));
            user.RunCommand();

            user.SetCommandOption(1 /*Add command*/);
            user.SetIceCream(new IceCream("dishwasher", 6000, 3));
            user.RunCommand();
            user.ShowOrder();

            SetSize("Yes", "Medium");

            user.SetCommandOption(2 /*Redo command*/);
            user.RunCommand();
            user.ShowOrder();

            SetSize("Yes", "Big");

            user.SetCommandOption(3 /*Undo command*/);
            user.RunCommand();
            user.ShowOrder();

            SetSize("Yes", "Smal");

            user.SetCommandOption(4 /*Clear command*/);
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

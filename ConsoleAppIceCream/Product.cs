using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppIceCream
{
    public class IceCream
    {
        public string Name { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }

    public IceCream(string name, decimal price, int amount)
    {
        Name = name;
        Price = price;
        Amount = amount;
    }

    public void DisplayIceCream()
    {
        Console.WriteLine($"\nName: {Name}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Amount: {Amount}");
    }
}
}

// Program.cs
using System;
using lab_1_KPZ;

class Program
{
    static void Main()
    {
        Money price = new Money(10, 50);           // 10 грн 50 коп
        Product bread = new Product("Хліб", price);

        Warehouse warehouse = new Warehouse();
        warehouse.AddProduct(bread, 20);

        Console.WriteLine("Початковий склад:");
        warehouse.ShowInventory();

        bread.Discount(2, 0);  // знижка 2 грн

        Console.WriteLine("\nПісля знижки:");
        warehouse.ShowInventory();
    }
}

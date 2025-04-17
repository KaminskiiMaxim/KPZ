using System;
using System.Collections.Generic;


public class Virus
{
    public string Name { get; set; }               // Ім’я віруса
    public string Type { get; set; }               // Вид віруса
    public int Age { get; set; }                   // Вік
    public float Weight { get; set; }              // Вага

    public List<Virus> Children { get; set; }      // Список "нащадків" вірусу

    // Конструктор — створює новий вірус
    public Virus(string name, string type, int age, float weight)
    {
        Name = name;
        Type = type;
        Age = age;
        Weight = weight;
        Children = new List<Virus>();
    }

    // Метод для додавання нащадка (дитини)
    public void AddChild(Virus child)
    {
        Children.Add(child);
    }

    // Метод Clone() — створює копію поточного вірусу з усіма дітьми
    public Virus Clone()
    {
        // Клонуємо сам об'єкт
        Virus clone = new Virus(this.Name, this.Type, this.Age, this.Weight);

        // Рекурсивно клонуємо всіх дітей
        foreach (Virus child in this.Children)
        {
            clone.AddChild(child.Clone());  // Кожна дитина теж клонується
        }

        return clone;
    }

    // Метод для виведення віруса і його дітей на екран (для перевірки)
    public void Print(string indent = "")
    {
        Console.WriteLine($"{indent}- {Name} ({Type}), {Age} років, {Weight} кг");

        foreach (var child in Children)
        {
            child.Print(indent + "  "); // Відступ для ієрархії
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створимо "сімейство" вірусів: три покоління

        // Діти другого покоління
        Virus child1 = new Virus("Child-1", "Alpha", 1, 0.5f);
        Virus child2 = new Virus("Child-2", "Alpha", 1, 0.6f);

        // Вірус-батько (перше покоління)
        Virus parent = new Virus("Parent", "Delta", 3, 1.2f);
        parent.AddChild(child1);
        parent.AddChild(child2);

        // Дитина третього покоління
        Virus grandchild = new Virus("Grandchild", "Beta", 0, 0.3f);
        child1.AddChild(grandchild);  // Додаємо дитину до першого нащадка

        // Виводимо оригінального віруса
        Console.WriteLine("Оригінальний вірус:");
        parent.Print();

        // Клонуємо віруса
        Virus clone = parent.Clone();

        Console.WriteLine("\nКлонований вірус:");
        clone.Print();
    }
}

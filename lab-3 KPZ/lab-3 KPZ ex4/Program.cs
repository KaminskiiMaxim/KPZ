using System;
using System.IO;
using System.Text.RegularExpressions;

class Reader
{
    public char[][] Read(string file)
    {
        string[] lines = File.ReadAllLines(file);
        char[][] result = new char[lines.Length][];
        for (int i = 0; i < lines.Length; i++)
        {
            result[i] = lines[i].ToCharArray();
        }
        return result;
    }
}

class ReaderLog
{
    private Reader reader = new Reader();

    public char[][] Read(string file)
    {
        char[][] data = reader.Read(file);
        int symbols = 0;
        foreach (var line in data)
        {
            symbols += line.Length;
        }

        Console.WriteLine($"Файл: {file}");
        Console.WriteLine($"Рядків: {data.Length}");
        Console.WriteLine($"Символів: {symbols}");

        return data;
    }
}

class ReaderBlock
{
    private Reader reader = new Reader();
    private string pattern;

    public ReaderBlock(string pattern)
    {
        this.pattern = pattern;
    }

    public char[][] Read(string file)
    {
        if (Regex.IsMatch(file, pattern))
        {
            Console.WriteLine("Заборонено!");
            return null;
        }

        return reader.Read(file);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string file = "test.txt"; //створює файл

        ReaderLog log = new ReaderLog();
        log.Read(file);

        ReaderBlock block = new ReaderBlock(".*secret.*");
        block.Read("secret.txt"); //забороняє
        block.Read("test.txt"); //дозволяє
    }
}

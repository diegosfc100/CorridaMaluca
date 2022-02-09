using System;
using CorridaMaluca;

class Program
{
    static void Main(string[] args)
    {
        Corredor obj = new Corredor();
        obj.Nome = "diego";
        Console.WriteLine($"Nome: {obj.Nome}");
        Console.ReadKey();
    }
}
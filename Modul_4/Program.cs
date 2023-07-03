using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите имя");
        var name = Console.ReadLine();
        Console.WriteLine("Ваше имя наоборот:");
        char [] eman = new char[name.Length];
        for (int i = 0; i < eman.Length; i++)
        {
            eman[i] = name[name.Length -i -1];
            Console.Write(eman[i] + " ");
        }

    }
}
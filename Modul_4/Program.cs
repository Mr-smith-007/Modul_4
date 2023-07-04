using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int [,] array = { {-5, 6, 9, 1, 2, -3},{ -8, 8, 1, 1, 2, -3 } };
        int kp = 0;
        foreach (int x in array)
        {
            if (x > 0)
                kp++;
        }
        Console.WriteLine($"Количество положительных элементов массива {kp}");
        
    }
}


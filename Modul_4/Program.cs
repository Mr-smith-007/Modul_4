using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var array = new int[] { -5, 6, -9, 1, -2, -3, 4, -1 ,2, 0 };
        int kp = 0;
        foreach (int x in array)
        {
            if (x > 0)
                kp++;
        }
        Console.WriteLine($"Количество положительных элементов массива {kp}");
        
    }
}


using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var array = new int[] { 5, 6, 9, 1, 2, 3, 4 };

        int t;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    t = array[i];
                    array[i] = array[j];
                    array[j] = t;
                }
            }
        }

        foreach (var x in array)
        {
            Console.Write(x);
        }
    }
}


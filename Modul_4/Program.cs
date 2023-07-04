class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { {-5, 6, 9, 1, 2, -3}, {-8, 8, 1, 1, 2, -3} };
        int t;
        for (int i = 0; i < array.GetUpperBound(0) +1; i++)
        {
            for (int j = 0; j < array.GetUpperBound(1) +1; j++)
            {
                for (int k = j + 1; k < array.GetUpperBound(1) + 1; k++)
                {
                    if (array[i, j] > array[i, k])
                    {
                        t = array[i, k];
                        array[i, k] = array[i, j];
                        array[i, j] = t;
                    }
                }
            }
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j] + " ");
            Console.WriteLine();
        }
        Console.ReadKey();



    }
}


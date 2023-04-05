using System;

class TwoDArray
{
    private int[,] array;

    public TwoDArray(int[,] arr)
    {
        array = arr;
    }

    public double this[int i]
    {
        get
        {
            int sum = 0;
            int n = array.GetLength(1);
            for (int j = 0; j < n; j++)
            {
                sum += array[i, j];
            }
            return (double)sum / n;
        }
    }

    public int Product
    {
        get
        {
            int product = 1;
            int n = array.GetLength(0);
            int m = array.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    product *= array[i, j];
                }
            }
            return product;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n, m;
        Console.WriteLine("Enter the dimensionality of the array");
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("m = ");
        m = int.Parse(Console.ReadLine());

        int[,] arr = new int[n, m];
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = random.Next(1,10);
                Console.Write("{0,4}", arr[i, j]);
            }
            Console.WriteLine();
        }
        //int[,] arr = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
        TwoDArray array = new TwoDArray(arr);

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine("Average of row {0}: {1}", i, array[i]);
        }

        Console.WriteLine("Product of all elements: {0}", array.Product);
    }
}
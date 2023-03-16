using System;

public class Program
{
    static int RodCut(int[] price, int i, int n)
    {
        if (i != 0)
        {
            int RodLength = i + 1;
            int CutLength = int.MinValue;
            int RemainingLength = RodCut(price, i - 1, n);

            if (RodLength <= n)
            {
                CutLength = price[i] + RodCut(price, i, n - RodLength);
            }

            return Maximum(RemainingLength, CutLength);
        }
        return n * price[0];
    }
    static int Maximum(int a, int b)
    {
        if (b > a) return b;
        return a;
    }

    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] seperator = { " " };
        string[] seperated = input.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        int N = int.Parse(seperated[0]);
        int M = int.Parse(seperated[1]);
        input = Console.ReadLine();
        int[] sizes = Array.ConvertAll(input.Split(seperator, StringSplitOptions.RemoveEmptyEntries), int.Parse);
        input = Console.ReadLine();
        int[] prices = Array.ConvertAll(input.Split(seperator, StringSplitOptions.RemoveEmptyEntries), int.Parse);

        int[] price = new int[N];
        for (int j = 0; j < M; j++)
            price[sizes[j] - 1] = prices[j];
        int size = price.Length;
        Console.WriteLine(RodCut(price, size - 1, size));
    }
}


using System;
using System.Linq;

public class Program
{
    
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] seperator = { " " };
        string[] seperated = input.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        int N = int.Parse(seperated[0]);
        int loss = int.Parse(seperated[1]);
        int gain = int.Parse(seperated[2]);
        input = Console.ReadLine();
        int[] percents = Array.ConvertAll(input.Split(seperator, StringSplitOptions.RemoveEmptyEntries), int.Parse);

        int Min = percents.Min();
        int Available_Doses = Min / loss;
        int Needed_Doses = 0;

        for(int i = 0; i < N; i++)
        {
            if(percents[i] != Min)
            {
                Needed_Doses += (100 - percents[i] + gain - 1) / gain;
            }
        }

        if (Available_Doses >= Needed_Doses)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}


// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

//Console.WriteLine("Hello, World!");


class GenerateAllPairs
{
    static bool twoSum(int[] arr, int target)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    return true;
                }
            }
        }

        return false;
    }


    static void Main()
    {
        int[] arr = { 0, -1, 2, -3, 1 };
        int target = -2;
        if (twoSum(arr, target))
            Console.WriteLine("true");
        else Console.WriteLine("false");
    }
}
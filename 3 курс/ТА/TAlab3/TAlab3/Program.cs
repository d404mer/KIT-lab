using System;

public class KMP
{

    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string pattern = Console.ReadLine();
        ComputePrefixFunction(pattern);
    }


    public static int[] ComputePrefixFunction(string pattern)
    {
        int m = pattern.Length;
        int[] prefixArray = new int[m];
        int k = 0;

        for (int q = 1; q < m; q++)
        {
            while (k > 0 && pattern[k] != pattern[q])
                k = prefixArray[k - 1];

            if (pattern[k] == pattern[q])
                k++;

            prefixArray[q] = k;
        }

        return prefixArray;
    }

    public static void KMPSearch(string text, string pattern)
    {
        int n = text.Length;
        int m = pattern.Length;
        int[] prefixArray = ComputePrefixFunction(pattern);
        int j = 0;

        for (int i = 0; i < n; i++)
        {
            while (j > 0 && text[i] != pattern[j])
                j = prefixArray[j - 1];

            if (text[i] == pattern[j])
                j++;

            if (j == m)
            {
                Console.WriteLine($"Подстрока найдена по индексу {i - m + 1}");
                j = prefixArray[j - 1];
            }
            else Console.WriteLine("aaa");
        }
    }
}

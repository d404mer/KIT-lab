using System;
using System.Collections.Generic;
using System.IO;

namespace TALB3
{
    public class BoyerMooreHorspool
    {
        private const int ASCII_SIZE = 256;

        public static List<int> Search(string text, string pattern)
        {
            if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(text))
            {
                return new List<int>(); 
            }

            text = text.ToLower();
            pattern = pattern.ToLower();

            int[] shift = BuildShiftTable(pattern);
            List<int> result = new List<int>();
            int n = text.Length;
            int m = pattern.Length;

            int i = 0;
            while (i <= n - m)
            {
                int j = m - 1;

                while (j >= 0 && pattern[j] == text[i + j])
                {
                    j--;
                }

                if (j < 0) 
                {
                    result.Add(i);
                    i += (i + m < n) ? shift[text[i + m]] : 1;
                }
                else 
                {
                    int shiftValue = (text[i + j] < ASCII_SIZE) ? shift[text[i + j]] : m; 
                    i += Math.Max(1, j - shiftValue);
                }
            }

            return result;
        }

        private static int[] BuildShiftTable(string pattern)
        {
            int m = pattern.Length;
            int[] shift = new int[ASCII_SIZE];

            for (int i = 0; i < ASCII_SIZE; i++)
            {
                shift[i] = m;
            }

            for (int i = 0; i < m - 1; i++)
            {
                shift[(int)pattern[i]] = m - 1 - i;
            }

            return shift;
        }

    
        public static List<int> SearchInFile(string filePath, string pattern)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Файл не найден: {filePath}");
            }

            string text = File.ReadAllText(filePath);
            Console.WriteLine("Считанный текст: ");
            Console.WriteLine(text); 
            return Search(text, pattern);
        }
    }
}

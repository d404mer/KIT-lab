using System;
using System.Collections.Generic;

namespace TALB3
{
    using System;
    using System.Collections.Generic;

    public class KnuthMorrisPratt
    {
        public static List<int> Search(string text, string pattern)
        {
            var result = new List<int>();
            int[] lps = BuildLPS(pattern);
            int i = 0, j = 0;

            while (i < text.Length)
            {
                if (pattern[j] == text[i])
                {
                    i++;
                    j++;
                }

                if (j == pattern.Length)
                {
                    result.Add(i - j);
                    j = lps[j - 1];
                }
                else if (i < text.Length && pattern[j] != text[i])
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i++;
                }
            }

            return result;
        }

        private static int[] BuildLPS(string pattern)
        {
            int[] lps = new int[pattern.Length];
            int length = 0;
            int i = 1;

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[length])
                {
                    length++;
                    lps[i] = length;
                    i++;
                }
                else
                {
                    if (length != 0)
                    {
                        length = lps[length - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }

            return lps;
        }
    }

}

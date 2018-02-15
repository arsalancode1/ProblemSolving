using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Strings
{
    partial class Anagram
    {
        public bool CheckAnagram(string str1, string str2)
        {
            str1 = str1.ToLowerInvariant();
            str2 = str2.ToLowerInvariant();

            if (str1.Length != str2.Length)
            {
                return false;
            }

            int[] index1 = new int[26];
            int[] index2 = new int[26];

            for (int i = 0; i < 26; i++)
            {
                index1[i] = 0;
                index2[i] = 0;
            }

            foreach (char c in str1)
            {
                index1[(int)c - 97] = index1[(int)c - 97] + 1;
            }

            foreach (char c in str2)
            {
                index2[(int)c - 97] = index2[(int)c - 97] + 1;
            }

            for (int i = 0; i < 26; i++)
            {
                if (index1[i] != index2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using System;

namespace PermutationString
{
    public class Program
    {
        private static void permutationString(String str, int a, int b)
        {
            if (a == b)
                Console.WriteLine(str);
            else
            {
                for (int i = a; i <= b; i++)
                {
                    str = swap(str, a, i);
                    permutationString(str, a + 1, b);
                    str = swap(str, a, i);
                }
            }
        }
        public static String swap(String c, int i, int j)
        {
            char tmp;
            char[] charArray = c.ToCharArray();
            tmp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = tmp;
            string r = new string(charArray);
            return r;
        }
        public static void Main()
        {
            String str = "RICE";
            int n = str.Length;
            Console.WriteLine("Permutation of string RICE is :---");
            permutationString(str, 0, n - 1);
        }

    }
}   

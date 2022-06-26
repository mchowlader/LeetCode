using System;
using System.Text;

namespace _14_LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringArray = new string[] { "ac", "aaa", "aaba"};
            Console.Write(LongestCommonPrefix(stringArray));
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            var shortLen = strs[0].Length;
            string prefix = "";

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < shortLen)
                {
                    shortLen = strs[i].Length;
                }
            }

            for (int i = shortLen; i > 0; i--)
            {
                var count = 0;

                prefix = strs[0].Substring(0, i);

                for (int j = 1; j < strs.Length; j++)
                {
                    var k = strs[j].StartsWith(prefix);

                    if (k)
                    {
                        count++;
                    }
                }

                if (count == strs.Length - 1)
                {
                    return prefix;
                }
            }

            return "";
        }
    }
}
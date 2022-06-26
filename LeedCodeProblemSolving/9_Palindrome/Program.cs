using System;

namespace _9_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntPalindromeCheck(11312));
        }

        public static bool IntPalindromeCheck(int number)
        {
            var value = number.ToString();
            var size = number.ToString().Length/2; ;
            var j = value.Length-1;

            for (var i = 0; i <= size; i++)
            {
                if (value[i] == value[j])
                {
                    j--;
                }

                else
                    return false;
            }

            return true;
        }
    }
}

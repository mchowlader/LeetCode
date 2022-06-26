using System;
using System.Collections.Generic;
using System.Linq;

namespace _13_ConvertRomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("XIV"));
        }

        public static int RomanToInt(string roman)
        {
             var romanList = new Dictionary<string, int>()
            {
                { "I", 1}, { "V", 5 } , { "X", 10 } , { "L", 50 }, { "C", 100 }, { "D", 500 }, { "M", 1000 }
            };

            var romanChar = roman.ToCharArray();
            var previousNumber = 0;
            var result = 0;
             
            for (var i = 0; i < romanChar.Count(); i++)
            {
                var currentRoman = romanChar[i].ToString();
                var currentNumber = romanList[currentRoman];
                var numberToPlus = currentNumber;

                if(previousNumber < currentNumber && previousNumber != 0)
                {
                    result = result - previousNumber;
                    numberToPlus = currentNumber - previousNumber;
                }
                result = result + numberToPlus;
                previousNumber = currentNumber;
            }

            return result;
        }
    }
}

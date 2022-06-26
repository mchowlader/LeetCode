using System;

namespace TwoSum_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 4, 9,7,5,8 };
            
            Console.Write("Enter a target number: ");
            var target = int.Parse(Console.ReadLine());

            var x = new Program();
            x.TwoSum(numbers, target);

            Console.WriteLine($"{numbers[0]}, {numbers[1]})");


            //for(var x = 0; x < numbers.Length; x++)
            //{
            //    for(var y = x+1; y < numbers.Length; y++)
            //    {
            //        if(numbers[x] + numbers[y] == target)
            //        {
            //            Console.Write($"[{x},{y}]");
            //        }
            //    }
            //}
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] num1 = new int[2];
            var br = false;

            for (var x = 0; x < nums.Length; x++)
            {
                for (var y = x + 1; y < nums.Length; y++)
                {
                    if (nums[x] + nums[y] == target)
                    {
                        num1[0] = x;
                        num1[1] = y;
                        br = true;
                        break;
                    }
                }
                if (br == true)
                    break;
            }

            return num1;
        }
    }
}

namespace FIndAvarageFromArrayExcludingMinAndMaxValue
{
    public class program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 2, 20, 50, 100, 57 };
            Console.WriteLine(FindAvarae(arr));
        }
        public static double FindAvarae(int[] numbers)
        {
            var max = numbers.Max();
            var min = numbers.Min();
            var result = 0.0;

            for(var i = 0; i <= numbers.Length-1; i++)
            {
                result += numbers[i];
            }

            result -= (max + min);
            result /= numbers.Length-2;

            return result;
        }
    }
}
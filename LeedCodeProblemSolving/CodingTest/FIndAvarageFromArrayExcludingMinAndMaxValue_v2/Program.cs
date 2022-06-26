namespace FIndAvarageFromArrayExcludingMinAndMaxValue
{
    public class program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 2, 20, 50, 100, 1 };
            Console.WriteLine(FindAvarae(arr));
        }

        public static double FindAvarae(int[] numbers)
        {
            var result = 0.0;
            var max = numbers[0];
            var min = numbers[0];

            for(var i = 1; i <= numbers.Length-1; i++)
            {
                
                if(numbers[i] > max)
                    max = i;
                if(numbers[i] < max)
                    min = i;

                result += numbers[i];

            }


            result -= (max + min);
            result /= numbers.Length - 2;
            //result = (result +(max+min)) / numbers.Length-2;

            return result;
        }
    }
}

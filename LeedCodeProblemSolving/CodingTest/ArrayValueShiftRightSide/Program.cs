namespace ArrayValueShiftRightSide
{
    public class program
    {
        static void Main(string[] arg)
        {
            var arr = new int[]{ 1,4,6,2};

            ShiftRightSide(arr); ;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
        static int[] ShiftRightSide(int[] numbers)
        {
            var lstValue = numbers[numbers.Length - 1];

            for(var i = numbers.Length-1; i > 0; i--)
            {
                numbers[i] = numbers[i-1];
            }

            numbers[0] = lstValue;

            return numbers;
        }
    }
}
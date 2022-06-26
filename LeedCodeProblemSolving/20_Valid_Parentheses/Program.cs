namespace Valid_Parentheses
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ParenthesesCheck("()"));
        }

        public static bool ParenthesesCheck(string value)
        {
            var chack = new string[] { "(", ")", "{", "}", "[", "]"};

            var condition =  chack.Contains(value);

            if(condition)
            {
                for(int i = 0; i < value.Length; i++)
                {
                    for(var j = 0; j < chack.Length; j++)
                    {
                        if (value[j].ToString() == chack[i])
                        {
                            if (value[j+1].ToString() == chack[i+1])
                            {
                                return true;
                            }
                        }

                        return false;
                    }
                }
            }

            return false;
        }
    }
}
using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            string answer = Add(1,0,true);
            Console.WriteLine(answer);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool isDollars)
        {
            int result = x + y;

            if (isDollars)
            {
                return (result > 1) ? $"{result} dollars" : $"{result} dollar";
            }
            else
            {
                return $"{result}";
            }
            
        }
    }
}

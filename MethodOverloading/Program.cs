using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int addAnswer = Add(10, 10);
            Console.WriteLine(addAnswer);
            decimal decAnswer = Add(20.5m, 25.5m);
            Console.WriteLine(decAnswer);
            string answer1 = Add(1, 0, true);
            Console.WriteLine(answer1);
            string answer2 = Add(10, 15, true);
            Console.WriteLine(answer2);
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

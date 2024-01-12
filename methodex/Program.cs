namespace methodex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5, 11);
            Console.WriteLine(result);

            double result2 = Multiply(10,9.3);
            Console.WriteLine(result2);

            int result3 = Devision(100, 10);
            Console.WriteLine(result3);

            int result4 = Subtract(100, 50);
            Console.WriteLine(result4);
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static int Devision(int x, int y)
        {
            return x / y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}

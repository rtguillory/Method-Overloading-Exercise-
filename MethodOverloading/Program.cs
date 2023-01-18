namespace MethodOverloading
{
    public class Program
    {
        //Add method for integers
        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        //overloaded Add method for decimals
        static double Add(double d1, double d2)
        {
            return d1 + d2;
        }

        //overloaded Add method to return string
        static string Add(int n1, int n2, bool b1)
        {
            if (b1)
            {
                int sum = n1 + n2;
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                return $"{sum} dollars";
            }
            return "";

        }


        static void Main(string[] args)
        {
            Console.WriteLine($"int add: {Add(4, 1)}");
            Console.WriteLine($"decimal add: {Add(3.6, 2.1)}");
            Console.WriteLine($"int add: {Add(-4, 1)}");
            Console.WriteLine($"string add: {Add(7, 2, true)}");
            Console.WriteLine($"string add: {Add(7, 2, false)}");
            Console.WriteLine($"string add: {Add(-1, 2, true)}");
        }
    }
}

using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg két számot ");
           int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg két számot ");
           int B = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine(B);
            }
        }
    }
}

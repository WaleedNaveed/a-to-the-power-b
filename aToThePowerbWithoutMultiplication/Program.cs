using System;

namespace aToThePowerbWithoutMultiplication
{
    class Program
    {
        int pow(int a, int b)
        {
            if (b == 0)
                return 1;
            int answer = a;
            int increment = a;
            int i, j;
            for (i = 1; i < b; i++)
            {
                for (j = 1; j < a; j++)
                {
                    answer += increment;
                }
                increment = answer;
            }
            return answer;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            int a, b;
            Console.Write("Enter Number a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number b : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("--------------------------OutPut-----------------------------");
            Console.WriteLine("Value of a = " + a);
            Console.WriteLine("Value of b = " + b);
            Console.WriteLine("a to the power b = " + obj.pow(a, b));

            Console.ReadKey();

        }
    }
}

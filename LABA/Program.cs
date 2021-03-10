using System;

namespace LABA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int count = 0;
            while (k == 0)
            {
                if (Math.Pow(count, 3) > n)
                {
                    k = count;
                }
                else { count += 1; }
            }
            Console.WriteLine("K={0},3K={1}", k, k * 3);

        }
    }
}

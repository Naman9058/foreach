using System;
namespace app
{
    class Program
    {
        static void Main(string[]arg)
        {
            int[] num = { 1, 2,3, 4, 5, 6, 7, 8, 9, 10,};
            Console.WriteLine(num.Max());
            for (int i = 1; i < num.Length; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
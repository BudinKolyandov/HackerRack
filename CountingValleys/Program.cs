using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var ar = Console.ReadLine().ToUpper();

            var position = 0;

            var count = 0;

            for (int i = 0; i < n; i++)
            {
                var path = ar[i];
                if (path == 'U')
                {
                    if (++position == 0)
                    {
                        count++;
                    }
                }
                else if (path == 'D')
                {
                    position--;
                }


            }
            Console.WriteLine(count);
        }
    }
}

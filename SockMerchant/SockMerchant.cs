using System;
using System.Linq;

namespace SockMerchant
{
    class SockMerchant
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var ar = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var count = 0;

            var arGroup = ar.GroupBy(x => x).ToArray();

            for (int i = 0; i < arGroup.Length; i++)
            {
                count += (arGroup[i].Count() / 2);
            }

            Console.WriteLine(count);
        }
    }
}

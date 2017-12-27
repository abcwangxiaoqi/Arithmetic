using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums={243, 5, 7, 22, 3, 11};

            long paytime=0;
            SortBase sort=new QuickSort();
            paytime=sort.run(nums);
            Console.WriteLine("paytime="+paytime);
        }
    }
}

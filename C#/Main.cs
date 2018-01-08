using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums={243, 5, 7, 22, 3, 11};

            long paytime=0;
            //SortBase sort=new BetterQuickSort1();
            //SortBase sort=new QuickSort();
            //SortBase sort=new BubblingSort();
            //SortBase sort=new SelectSort();
            SortBase sort=new InsertSort();
            paytime=sort.run(nums);
            Console.WriteLine("paytime="+paytime);
        }
    }
}

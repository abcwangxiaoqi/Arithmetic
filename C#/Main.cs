using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            stringAction();
        }

        static void stringAction()
        {
            string[] str = { "1237895", "12386597", "1238659598684" };
            string common = StringArithmetic.longestCommonPrefix(str);
            Console.WriteLine(common);
        }

        static void template()
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

﻿using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            search();
        }

        static void search()
        {
            int[] nums={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19};
            
            SearchBase search=new BinarySearch();
            int index=search.find(nums,3);
            Console.WriteLine(index);
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

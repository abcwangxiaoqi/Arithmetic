/*
选择排序

虽然效率值和冒泡排序一样，但是选择排序交换次数比冒泡排序少，每次找到最小的再进行交换，
所以选择排序要比冒泡排序效率高

效率：
O（n^2）
 */
using System;

public class SelectSort : SortBase
{

    override public string Name
    {
        get
        {
            return "选择排序";
        }
    }   

    protected override void sort(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int min=i;
            for (int j = i+1; j < nums.Length; j++)
            {
                if(nums[j]<nums[min])
                {
                    min=j;
                }
            }

            if(min!=i)
            {
                swap(nums,i,min);
            }          
        }
    }
}
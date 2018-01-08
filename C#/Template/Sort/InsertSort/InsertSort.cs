/*
插入排序

分为有序数组和无序数组
左边全部有序，右边数组逐个插入到左边有序数组中，最终完成排序

效率：
O（n^2）
 */
using System;

public class InsertSort : SortBase
{

    override public string Name
    {
        get
        {
            return "插入排序";
        }
    }   

    protected override void sort(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j > 0 && nums[j]<nums[j-1]; j--)
            {
                swap(nums,j,j-1);
            }
        }
    }
}
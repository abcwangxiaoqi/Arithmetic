/*
快速排序
*/
using System;

public class QuickSort : SortBase
{
    override public string Name
    {
        get
        {
            return "快速排序";
        }
    }

    override protected void sort(int[] nums)
    {
        quicksort(nums, 0, nums.Length - 1);
    }

    void quicksort(int[] nums, int _left, int _right)
    {
        int temp = 0;
        int left = _left;
        int right = _right;

        if (left <= right)
        {
            temp = nums[left];
            while (left != right)
            {
                #region 找出右边第一个小于基准元素的值 并进行替换
                while (right > left && nums[right] >= temp)
                {
                    right--;
                }
                nums[left] = nums[right];
                #endregion

                #region 找出左边第一个大于基准元素的值 并进行替换
                while (left < right && nums[left] <= temp)
                {
                    left++;
                }
                nums[right] = nums[left];
                #endregion
            }
            nums[left] = temp;
            quicksort(nums, _left, left - 1);
            quicksort(nums, right + 1, _right);
        }
    }
}
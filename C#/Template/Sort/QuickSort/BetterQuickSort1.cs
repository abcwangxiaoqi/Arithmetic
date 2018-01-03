
using System;

/*
优化快速排序（随机选取基准）
 */

public class BetterQuickSort1 : SortBase
{
    Random random;
    public BetterQuickSort1()
    {
        random=new Random();  
    }

    override public string Name
    {
        get
        {
            return "优化快速排序（随机选取基准）";
        }
    }

    override protected void sort(int[] nums)
    {
        quicksort(nums,0,nums.Length-1);
    }


    int SelectPivotRandom(int[] nums,int low,int high)  
    {  
        //随机产生枢轴的位置    
        int pivotPos=random.Next(low,high+1);

        //把枢轴位置的元素和low位置元素互换，此时可以和普通的快排一样调用划分函数        
        swap(nums,pivotPos,low);
        return nums[low];  
    }  
    
    void quicksort(int[] nums, int _left, int _right)
    {
        int temp = 0;
        int left = _left;
        int right = _right;

        if (left <= right)
        {
            SelectPivotRandom(nums,_left,_right);
            temp = nums[_left];
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
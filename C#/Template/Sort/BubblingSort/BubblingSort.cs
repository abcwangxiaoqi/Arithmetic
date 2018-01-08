/*
冒泡排序
从数组的第一个元素`arr[0]`开始，两两比较**(`arr[n],arr[n+1]`)，
如果前面的数大于后面的数（`arr[n] > arr[n+1]`）,那么交换两个元素的位置，
把大的数往后移动。这样依次经过一轮比较以后，最大的数将会被交换到最后的位置（arr[n-1]）。

选择排序每次只比较一次，和选择排序比较冒泡排序交换次数多，所以效率更低
但冒泡可以在第一次坚持数据是否有序，如果有序就不进行后续操作。

效率：
最好情况 第一次就发现有序 退出排序 复杂度为  O（n）
平均复杂度为 O（n^2）
 */
using System;

public class BubblingSort : SortBase
{

    override public string Name
    {
        get
        {
            return "冒泡排序";
        }
    }   

    protected override void sort(int[] nums)
    {
        bool need=false;
        for (int i = 0; i < nums.Length; i++)
        {
            //找出当前最大的放在最后
            for (int j = 0; j < nums.Length-i-1; j++)
            {
                if(nums[j]>nums[j+1])
                {
                    need=true;
                    swap(nums,j,j+1);
                }
            }

            //如果第一次有序则退出比较
            if(!need)
            {
                break;
            }
        }
    }
}
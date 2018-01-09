using System;
/*
折半搜索，也称二分查找算法、二分搜索，是一种在有序数组中查找某一特定元素的搜索算法

1,2,3,4,5,6,7,8,9,10,11,12,13,14 查找8的位置索引

效率 O(logn)
 */
public class BinarySearch:SearchBase
{
    public override int find(int[] nums,int target)
    {
        return findIndex(nums,0,nums.Length-1,target);
    }

    int findIndex(int[] nums,int low,int height,int target)
    {
        int index=-1;
        if(low>height)
        {
            return index;
        }

        int mid=(height+low)/2;

        if(nums[mid]==target)
        {
            return mid;
        }
        else if(nums[mid]>target)
        {
            return findIndex(nums,low,mid-1,target);
        }
        else
        {
            return findIndex(nums,mid+1,height,target);
        }
    }
}
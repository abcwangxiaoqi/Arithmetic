/*
希尔排序

 */
using System;
public class ShellSort : SortBase
{
    public override string Name
    {
        get
        {
            return "希尔排序";
        }
    }

    protected override void sort(int[] nums)
    {
        int len=nums.Length;
        int h=1;

        while(h<len/3)
        {
            h=3*h+1;
        }

        while(h>=1)
        {
            for(int i=h;i<len;i++)
            {
                for(int j=i;j>=h && (nums[j-h]>nums[j]);j-=h)
                {
                    swap(nums,j,j-h);
                }
            }
            h=h/3;
        }
    }
}
using System;
public abstract class SortBase
{
    public long run(int[] nums)
    {
        Tools.start();
        //计算时间
        sort(nums);

        long t=Tools.end();

        Console.WriteLine(outString(nums));

        return t;
    }

    public abstract string Name{get;}
    protected abstract void sort(int[] nums);

    protected void swap(int[] nums,int i,int j)
    {
        int tmp=nums[i];
        nums[i]=nums[j];
        nums[j]=tmp;
    }

    string outString(int[] nums)
    {
        string str="";
        int i=0;
        while(i<nums.Length)
        {
            str+=nums[i]+",";
            i++;
        }  

        return str;      
    }
}
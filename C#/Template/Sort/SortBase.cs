public abstract class SortBase
{
    public long run(int[] nums)
    {
        Tools.start();
        //计算时间
        sort(nums);


        return Tools.end();
    }

    public abstract string Name{get;}
    protected abstract void sort(int[] nums);

    protected void swap(int[] nums,int i,int j)
    {
        int tmp=nums[i];
        nums[i]=nums[j];
        nums[j]=tmp;
    }

    protected string outString(int[] nums)
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
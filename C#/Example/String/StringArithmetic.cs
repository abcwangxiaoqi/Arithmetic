using System;
using System.Collections;
using System.Collections.Generic;

public sealed class StringArithmetic
{
    /*
    查找子字符串 索引位置
     */
    public static int subString(string main, string sub)
    {
        int index = -1;
        int mainL = main.Length;
        int subL = sub.Length;

        if (subL > mainL)
        {
            return index;
        }

        char[] mainChar = main.ToCharArray();
        char[] subChar = sub.ToCharArray();

        for (int i = 0; i < mainL - subL + 1; i++)
        {
            if (mainChar[i] == subChar[0] &&
            mainL-i>=subL &&
            main.Substring(i, subL) == sub)
            {
                index = i;
                break;
            }
        }

        return index;
    }


    /*找出字符串中不重复字符串最大的长度
    #算法思想
    #定义一个 起始指针start，定义一个结束指针end，start和end之间作为最优解的数组
    #过程：end指针向后走，如果遇到重复字符串则停止，计算得出最优解，然后start指针指向重复数字的后一位，end继续向后走，以次轮询最后得出最优解
    #核心思想：贪心算法
    */
    public static int lengthOfLongestSubstring(string str)
    {
        int len=0;
        int start=0;//起始扫描指针
        
        Dictionary<char,int> map=new Dictionary<char,int>();

        int strLen=str.Length;
        char[] strChar=str.ToCharArray();

        for (int i = 0; i < strLen; i++)
        {
            //陷阱：重新开始扫描的位置 start要小于map里面记录的标记 否则start位置错误
            if(map.ContainsKey(strChar[i]) && start<=map[strChar[i]])
            {
                //得出重复字符串，start指针指向重复字符串的后一位
                start=map[strChar[i]]+1;   
            }
            else
            {
                //得出最优解的长度
                len=Math.Max(len,i-start+1);
            }

            //记录扫描过的字符串
            if(!map.ContainsKey(strChar[i]))
            {
                map.Add(strChar[i],i);                
            }
            else
            {
                map[strChar[i]]=i;
            }
        }

        return len;
    }


    //最长共用前缀字符串
    public static string longestCommonPrefix(string[] str)
    {
        if(str==null || str.Length==0)
        {
            return null;
        }

        string common=str[0];//首字符串作为前缀

        for (int i = 0; i < str.Length; i++)
        {
            string tmp=str[i];

            //确定每个字符串的共有前缀
            while(common.Length>0)
            {
                if(tmp.StartsWith(common))
                {
                    //确定共有前缀 跳出循环
                    break;
                }
                else
                {
                    common=common.Substring(0,common.Length-1);
                }
            }
        }

        return common;        
    }
}
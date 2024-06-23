using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3;

public class TaskFirst
{
    public int SeriaSize(int[] arr)
    {
        int k = 0;
        int max = 0;

        for(int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] == arr[i])
            {
                k++;
            }
            else
            {
                if(k > max)
                {
                    max = k;
                    k = 0;
                }
            }
        }

        if (k > max)
        {
            max = k;
        }
        if(max == 0) { return 0; }
        return max + 1;
    }

    public int SeriaIndex(int[] arr)
    {
        int k = 0;
        int index = 0;
        int b = 0;

        int s = SeriaSize(arr) - 1;
        if (s  > 0)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                b = i;
                if (arr[i + 1] == arr[i])
                {
                    k++;
                }
                else
                {
                    if(k == s)
                    {
                        index = i - k;
                        k = 0;
                    }
                }
            }
            if (k == s)
            {
                index = b - k;
                k = 0;
            }
        }
        else return 0;
        return index;
    }
    
    
    //public int SeriaSize(int[][] arr)
    //{
    //    int k = 0;
    //    int max = 0;

    //    for (int i = 0; i < arr.Length; i++)
    //        for (int j = 0; j < arr[i].Length; j++)
    //        {
    //            if (arr[i + 1][j] == arr[i][j])
    //            {
    //                k++;
    //            }
    //            else
    //            {
    //                if(k > max)
    //                {
    //                    max = k;
    //                    k = 0;
    //                }
    //            }
    //    }

    //    return max;
    //}

    //public int SeriaIndex(int[][] arr)
    //{
    //    int k = 0;
    //    int index = 0;

    //    if (SeriaSize(arr) > 0)
    //    {
    //        for (int i = 0; i < arr.Length - 1; i++)
    //        {
    //            for (int j = 0; j < arr[i].Length; j++)
    //            {
    //                if (arr[i + 1][j] == arr[i][j])
    //                {
    //                    k++;
    //                }
    //                else
    //                {
    //                    if (k == SeriaSize(arr))
    //                    {
    //                        index = i - k;
    //                    }
    //                }
    //            }
    //        }
    //    }
    //    else return 0;

    //    return index;
    //}
}

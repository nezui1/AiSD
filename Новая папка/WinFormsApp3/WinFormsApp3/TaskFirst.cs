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
            if (arr[i] != 0 && arr[i + 1] % arr[i] == 0)
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
                if (arr[i] == 0)
                {
                    i++;
                    if (i == arr.Length - 1) break;
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
        int index = 0;
        int k = 0;
        int s = SeriaSize(arr) - 1;
        if (s > 0)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i + 1] % arr[i] == 0 && arr[i] != 0)
                {
                    k++;
                }
                else
                {
                    if (k == s)
                    {
                        index = i - s;
                        k = 0;
                    }
                    if (arr[i] == 0)
                    {
                        i++;
                        if (i == arr.Length - 1) { break; }
                    }


                }
            }
        }
        else return 0;
            
        if(k == s)
        {
            index = arr.Length - 1 - s;
        }
        return index;
    }
}

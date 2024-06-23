using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3;

public class TaskSecond
{
    public int SearchMax(int[] arr)
    {
        int max = -100000;
        int k = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max && arr[i] < 0)
            {
                max = arr[i];
                k = i;
            }
        }
        return k;
    }


    public int SearchMin(int[] arr)
    {
        int min = 100000;
        int k = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min && arr[i] >= 0)
            {
                min = arr[i];
                k = i;
            }
        }
        return k;
    }

    public void PermutationElement(int[] arr)
{
    int sMax = SearchMax(arr);
    int sMin = SearchMin(arr);

    if (sMax > sMin)
    {
            int d = sMax - 1;
            
        for (int i = sMin + 1; i < d; i++, d--)
        {
            int temp = arr[i];
            arr[i] = arr[d];
            arr[d] = temp;
        }
    }
    else
    {
            int e = sMin - 1;
            for (int i = sMax + 1; i < e; i++, e--)
        {
            int temp = arr[i];
            arr[i] = arr[e];
            arr[e] = temp;
        }
    }
}


}

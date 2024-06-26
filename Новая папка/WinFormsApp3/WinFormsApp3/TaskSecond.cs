using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3;

public class TaskSecond
{
    
    public void PermutationElement(int[] arr)
    {
        int sMax = arr[0];
        int sMin = arr[0];
        int indexMin = 0;
        int indexMax = 0;
        int d = 0;
        int e = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > sMax)
            {
                sMax = arr[i];
                indexMax = i;
            }
            if (arr[i] < sMin)
            {
                sMin = arr[i];
                indexMin = i;
            }
        }


        if (indexMax > indexMin)
        {
            d = indexMax - 1;
            e = indexMin + 1;
        }
        else
        {
            d = indexMin - 1;
            e = indexMax + 1;
        }

        for(int i = e;  i < d; i++, d--) 
        {
            int temp = arr[i];
            arr[i] = arr[d];
            arr[d] = temp;
        }
    }


}

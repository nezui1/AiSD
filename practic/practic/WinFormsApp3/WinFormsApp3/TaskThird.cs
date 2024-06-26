using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3;

public class TaskThird
{
    public int countForThird;
    public int[] InsertTwo(int[] arr, int size)
    {
        int count = 0; 
        int l = 0;
        countForThird = size;
        for (int i = 0; i < arr.Length; i++)
        {
            count++;
            if (arr[i] % 2 == 0)
            {
                l++; 
                for (int k = size + l - 1; k > count; k--) 
                {
                    arr[k] = arr[k - 1];
                }
                arr[count] = 2;
                countForThird++;
                count++;
                i++;
            }
        }
        return arr;
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3;

public class TaskFourth
{
    public int countForFouth;
    public int[] DelArr(int[] arr)
    {
        countForFouth = arr.Length; 
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 ==  0)
            {
                for (int k = i; k < countForFouth - 1; k++)
                {
                    arr[k] = arr[k + 1];
                }
                countForFouth--;
                i--;
            }
        }
        return arr;
    }

}

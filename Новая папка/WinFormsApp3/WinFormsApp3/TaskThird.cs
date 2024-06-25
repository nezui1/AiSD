using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3;

public class TaskThird
{
    public void InsertTwo(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length / 2 + count; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
                for(int j = i + 1; j < arr.Length / 2 + count; j++)
                {
                    arr[j + 1] = arr[j];
                    j++;
                }
                arr[i + 1] = 2;
                i++;
            }
        }
    }


}

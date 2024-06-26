using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3;

public class TaskFifth
{
    public int countForFifth;
    public int[,] InsertNull(int[,] arr, int size)
    {
        countForFifth = size;
        int n = size;
        int m = size;
        int count = 0;
        int SrArifm = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (arr[i,j] >= 0)
                {
                    SrArifm += arr[i, j];
                    count++;
                }
                
            }
        }

        SrArifm = SrArifm / count;

        for (int j = 0; j < m; j++)
        {
            count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i, j] != 0)
                {
                    if (Math.Abs(arr[i, j]) >= SrArifm)
                    {
                        count++;
                    }
                }
            }
            if (count > 0)
            {
                for (int l = m; l > j; l--)
                {
                    for (int k = 0; k < n; k++)
                    {
                        arr[k, l] = arr[k, l - 1];
                    }
                }

                for (int k = 0; k < n; k++)
                {
                    arr[k, j + 1] = 0;
                }

                m++; 
                j++; 
                countForFifth++;
            }



        }


        return arr;
    }
}


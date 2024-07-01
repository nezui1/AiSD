using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5;

public class TaskThreeClassTwo : TaskThreeClassOne
{
    public virtual int Operation(int a, int b)
    {
        return (a + b) * (a + b);
    }
}

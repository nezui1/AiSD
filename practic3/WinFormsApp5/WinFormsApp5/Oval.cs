using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5;

public class Oval : Figure
{
    public Oval(double width, double height) : base(width, height)
    {
    }

    public override double Width { get ; set ; }
    public override double Height { get ; set ; }

    public override double Area()
    {
        return Math.Round(Math.PI * Width * Height, 2);
    }

    public override void DrawFigure(Graphics g, Pen pen)
    {
        g.DrawEllipse(pen, 0, 0, (int)Width, (int)Height);
    }

    public override double Perimeter()
    {
        double a = Width / 2.0;
        double b = Height / 2.0;
        return Math.Round(Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b))), 2);
    }

    public override string ToString()
    {
        return "Овал " + "Ширина: " + Width +
            " Высота: " + Height +
            " Площадь: " + Area() +
            " Периметр: " + Perimeter();
    }
}

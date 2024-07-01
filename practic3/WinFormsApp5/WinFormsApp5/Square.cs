using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5;

public class Square : Figure
{
    public Square(double width, double height) : base(width, height) { }

    public override double Width { get; set;}
    public override double Height { get ; set ; }

    public override double Area()
    {
        return Width * Width;
    }

    public override void DrawFigure(Graphics g, Pen pen)
    {
        SolidBrush brush = new SolidBrush(Color.Black);
        g.DrawRectangle(pen, 0, 0, (int)Width, (int)Width);
        g.FillRectangle(brush, 0, 0, (int)Width, (int)Width);
    }

    public override double Perimeter()
    {
        return Width * 4;
    }

    public override string ToString()
    {
        return "Прямоугольник " + "Ширина: " + Width +
            " Высота: " + Height +
            " Площадь: " + Area() +
            " Периметр: " + Perimeter();
    }
}

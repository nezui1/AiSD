using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5;

public abstract class Figure
{
    Random random = new Random();

    public abstract double Width { get; set; }
    public abstract double Height { get; set; }

    public int x;
    public int y;

    protected Bitmap bmp;

    protected Graphics g;

    public Figure(double width, double height)
    {
        Width = width;
        Height = height;
        x = random.Next(0,300);
        y = random.Next(0, 300);
        bmp = new Bitmap((int)Width, (int)Height);
        g = Graphics.FromImage(bmp);
    }

    public abstract double Area();
    public abstract double Perimeter();


    public void Draw(Graphics g)
    {
        Pen pen = new Pen(Color.Black, 2);
        DrawFigure(g, pen);
    }

    public abstract void DrawFigure(Graphics g, Pen pen);
}

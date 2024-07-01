using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5;

public class ClassTable
{

    private string material;

    private string color;

    private int height;

    private int length;

    private int width;

    public void SetMaterial(string material)
    {
        if (string.IsNullOrEmpty(material))
        {
            throw new ArgumentNullException("Введите материал");
        }
        this.material = material;
    }

    public string GetMaterial()
    {
        return material;
    }

    public void SetColor(string color)
    {
        if (string.IsNullOrEmpty(color))
        {
            throw new ArgumentNullException("Введите цвет");
        }
        this.color = color;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetHeight(int height)
    {
        if (height <= 0)
        {
            throw new ArgumentNullException("Введите высоту");
        }
        this.height = height;
    }
    public int GetHeight()
    {
        return height;
    }

    public void SetLength(int length)
    {
        if (length <= 0)
        {
            throw new ArgumentNullException("Введите длину");
        }

        this.length = length;
    }

    public int GetLenght()
    {
        return length;
    }

    public void SetWidth(int width)
    {
        if (width <= 0)
        {
            throw new ArgumentNullException("Введите ширину");
        }
        this.width = width;
    }

   public int GetWidth()
    {
        return width;
    }

    public override string ToString()
    {
        return "Материал: " + material +
            " Цвет: " + color +
            " Высота: " + height +
            " Ширина: " + width +
            " Длина: " + length;
    }

}

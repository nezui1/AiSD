using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp4;

public partial class Form1 : Form
{
    private int[] arr;

    private List<int[]> timSteps;

    private int n = 0;

    private string text;

    TaskFirst taskfirst = new TaskFirst();

    TaskSecond tasksecond = new TaskSecond();

    Random random = new Random();

    public Form1()
    {
        InitializeComponent();

        textBoxATD.Text = "� ����� ������� ������������ ��������, �������, ������� ��� �������� � ���� ��������� �����\r\n������ ��������� ��������� (LIFO � last in, first out, ��������� ������, ������ �����). � ��������� ����������� ����������\r\n�������. ����� ��������� ����������� ������ � ������, ����� ����� ������� �������� ���������. ��������, ���� ������� ������� ����� �� ���������� � ������������ �������, ����� ������ ������ � ����� ������� � �������, ���� ��� ������, ������� ��� ���� � ������� �� ��� �� ����������";

        textBoxSort.Text = "���������� ��������";
    }

    private void buttonAddElem_Click(object sender, EventArgs e)
    {
        taskfirst.Push(random.Next(-10, 10));
    }

    private void buttonOutputElem_Click(object sender, EventArgs e)
    {
        textBox1.Text = taskfirst.PrintElem();
    }

    private void buttonDelElemAtd_Click(object sender, EventArgs e)
    {
        taskfirst.Pop();
    }

    private void buttonGenerationArray_Click(object sender, EventArgs e)
    {
        arr = new int[10];

        text = "";

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(-10, 10);
            text += arr[i] + " ";
        }

        textBoxArray.Text = text;
    }

    private void buttonSort_Click(object sender, EventArgs e)
    {
        tasksecond.Sort(arr);
        timSteps = tasksecond.GetSortingSteps();
    }

    private void buttonStep_Click(object sender, EventArgs e)
    {
        if (n < timSteps.Count)
        {
            int[] currentStep = timSteps[n];
            string stepText = string.Join(" ", currentStep);
            textBoxArraySortAlgoritm.Text = stepText;
            n++;
        }
        else
        {
            textBoxArraySortAlgoritm.Text = "���������� ���������.";
        }






    }
}



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

        textBoxATD.Text = "В стеке порядок расположения обратный, элемент, который был добавлен в стек последним будет\r\nпервым элементом структуры (LIFO – last in, first out, последним пришел, первым вышел). В остальном ограничения аналогичны\r\nочереди. Такие структуры применяются только в случае, когда важен порядок хранения элементов. Например, если имеется очередь задач на выполнение в операционной системе, новые задачи встают в конец очереди и ожидают, пока все задачи, которые уже были в очереди до них не выполнятся";

        textBoxSort.Text = "сортировка слиянием";
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
            textBoxArraySortAlgoritm.Text = "Сортировка завершена.";
        }






    }
}



namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private int[,] arr2d;
        private int[] arr;
        string text = "";

        Random rand = new Random();

        TaskFirst taskfirst = new TaskFirst();
        TaskSecond tasksecond = new TaskSecond();
        TaskThird taskthird = new TaskThird();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonArray1D_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxArrayOutput.Text))
            {
                textBoxArrayOutput.Clear();

                string text = "";

                arr = new int[(int)numericUpDownSizeArray.Value];

                int min = (int)numericUpDownRangeMin.Value;

                int max = (int)numericUpDownRangeMax.Value;

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(min, max);
                    text += arr[i] + " ";
                }

                textBox2.Clear();
                textBoxTextTask.Clear();

                textBoxArrayOutput.Text = text;
            }
            else
            {
                arr = new int[(int)numericUpDownSizeArray.Value];
                string[] str = textBoxArrayOutput.Text.Split(" ");

                for (int i = 0; i < (int)numericUpDownSizeArray.Value; i++)
                {
                    arr[i] = int.Parse(str[i]);
                }
                for (int i = 0; i < (int)numericUpDownSizeArray.Value; i++)
                {
                    text += arr[i] + " ";
                }
                textBoxArrayOutput.Text = text;
            }
        }

        private void ButtonArray2D_Click(object sender, EventArgs e)
        {
            string text = "";

            arr2d = new int[(int)numericUpDownSizeArray2Dline.Value, (int)numericUpDownSizeArray2Drow.Value];

            int min = (int)numericUpDownRangeMin.Value;

            int max = (int)numericUpDownRangeMax.Value;

            for (int i = 0; i < (int)numericUpDownSizeArray2Dline.Value; i++)
            {
                for (int j = 0; j < (int)numericUpDownSizeArray2Drow.Value; j++)
                {
                    arr2d[i, j] = rand.Next(min, max);
                    text += arr2d[i, j] + "  ";
                }
                text += "\r\n";
            }

            textBoxArrayOutput.Text = text;
        }

        private void ButtonTaskFirst_Click(object sender, EventArgs e)
        {
            int index = 0;
            int size = 0;

            textBoxTextTask.Text = "Дан целочисленный одномерный массив размера N. Серия – это последовательность элементов массива, идущих друг за другом. Каждый элемент серии делился нацело на предыдущий. Серия должна содержать минимум 2 элемента. Длина серии – количество элементов в серии. Найти серию с максимальной длиной. Вывести с какой позиции начинается серия и ее длину.";

            if (arr == null)
            {
                text = "Длина серии: " + index + " " + "Индекс:  " + size;
            }

            else
            {
                size = taskfirst.SeriaSize(arr);
                index = taskfirst.SeriaIndex(arr);
                text = "Длина серии: " + size + " " + "Индекс:  " + index;
            }
        }

        private void ButtonTaskSecond_Click(object sender, EventArgs e)
        {
            text = "";
            textBoxTextTask.Text = "Дан целочисленный одномерный массив размера N. Переставить в обратном порядке элементы массива, расположенные между его минимальным и максимальным элементами";

            tasksecond.PermutationElement(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                text += arr[i] + " ";
            }

        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Text = text;

        }

        private void buttonTaskThird_Click(object sender, EventArgs e)
        {
            text = "";
            int size = (int)numericUpDownSizeArray.Value * 2;
            int[] arr3t = new int[size];
            for(int i = 0; i < arr.Length; i++)
            {
                arr3t[i] = arr[i];
            }

            taskthird.InsertTwo(arr3t);

              
            for (int i = 0; i < arr3t.Length; i++)
            {
                text += arr3t[i] + " ";
            }

        }
    }
}

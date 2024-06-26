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
        TaskFourth taskfourth = new TaskFourth();
        TaskFifth taskfifth = new TaskFifth();

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

            if (string.IsNullOrEmpty(textBoxArrayOutput.Text))
            {
                text = "";

                arr2d = new int[(int)numericUpDownSizeArray2Dline.Value * 2, (int)numericUpDownSizeArray2Drow.Value * 2];

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
            else
            {
                arr2d = new int[(int)numericUpDownSizeArray2Dline.Value, (int)numericUpDownSizeArray2Drow.Value];
                string[] str = textBoxArrayOutput.Text.Split();
                int j = 0;
                int count = 0;
                for (int i = 0; i < (int)numericUpDownSizeArray2Dline.Value; i++)
                {
                    arr2d[i, j] = int.Parse(str[count]);
                    count++;
                    if (count == (int)numericUpDownSizeArray2Drow.Value)
                    {
                        j++;
                        count = 0; 
                    }
                }



                for (int i = 0; i < (int)numericUpDownSizeArray2Dline.Value; i++)
                {
                    for(int k = 0; k < (int)numericUpDownSizeArray2Drow.Value; k++)
                    {
                        text += arr2d[i, j] + " ";
                    }
                    text += "\r\n";
                }
                textBoxArrayOutput.Text = text;
            }
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
            arr = new int[size];

            string[] str = textBoxArrayOutput.Text.Split(" ");

            for (int i = 0; i < (int)numericUpDownSizeArray.Value; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            for (int i = (int)numericUpDownSizeArray.Value; i < arr.Length; i++)
            {
                arr[i] = -3;
            }
            for (int i = 0; i < (int)numericUpDownSizeArray.Value; i++)
            {
                text += arr[i] + " ";
            }
            textBoxArrayOutput.Text = text;

            textBoxTextTask.Text = "Дан целочисленный одномерный массив размера N. Вставить 2 после каждого четного элемента массива (четный по значению, а не по порядковому номеру).";

            text = "";

            arr = taskthird.InsertTwo(arr, (int)numericUpDownSizeArray.Value);

            int n = taskthird.countForThird;


            for (int i = 0; i < n; i++)
            {
                text += arr[i] + " ";
            }


        }

        private void buttonTaskFourth_Click(object sender, EventArgs e)
        {
            text = "";

            arr = taskfourth.DelArr(arr);

            int size = taskfourth.countForFouth;

            textBoxTextTask.Text = "Дан целочисленный одномерный массив размера N. Удалить из массива все четные элементы (четный по значению, а не по порядковому номеру).";

            for (int i = 0; i < size; i++)
            {
                text += arr[i] + " ";
            }
        }

        private void buttonTaskFifth_Click(object sender, EventArgs e)
        {
            text = "";

            arr2d = taskfifth.InsertNull(arr2d, (int)numericUpDownSizeArray2Dline.Value);

            int sizeArr = taskfifth.countForFifth;

            for(int i = 0; i < (int)numericUpDownSizeArray2Dline.Value; i++)
            {
                for(int j = 0; j < sizeArr; j++)
                {
                    text += arr2d[i , j] + " ";
                }
                text += "\r\n";
            }
        }
    }
}

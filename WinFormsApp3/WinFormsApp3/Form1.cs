namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private int[,] arr2d;
        private int[] arr;

        Random rand = new Random();

        TaskFirst taskfirst = new TaskFirst();
        TaskSecond tasksecond = new TaskSecond();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonArray1D_Click(object sender, EventArgs e)
        {

            string text = "";

            arr = new int[(int)numericUpDownSizeArray.Value];

            int min = (int)numericUpDownRangeMin.Value;

            int max = (int)numericUpDownRangeMax.Value;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(min, max);
                text += arr[i] + " ";
            }



            textBoxArrayOutput.Text = text;
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

            textBoxTextTask.Text = "Дан целочисленный одномерный массив размера N. Серия – это последовательность элементов массива, идущих друг за другом. Значения всех элементов серии одинаково. Серия должна содержать минимум 2 элемента. Длина серии – количество элементов в серии Найти все серии. Вывести информацию с указанием длины для каждой серий исходного массива.";

            if (arr == null)
            {
                textBox2.Text = "Длина серии: " + index + " " + "Индекс:  " + size;
            }

            else
            {
                size = taskfirst.SeriaSize(arr);
                index = taskfirst.SeriaIndex(arr);
                textBox2.Text = "Длина серии: " + size + " " + "Индекс:  " + index;
            }
        }

        private void ButtonTaskSecond_Click(object sender, EventArgs e)
        {
            textBoxTextTask.Text = "Дан целочисленный одномерный массив размера N. Переставить в обратном порядке элементы массива, расположенные между наибольшим отрицательным и наименьшим положительным.";

            tasksecond.PermutationElement(arr);

        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            for(int i = 0; i < arr.Length; i++)
            {
                textBox2.Text += arr[i] + " ";
            }
              
        }
        

    }
}

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private List<ClassTable> list;
        private List<Figure> figures;
        TaskThreeClassOne taskThreeClassOne;
        TaskThreeClassTwo taskThreeClassTwo;

        public Form1()
        {
            InitializeComponent();

            list = new List<ClassTable>();

            figures = new List<Figure>();

            taskThreeClassOne = new TaskThreeClassOne();

            taskThreeClassTwo = new TaskThreeClassTwo();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ClassTable table = new ClassTable();
                table.SetMaterial(textBoxMaterial.Text);
                table.SetColor(textBoxColor.Text);
                table.SetHeight(Convert.ToInt32(numericUpDownHeight.Value));
                table.SetWidth(Convert.ToInt32(numericUpDownWidth.Value));
                table.SetLength(Convert.ToInt32(numericUpDownLength.Value));
                list.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Œ¯Ë·Í‡", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {

            listBoxObj.Items.Clear();
            foreach (object table in list)
                listBoxObj.Items.Add(table.ToString());

        }

        private void buttonCreateFigureSquare_Click(object sender, EventArgs e)
        {
            Square figure = new Square(Convert.ToInt32(numericUpDownHeightFigure.Value), Convert.ToInt32(numericUpDownWidthFigure.Value));
            figures.Add(figure);
            listBoxFigure.Items.Add(figure);
            buttonDraw.Enabled = true;
        }

        private void buttonCreateOval_Click(object sender, EventArgs e)
        {
            Oval figure = new Oval(Convert.ToInt32(numericUpDownHeightFigure.Value), Convert.ToInt32(numericUpDownWidthFigure.Value));
            figures.Add(figure);
            listBoxFigure.Items.Add(figure);
            buttonDraw.Enabled = true;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {


            if (listBoxFigure.SelectedItem is Square square)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                square.Draw(g);
                pictureBox1.Image = bmp;
            }
            else if (listBoxFigure.SelectedItem is Oval oval)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                oval.Draw(g);
                pictureBox1.Image = bmp;
            }

        }










        private void buttonMulty_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDownA.Value);
            int b = Convert.ToInt32(numericUpDownB.Value);

            if (taskThreeClassOne != null)
            {
                textBoxOper.Text = taskThreeClassOne.Operation(a, b).ToString();
            }
        }

        private void buttonMulty2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDownA.Value);
            int b = Convert.ToInt32(numericUpDownB.Value);

            if (taskThreeClassTwo != null)
            {
                textBoxOper.Text = taskThreeClassTwo.Operation(a, b).ToString();
            }
        }

    }
}

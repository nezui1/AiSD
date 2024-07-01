namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDownPrisions.Value;
            int y = (int)numericUpDownYears.Value;
            int coloumnIndex = 0;
            

            while (x <= 15000)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[coloumnIndex].Cells[0].Value = x.ToString();
                coloumnIndex++;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[coloumnIndex].Cells[1].Value = ((x / 100) * 5).ToString();
                x += (x / 100) * 5;
                coloumnIndex++;
                
                dataGridView1.Rows.Add();
                dataGridView1.Rows[coloumnIndex].Cells[0].Value = x.ToString();
                coloumnIndex++;

                
                dataGridView1.Rows.Add();
                dataGridView1.Rows[coloumnIndex].Cells[3].Value = y.ToString();
                y++;
                coloumnIndex++;

                if (x > 15000) break;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[coloumnIndex].Cells[0].Value = x.ToString();
                coloumnIndex++;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[coloumnIndex].Cells[1].Value = ((x / 100) * 5).ToString();
                x += (x / 100) * 5;
                coloumnIndex++;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[coloumnIndex].Cells[0].Value = x.ToString();
                coloumnIndex++;


                
                dataGridView1.Rows.Add();
                dataGridView1.Rows[coloumnIndex].Cells[2].Value = ((x / 100) * 6).ToString();
                x -= (x / 100) * 6;
                coloumnIndex++;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[coloumnIndex].Cells[0].Value = x.ToString();
                coloumnIndex++;

                
                dataGridView1.Rows.Add();
                dataGridView1.Rows[coloumnIndex].Cells[3].Value = y.ToString();
                y++;
                coloumnIndex++;

                
            }
        }
    }
}

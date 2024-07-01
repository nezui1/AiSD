namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            CountPrisoners = new DataGridViewTextBoxColumn();
            Upper = new DataGridViewTextBoxColumn();
            Down = new DataGridViewTextBoxColumn();
            Years = new DataGridViewTextBoxColumn();
            numericUpDownPrisions = new NumericUpDown();
            labelPrisions = new Label();
            numericUpDownYears = new NumericUpDown();
            labelYears = new Label();
            buttonStart = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrisions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYears).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CountPrisoners, Upper, Down, Years });
            dataGridView1.Location = new Point(2, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 447);
            dataGridView1.TabIndex = 0;
            // 
            // CountPrisoners
            // 
            CountPrisoners.HeaderText = "Кол-во арестантов";
            CountPrisoners.Name = "CountPrisoners";
            // 
            // Upper
            // 
            Upper.HeaderText = "Прибавляется";
            Upper.Name = "Upper";
            // 
            // Down
            // 
            Down.HeaderText = "Убывает";
            Down.Name = "Down";
            // 
            // Years
            // 
            Years.HeaderText = "Год";
            Years.Name = "Years";
            // 
            // numericUpDownPrisions
            // 
            numericUpDownPrisions.Location = new Point(481, 36);
            numericUpDownPrisions.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            numericUpDownPrisions.Name = "numericUpDownPrisions";
            numericUpDownPrisions.Size = new Size(120, 23);
            numericUpDownPrisions.TabIndex = 1;
            // 
            // labelPrisions
            // 
            labelPrisions.AutoSize = true;
            labelPrisions.Location = new Point(607, 44);
            labelPrisions.Name = "labelPrisions";
            labelPrisions.Size = new Size(110, 15);
            labelPrisions.TabIndex = 2;
            labelPrisions.Text = "Кол-во арестантов";
            // 
            // numericUpDownYears
            // 
            numericUpDownYears.Location = new Point(481, 90);
            numericUpDownYears.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDownYears.Name = "numericUpDownYears";
            numericUpDownYears.Size = new Size(120, 23);
            numericUpDownYears.TabIndex = 3;
            numericUpDownYears.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // labelYears
            // 
            labelYears.AutoSize = true;
            labelYears.Location = new Point(616, 98);
            labelYears.Name = "labelYears";
            labelYears.Size = new Size(26, 15);
            labelYears.TabIndex = 4;
            labelYears.Text = "Год";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(481, 156);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStart);
            Controls.Add(labelYears);
            Controls.Add(numericUpDownYears);
            Controls.Add(labelPrisions);
            Controls.Add(numericUpDownPrisions);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrisions).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYears).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CountPrisoners;
        private DataGridViewTextBoxColumn Upper;
        private DataGridViewTextBoxColumn Down;
        private DataGridViewTextBoxColumn Years;
        private NumericUpDown numericUpDownPrisions;
        private Label labelPrisions;
        private NumericUpDown numericUpDownYears;
        private Label labelYears;
        private Button buttonStart;
    }
}

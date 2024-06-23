namespace WinFormsApp3
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
            panelTask = new Panel();
            buttonTaskSixth = new Button();
            buttonTaskFifth = new Button();
            buttonTaskFourth = new Button();
            buttonTaskThird = new Button();
            buttonTaskSecond = new Button();
            buttonTaskFirst = new Button();
            panel1 = new Panel();
            numericUpDownSizeArray2Drow = new NumericUpDown();
            numericUpDownSizeArray2Dline = new NumericUpDown();
            labelSizeArray2D = new Label();
            labelRangeMax = new Label();
            numericUpDownRangeMax = new NumericUpDown();
            labelRange = new Label();
            numericUpDownRangeMin = new NumericUpDown();
            labelSizeArray1D = new Label();
            numericUpDownSizeArray = new NumericUpDown();
            buttonArray2D = new Button();
            buttonArray1D = new Button();
            textBoxArrayOutput = new TextBox();
            panelTextTask = new Panel();
            textBoxTextTask = new TextBox();
            panelArrayResult = new Panel();
            buttonOutput = new Button();
            textBox2 = new TextBox();
            panelTask.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSizeArray2Drow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSizeArray2Dline).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRangeMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRangeMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSizeArray).BeginInit();
            panelTextTask.SuspendLayout();
            panelArrayResult.SuspendLayout();
            SuspendLayout();
            // 
            // panelTask
            // 
            panelTask.Controls.Add(buttonTaskSixth);
            panelTask.Controls.Add(buttonTaskFifth);
            panelTask.Controls.Add(buttonTaskFourth);
            panelTask.Controls.Add(buttonTaskThird);
            panelTask.Controls.Add(buttonTaskSecond);
            panelTask.Controls.Add(buttonTaskFirst);
            panelTask.Location = new Point(12, 12);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(256, 92);
            panelTask.TabIndex = 0;
            // 
            // buttonTaskSixth
            // 
            buttonTaskSixth.Location = new Point(172, 46);
            buttonTaskSixth.Name = "buttonTaskSixth";
            buttonTaskSixth.Size = new Size(75, 23);
            buttonTaskSixth.TabIndex = 5;
            buttonTaskSixth.Text = "№6";
            buttonTaskSixth.UseVisualStyleBackColor = true;
            // 
            // buttonTaskFifth
            // 
            buttonTaskFifth.Location = new Point(91, 46);
            buttonTaskFifth.Name = "buttonTaskFifth";
            buttonTaskFifth.Size = new Size(75, 23);
            buttonTaskFifth.TabIndex = 4;
            buttonTaskFifth.Text = "№5";
            buttonTaskFifth.UseVisualStyleBackColor = true;
            // 
            // buttonTaskFourth
            // 
            buttonTaskFourth.Location = new Point(10, 46);
            buttonTaskFourth.Name = "buttonTaskFourth";
            buttonTaskFourth.Size = new Size(75, 23);
            buttonTaskFourth.TabIndex = 3;
            buttonTaskFourth.Text = "№4";
            buttonTaskFourth.UseVisualStyleBackColor = true;
            // 
            // buttonTaskThird
            // 
            buttonTaskThird.Location = new Point(172, 17);
            buttonTaskThird.Name = "buttonTaskThird";
            buttonTaskThird.Size = new Size(75, 23);
            buttonTaskThird.TabIndex = 2;
            buttonTaskThird.Text = "№3";
            buttonTaskThird.UseVisualStyleBackColor = true;
            // 
            // buttonTaskSecond
            // 
            buttonTaskSecond.Location = new Point(91, 17);
            buttonTaskSecond.Name = "buttonTaskSecond";
            buttonTaskSecond.Size = new Size(75, 23);
            buttonTaskSecond.TabIndex = 1;
            buttonTaskSecond.Text = "№2";
            buttonTaskSecond.UseVisualStyleBackColor = true;
            buttonTaskSecond.Click += ButtonTaskSecond_Click;
            // 
            // buttonTaskFirst
            // 
            buttonTaskFirst.Location = new Point(10, 17);
            buttonTaskFirst.Name = "buttonTaskFirst";
            buttonTaskFirst.Size = new Size(75, 23);
            buttonTaskFirst.TabIndex = 0;
            buttonTaskFirst.Text = "№1";
            buttonTaskFirst.UseVisualStyleBackColor = true;
            buttonTaskFirst.Click += ButtonTaskFirst_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDownSizeArray2Drow);
            panel1.Controls.Add(numericUpDownSizeArray2Dline);
            panel1.Controls.Add(labelSizeArray2D);
            panel1.Controls.Add(labelRangeMax);
            panel1.Controls.Add(numericUpDownRangeMax);
            panel1.Controls.Add(labelRange);
            panel1.Controls.Add(numericUpDownRangeMin);
            panel1.Controls.Add(labelSizeArray1D);
            panel1.Controls.Add(numericUpDownSizeArray);
            panel1.Controls.Add(buttonArray2D);
            panel1.Controls.Add(buttonArray1D);
            panel1.Controls.Add(textBoxArrayOutput);
            panel1.Location = new Point(394, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 293);
            panel1.TabIndex = 1;
            // 
            // numericUpDownSizeArray2Drow
            // 
            numericUpDownSizeArray2Drow.Location = new Point(263, 189);
            numericUpDownSizeArray2Drow.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownSizeArray2Drow.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownSizeArray2Drow.Name = "numericUpDownSizeArray2Drow";
            numericUpDownSizeArray2Drow.Size = new Size(64, 23);
            numericUpDownSizeArray2Drow.TabIndex = 11;
            numericUpDownSizeArray2Drow.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // numericUpDownSizeArray2Dline
            // 
            numericUpDownSizeArray2Dline.Location = new Point(197, 189);
            numericUpDownSizeArray2Dline.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownSizeArray2Dline.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownSizeArray2Dline.Name = "numericUpDownSizeArray2Dline";
            numericUpDownSizeArray2Dline.Size = new Size(64, 23);
            numericUpDownSizeArray2Dline.TabIndex = 10;
            numericUpDownSizeArray2Dline.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // labelSizeArray2D
            // 
            labelSizeArray2D.AutoSize = true;
            labelSizeArray2D.Location = new Point(17, 191);
            labelSizeArray2D.Name = "labelSizeArray2D";
            labelSizeArray2D.Size = new Size(165, 15);
            labelSizeArray2D.TabIndex = 9;
            labelSizeArray2D.Text = "Размер двумерного массива";
            // 
            // labelRangeMax
            // 
            labelRangeMax.AutoSize = true;
            labelRangeMax.Location = new Point(3, 268);
            labelRangeMax.Name = "labelRangeMax";
            labelRangeMax.Size = new Size(258, 15);
            labelRangeMax.TabIndex = 8;
            labelRangeMax.Text = "Максимальное значение элемента в массиве";
            // 
            // numericUpDownRangeMax
            // 
            numericUpDownRangeMax.Location = new Point(263, 266);
            numericUpDownRangeMax.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownRangeMax.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDownRangeMax.Name = "numericUpDownRangeMax";
            numericUpDownRangeMax.Size = new Size(120, 23);
            numericUpDownRangeMax.TabIndex = 7;
            numericUpDownRangeMax.TextAlign = HorizontalAlignment.Center;
            numericUpDownRangeMax.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // labelRange
            // 
            labelRange.AutoSize = true;
            labelRange.Location = new Point(3, 236);
            labelRange.Name = "labelRange";
            labelRange.Size = new Size(254, 15);
            labelRange.TabIndex = 6;
            labelRange.Text = "Минимальное значение элемента в массиве";
            // 
            // numericUpDownRangeMin
            // 
            numericUpDownRangeMin.Location = new Point(263, 234);
            numericUpDownRangeMin.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownRangeMin.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDownRangeMin.Name = "numericUpDownRangeMin";
            numericUpDownRangeMin.Size = new Size(120, 23);
            numericUpDownRangeMin.TabIndex = 5;
            numericUpDownRangeMin.TextAlign = HorizontalAlignment.Center;
            numericUpDownRangeMin.Value = new decimal(new int[] { 10, 0, 0, int.MinValue });
            // 
            // labelSizeArray1D
            // 
            labelSizeArray1D.AutoSize = true;
            labelSizeArray1D.Location = new Point(17, 162);
            labelSizeArray1D.Name = "labelSizeArray1D";
            labelSizeArray1D.Size = new Size(174, 15);
            labelSizeArray1D.TabIndex = 4;
            labelSizeArray1D.Text = "Размер одномерного массива";
            // 
            // numericUpDownSizeArray
            // 
            numericUpDownSizeArray.Location = new Point(197, 160);
            numericUpDownSizeArray.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownSizeArray.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownSizeArray.Name = "numericUpDownSizeArray";
            numericUpDownSizeArray.Size = new Size(120, 23);
            numericUpDownSizeArray.TabIndex = 3;
            numericUpDownSizeArray.TextAlign = HorizontalAlignment.Center;
            numericUpDownSizeArray.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // buttonArray2D
            // 
            buttonArray2D.Location = new Point(271, 88);
            buttonArray2D.Name = "buttonArray2D";
            buttonArray2D.Size = new Size(119, 52);
            buttonArray2D.TabIndex = 2;
            buttonArray2D.Text = "Двумерный массив";
            buttonArray2D.UseVisualStyleBackColor = true;
            buttonArray2D.Click += ButtonArray2D_Click;
            // 
            // buttonArray1D
            // 
            buttonArray1D.Location = new Point(271, 17);
            buttonArray1D.Name = "buttonArray1D";
            buttonArray1D.Size = new Size(119, 52);
            buttonArray1D.TabIndex = 1;
            buttonArray1D.Text = "Одномерный массив";
            buttonArray1D.UseVisualStyleBackColor = true;
            buttonArray1D.Click += ButtonArray1D_Click;
            // 
            // textBoxArrayOutput
            // 
            textBoxArrayOutput.Location = new Point(17, 17);
            textBoxArrayOutput.Multiline = true;
            textBoxArrayOutput.Name = "textBoxArrayOutput";
            textBoxArrayOutput.Size = new Size(235, 137);
            textBoxArrayOutput.TabIndex = 0;
            // 
            // panelTextTask
            // 
            panelTextTask.Controls.Add(textBoxTextTask);
            panelTextTask.Location = new Point(394, 311);
            panelTextTask.Name = "panelTextTask";
            panelTextTask.Size = new Size(394, 127);
            panelTextTask.TabIndex = 2;
            // 
            // textBoxTextTask
            // 
            textBoxTextTask.Location = new Point(3, 3);
            textBoxTextTask.Multiline = true;
            textBoxTextTask.Name = "textBoxTextTask";
            textBoxTextTask.Size = new Size(387, 121);
            textBoxTextTask.TabIndex = 0;
            // 
            // panelArrayResult
            // 
            panelArrayResult.Controls.Add(buttonOutput);
            panelArrayResult.Controls.Add(textBox2);
            panelArrayResult.Location = new Point(394, 449);
            panelArrayResult.Name = "panelArrayResult";
            panelArrayResult.Size = new Size(394, 129);
            panelArrayResult.TabIndex = 3;
            // 
            // buttonOutput
            // 
            buttonOutput.Location = new Point(308, 3);
            buttonOutput.Name = "buttonOutput";
            buttonOutput.Size = new Size(75, 50);
            buttonOutput.TabIndex = 1;
            buttonOutput.Text = "Вывод массива";
            buttonOutput.UseVisualStyleBackColor = true;
            buttonOutput.Click += buttonOutput_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 123);
            textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 590);
            Controls.Add(panelArrayResult);
            Controls.Add(panelTextTask);
            Controls.Add(panel1);
            Controls.Add(panelTask);
            Name = "Form1";
            Text = "Form1";
            panelTask.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSizeArray2Drow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSizeArray2Dline).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRangeMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRangeMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSizeArray).EndInit();
            panelTextTask.ResumeLayout(false);
            panelTextTask.PerformLayout();
            panelArrayResult.ResumeLayout(false);
            panelArrayResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask;
        private Button buttonTaskSixth;
        private Button buttonTaskFifth;
        private Button buttonTaskFourth;
        private Button buttonTaskThird;
        private Button buttonTaskSecond;
        private Button buttonTaskFirst;
        private Panel panel1;
        private Button buttonArray2D;
        private Button buttonArray1D;
        private TextBox textBoxArrayOutput;
        private Label labelSizeArray1D;
        private NumericUpDown numericUpDownSizeArray;
        private Label labelRangeMax;
        private NumericUpDown numericUpDownRangeMax;
        private Label labelRange;
        private NumericUpDown numericUpDownRangeMin;
        private Panel panelTextTask;
        private TextBox textBoxTextTask;
        private Panel panelArrayResult;
        private TextBox textBox2;
        private Label labelSizeArray2D;
        private NumericUpDown numericUpDownSizeArray2Drow;
        private NumericUpDown numericUpDownSizeArray2Dline;
        private Button buttonOutput;
    }
}

namespace WinFormsApp4
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
            panelTaskFirst = new Panel();
            labelTask1 = new Label();
            textBox1 = new TextBox();
            buttonOutputElem = new Button();
            buttonAddElem = new Button();
            buttonDelElemAtd = new Button();
            labelATD = new Label();
            textBoxATD = new TextBox();
            panelTaskSecond = new Panel();
            buttonSort = new Button();
            textBoxArraySortAlgoritm = new TextBox();
            buttonStep = new Button();
            textBoxArray = new TextBox();
            buttonGenerationArray = new Button();
            label2 = new Label();
            label1 = new Label();
            textBoxSort = new TextBox();
            panelTaskThird = new Panel();
            panelTaskFirst.SuspendLayout();
            panelTaskSecond.SuspendLayout();
            SuspendLayout();
            // 
            // panelTaskFirst
            // 
            panelTaskFirst.Controls.Add(labelTask1);
            panelTaskFirst.Controls.Add(textBox1);
            panelTaskFirst.Controls.Add(buttonOutputElem);
            panelTaskFirst.Controls.Add(buttonAddElem);
            panelTaskFirst.Controls.Add(buttonDelElemAtd);
            panelTaskFirst.Controls.Add(labelATD);
            panelTaskFirst.Controls.Add(textBoxATD);
            panelTaskFirst.Location = new Point(12, 12);
            panelTaskFirst.Name = "panelTaskFirst";
            panelTaskFirst.Size = new Size(296, 426);
            panelTaskFirst.TabIndex = 0;
            // 
            // labelTask1
            // 
            labelTask1.AutoSize = true;
            labelTask1.Location = new Point(118, 0);
            labelTask1.Name = "labelTask1";
            labelTask1.Size = new Size(61, 15);
            labelTask1.TabIndex = 7;
            labelTask1.Text = "Задание 1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 336);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 23);
            textBox1.TabIndex = 6;
            // 
            // buttonOutputElem
            // 
            buttonOutputElem.Location = new Point(19, 292);
            buttonOutputElem.Name = "buttonOutputElem";
            buttonOutputElem.Size = new Size(255, 23);
            buttonOutputElem.TabIndex = 5;
            buttonOutputElem.Text = "Вывести элементы";
            buttonOutputElem.UseVisualStyleBackColor = true;
            buttonOutputElem.Click += buttonOutputElem_Click;
            // 
            // buttonAddElem
            // 
            buttonAddElem.Location = new Point(19, 189);
            buttonAddElem.Name = "buttonAddElem";
            buttonAddElem.Size = new Size(255, 23);
            buttonAddElem.TabIndex = 3;
            buttonAddElem.Text = "Добавить элемент";
            buttonAddElem.UseVisualStyleBackColor = true;
            buttonAddElem.Click += buttonAddElem_Click;
            // 
            // buttonDelElemAtd
            // 
            buttonDelElemAtd.Location = new Point(19, 240);
            buttonDelElemAtd.Name = "buttonDelElemAtd";
            buttonDelElemAtd.Size = new Size(255, 23);
            buttonDelElemAtd.TabIndex = 2;
            buttonDelElemAtd.Text = "Удалить элемент";
            buttonDelElemAtd.UseVisualStyleBackColor = true;
            buttonDelElemAtd.Click += buttonDelElemAtd_Click;
            // 
            // labelATD
            // 
            labelATD.AutoSize = true;
            labelATD.Location = new Point(19, 27);
            labelATD.Name = "labelATD";
            labelATD.Size = new Size(62, 15);
            labelATD.TabIndex = 1;
            labelATD.Text = "Описание";
            // 
            // textBoxATD
            // 
            textBoxATD.Location = new Point(19, 45);
            textBoxATD.Multiline = true;
            textBoxATD.Name = "textBoxATD";
            textBoxATD.Size = new Size(255, 112);
            textBoxATD.TabIndex = 0;
            // 
            // panelTaskSecond
            // 
            panelTaskSecond.Controls.Add(buttonSort);
            panelTaskSecond.Controls.Add(textBoxArraySortAlgoritm);
            panelTaskSecond.Controls.Add(buttonStep);
            panelTaskSecond.Controls.Add(textBoxArray);
            panelTaskSecond.Controls.Add(buttonGenerationArray);
            panelTaskSecond.Controls.Add(label2);
            panelTaskSecond.Controls.Add(label1);
            panelTaskSecond.Controls.Add(textBoxSort);
            panelTaskSecond.Location = new Point(314, 12);
            panelTaskSecond.Name = "panelTaskSecond";
            panelTaskSecond.Size = new Size(296, 426);
            panelTaskSecond.TabIndex = 1;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(22, 292);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(255, 23);
            buttonSort.TabIndex = 13;
            buttonSort.Text = "Отсортировать массив";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // textBoxArraySortAlgoritm
            // 
            textBoxArraySortAlgoritm.Location = new Point(22, 336);
            textBoxArraySortAlgoritm.Multiline = true;
            textBoxArraySortAlgoritm.Name = "textBoxArraySortAlgoritm";
            textBoxArraySortAlgoritm.Size = new Size(255, 23);
            textBoxArraySortAlgoritm.TabIndex = 12;
            // 
            // buttonStep
            // 
            buttonStep.Location = new Point(22, 365);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new Size(255, 23);
            buttonStep.TabIndex = 11;
            buttonStep.Text = "Шаг";
            buttonStep.UseVisualStyleBackColor = true;
            buttonStep.Click += buttonStep_Click;
            // 
            // textBoxArray
            // 
            textBoxArray.Location = new Point(22, 240);
            textBoxArray.Multiline = true;
            textBoxArray.Name = "textBoxArray";
            textBoxArray.Size = new Size(255, 23);
            textBoxArray.TabIndex = 10;
            // 
            // buttonGenerationArray
            // 
            buttonGenerationArray.Location = new Point(22, 189);
            buttonGenerationArray.Name = "buttonGenerationArray";
            buttonGenerationArray.Size = new Size(255, 23);
            buttonGenerationArray.TabIndex = 9;
            buttonGenerationArray.Text = "Сгенирировать массив";
            buttonGenerationArray.UseVisualStyleBackColor = true;
            buttonGenerationArray.Click += buttonGenerationArray_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "Задание 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Описание";
            // 
            // textBoxSort
            // 
            textBoxSort.Location = new Point(22, 45);
            textBoxSort.Multiline = true;
            textBoxSort.Name = "textBoxSort";
            textBoxSort.Size = new Size(255, 112);
            textBoxSort.TabIndex = 1;
            // 
            // panelTaskThird
            // 
            panelTaskThird.Location = new Point(616, 12);
            panelTaskThird.Name = "panelTaskThird";
            panelTaskThird.Size = new Size(296, 426);
            panelTaskThird.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 448);
            Controls.Add(panelTaskThird);
            Controls.Add(panelTaskSecond);
            Controls.Add(panelTaskFirst);
            Name = "Form1";
            Text = "Form1";
            panelTaskFirst.ResumeLayout(false);
            panelTaskFirst.PerformLayout();
            panelTaskSecond.ResumeLayout(false);
            panelTaskSecond.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTaskFirst;
        private Button buttonDelElemAtd;
        private Label labelATD;
        private TextBox textBoxATD;
        private Panel panelTaskSecond;
        private Panel panelTaskThird;
        private TextBox textBox1;
        private Button buttonOutputElem;
        private Button buttonAddElem;
        private Label labelTask1;
        private TextBox textBoxArraySortAlgoritm;
        private Button buttonStep;
        private TextBox textBoxArray;
        private Button buttonGenerationArray;
        private Label label2;
        private Label label1;
        private TextBox textBoxSort;
        private Button buttonSort;
    }
}

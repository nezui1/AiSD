namespace WinFormsApp5
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
            tabControlTaskFirst = new TabControl();
            tabPage1 = new TabPage();
            buttonOutput = new Button();
            buttonCreate = new Button();
            listBoxObj = new ListBox();
            labelWidth = new Label();
            numericUpDownWidth = new NumericUpDown();
            labelLength = new Label();
            numericUpDownLength = new NumericUpDown();
            labelHeight = new Label();
            numericUpDownHeight = new NumericUpDown();
            labelColor = new Label();
            textBoxColor = new TextBox();
            labelMaterial = new Label();
            textBoxMaterial = new TextBox();
            tabPage2 = new TabPage();
            buttonCreateOval = new Button();
            buttonDraw = new Button();
            listBoxFigure = new ListBox();
            buttonCreateFigureSquare = new Button();
            pictureBox1 = new PictureBox();
            labelHeightFigure = new Label();
            labelWidthFigure = new Label();
            numericUpDownHeightFigure = new NumericUpDown();
            numericUpDownWidthFigure = new NumericUpDown();
            tabPage3 = new TabPage();
            textBoxOper = new TextBox();
            buttonMulty2 = new Button();
            buttonMulty = new Button();
            labelB = new Label();
            labelA = new Label();
            numericUpDownB = new NumericUpDown();
            numericUpDownA = new NumericUpDown();
            tabControlTaskFirst.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeightFigure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidthFigure).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            SuspendLayout();
            // 
            // tabControlTaskFirst
            // 
            tabControlTaskFirst.Controls.Add(tabPage1);
            tabControlTaskFirst.Controls.Add(tabPage2);
            tabControlTaskFirst.Controls.Add(tabPage3);
            tabControlTaskFirst.Location = new Point(-2, -2);
            tabControlTaskFirst.Name = "tabControlTaskFirst";
            tabControlTaskFirst.SelectedIndex = 0;
            tabControlTaskFirst.Size = new Size(803, 449);
            tabControlTaskFirst.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonOutput);
            tabPage1.Controls.Add(buttonCreate);
            tabPage1.Controls.Add(listBoxObj);
            tabPage1.Controls.Add(labelWidth);
            tabPage1.Controls.Add(numericUpDownWidth);
            tabPage1.Controls.Add(labelLength);
            tabPage1.Controls.Add(numericUpDownLength);
            tabPage1.Controls.Add(labelHeight);
            tabPage1.Controls.Add(numericUpDownHeight);
            tabPage1.Controls.Add(labelColor);
            tabPage1.Controls.Add(textBoxColor);
            tabPage1.Controls.Add(labelMaterial);
            tabPage1.Controls.Add(textBoxMaterial);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonOutput
            // 
            buttonOutput.Location = new Point(447, 282);
            buttonOutput.Name = "buttonOutput";
            buttonOutput.Size = new Size(129, 23);
            buttonOutput.TabIndex = 12;
            buttonOutput.Text = "Вывести список";
            buttonOutput.UseVisualStyleBackColor = true;
            buttonOutput.Click += buttonOutput_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(63, 282);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(110, 23);
            buttonCreate.TabIndex = 11;
            buttonCreate.Text = "Создать объект";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // listBoxObj
            // 
            listBoxObj.FormattingEnabled = true;
            listBoxObj.ItemHeight = 15;
            listBoxObj.Location = new Point(303, 65);
            listBoxObj.Name = "listBoxObj";
            listBoxObj.Size = new Size(483, 184);
            listBoxObj.TabIndex = 10;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(137, 188);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(91, 15);
            labelWidth.TabIndex = 9;
            labelWidth.Text = "Задать ширину";
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Location = new Point(10, 180);
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(111, 23);
            numericUpDownWidth.TabIndex = 8;
            numericUpDownWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(137, 233);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(79, 15);
            labelLength.TabIndex = 7;
            labelLength.Text = "Задать длину";
            // 
            // numericUpDownLength
            // 
            numericUpDownLength.Location = new Point(10, 225);
            numericUpDownLength.Name = "numericUpDownLength";
            numericUpDownLength.Size = new Size(111, 23);
            numericUpDownLength.TabIndex = 6;
            numericUpDownLength.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(127, 140);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(85, 15);
            labelHeight.TabIndex = 5;
            labelHeight.Text = "Задать высоту";
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new Point(10, 132);
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(111, 23);
            numericUpDownHeight.TabIndex = 4;
            numericUpDownHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(127, 89);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(70, 15);
            labelColor.TabIndex = 3;
            labelColor.Text = "Задать цвет";
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(10, 81);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(111, 23);
            textBoxColor.TabIndex = 2;
            // 
            // labelMaterial
            // 
            labelMaterial.AutoSize = true;
            labelMaterial.Location = new Point(127, 36);
            labelMaterial.Name = "labelMaterial";
            labelMaterial.Size = new Size(99, 15);
            labelMaterial.TabIndex = 1;
            labelMaterial.Text = "Задать материал";
            // 
            // textBoxMaterial
            // 
            textBoxMaterial.Location = new Point(10, 28);
            textBoxMaterial.Name = "textBoxMaterial";
            textBoxMaterial.Size = new Size(111, 23);
            textBoxMaterial.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonCreateOval);
            tabPage2.Controls.Add(buttonDraw);
            tabPage2.Controls.Add(listBoxFigure);
            tabPage2.Controls.Add(buttonCreateFigureSquare);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(labelHeightFigure);
            tabPage2.Controls.Add(labelWidthFigure);
            tabPage2.Controls.Add(numericUpDownHeightFigure);
            tabPage2.Controls.Add(numericUpDownWidthFigure);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 421);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonCreateOval
            // 
            buttonCreateOval.Location = new Point(20, 193);
            buttonCreateOval.Name = "buttonCreateOval";
            buttonCreateOval.Size = new Size(102, 23);
            buttonCreateOval.TabIndex = 8;
            buttonCreateOval.Text = "Овал";
            buttonCreateOval.UseVisualStyleBackColor = true;
            buttonCreateOval.Click += buttonCreateOval_Click;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(508, 250);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(75, 23);
            buttonDraw.TabIndex = 7;
            buttonDraw.Text = "Рисовать";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // listBoxFigure
            // 
            listBoxFigure.FormattingEnabled = true;
            listBoxFigure.ItemHeight = 15;
            listBoxFigure.Location = new Point(10, 235);
            listBoxFigure.Name = "listBoxFigure";
            listBoxFigure.Size = new Size(287, 154);
            listBoxFigure.TabIndex = 6;
            // 
            // buttonCreateFigureSquare
            // 
            buttonCreateFigureSquare.Location = new Point(20, 146);
            buttonCreateFigureSquare.Name = "buttonCreateFigureSquare";
            buttonCreateFigureSquare.Size = new Size(102, 23);
            buttonCreateFigureSquare.TabIndex = 5;
            buttonCreateFigureSquare.Text = "Прямоугольник";
            buttonCreateFigureSquare.UseVisualStyleBackColor = true;
            buttonCreateFigureSquare.Click += buttonCreateFigureSquare_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(303, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(464, 238);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelHeightFigure
            // 
            labelHeightFigure.AutoSize = true;
            labelHeightFigure.Location = new Point(138, 94);
            labelHeightFigure.Name = "labelHeightFigure";
            labelHeightFigure.Size = new Size(47, 15);
            labelHeightFigure.TabIndex = 3;
            labelHeightFigure.Text = "Высота";
            // 
            // labelWidthFigure
            // 
            labelWidthFigure.AutoSize = true;
            labelWidthFigure.Location = new Point(138, 41);
            labelWidthFigure.Name = "labelWidthFigure";
            labelWidthFigure.Size = new Size(52, 15);
            labelWidthFigure.TabIndex = 2;
            labelWidthFigure.Text = "Ширина";
            // 
            // numericUpDownHeightFigure
            // 
            numericUpDownHeightFigure.Location = new Point(10, 86);
            numericUpDownHeightFigure.Name = "numericUpDownHeightFigure";
            numericUpDownHeightFigure.Size = new Size(112, 23);
            numericUpDownHeightFigure.TabIndex = 1;
            numericUpDownHeightFigure.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownWidthFigure
            // 
            numericUpDownWidthFigure.Location = new Point(10, 33);
            numericUpDownWidthFigure.Name = "numericUpDownWidthFigure";
            numericUpDownWidthFigure.Size = new Size(112, 23);
            numericUpDownWidthFigure.TabIndex = 0;
            numericUpDownWidthFigure.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBoxOper);
            tabPage3.Controls.Add(buttonMulty2);
            tabPage3.Controls.Add(buttonMulty);
            tabPage3.Controls.Add(labelB);
            tabPage3.Controls.Add(labelA);
            tabPage3.Controls.Add(numericUpDownB);
            tabPage3.Controls.Add(numericUpDownA);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(795, 421);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxOper
            // 
            textBoxOper.Location = new Point(166, 191);
            textBoxOper.Name = "textBoxOper";
            textBoxOper.Size = new Size(100, 23);
            textBoxOper.TabIndex = 6;
            // 
            // buttonMulty2
            // 
            buttonMulty2.Location = new Point(10, 211);
            buttonMulty2.Name = "buttonMulty2";
            buttonMulty2.Size = new Size(120, 23);
            buttonMulty2.TabIndex = 5;
            buttonMulty2.Text = "Квадрат суммы";
            buttonMulty2.UseVisualStyleBackColor = true;
            buttonMulty2.Click += buttonMulty2_Click;
            // 
            // buttonMulty
            // 
            buttonMulty.Location = new Point(10, 161);
            buttonMulty.Name = "buttonMulty";
            buttonMulty.Size = new Size(120, 23);
            buttonMulty.TabIndex = 4;
            buttonMulty.Text = "Произведение";
            buttonMulty.UseVisualStyleBackColor = true;
            buttonMulty.Click += buttonMulty_Click;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(136, 107);
            labelB.Name = "labelB";
            labelB.Size = new Size(83, 15);
            labelB.TabIndex = 3;
            labelB.Text = "Второе число";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(136, 41);
            labelA.Name = "labelA";
            labelA.Size = new Size(85, 15);
            labelA.TabIndex = 2;
            labelA.Text = "Первое число";
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(10, 99);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(120, 23);
            numericUpDownB.TabIndex = 1;
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(10, 39);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(120, 23);
            numericUpDownA.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlTaskFirst);
            Name = "Form1";
            Text = "Form1";
            tabControlTaskFirst.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeightFigure).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidthFigure).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlTaskFirst;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label labelHeight;
        private NumericUpDown numericUpDownHeight;
        private Label labelColor;
        private TextBox textBoxColor;
        private Label labelMaterial;
        private TextBox textBoxMaterial;
        private TabPage tabPage3;
        private Label labelLength;
        private NumericUpDown numericUpDownLength;
        private Label labelWidth;
        private NumericUpDown numericUpDownWidth;
        private Button buttonCreate;
        private ListBox listBoxObj;
        private Button buttonOutput;
        private Label labelWidthFigure;
        private NumericUpDown numericUpDownHeightFigure;
        private NumericUpDown numericUpDownWidthFigure;
        private Label labelHeightFigure;
        private Button buttonCreateFigureSquare;
        private PictureBox pictureBox1;
        private Button buttonDraw;
        private ListBox listBoxFigure;
        private Button buttonCreateOval;
        private NumericUpDown numericUpDownB;
        private NumericUpDown numericUpDownA;
        private TextBox textBoxOper;
        private Button buttonMulty2;
        private Button buttonMulty;
        private Label labelB;
        private Label labelA;
    }
}

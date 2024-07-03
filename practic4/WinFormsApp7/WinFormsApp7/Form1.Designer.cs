namespace WinFormsApp7
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
            numericUpDownX = new NumericUpDown();
            labelX = new Label();
            buttonStart = new Button();
            textBoxY = new TextBox();
            textBoxX = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownX
            // 
            numericUpDownX.Location = new Point(12, 57);
            numericUpDownX.Name = "numericUpDownX";
            numericUpDownX.Size = new Size(120, 23);
            numericUpDownX.TabIndex = 0;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(159, 65);
            labelX.Name = "labelX";
            labelX.Size = new Size(97, 15);
            labelX.TabIndex = 1;
            labelX.Text = "Введите число X";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(57, 111);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(386, 56);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 3;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(386, 102);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxX);
            Controls.Add(textBoxY);
            Controls.Add(buttonStart);
            Controls.Add(labelX);
            Controls.Add(numericUpDownX);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownX;
        private Label labelX;
        private Button buttonStart;
        private TextBox textBoxY;
        private TextBox textBoxX;
    }
}

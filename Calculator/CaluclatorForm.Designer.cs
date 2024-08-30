namespace Calculator
{
    partial class CaluclatorForm
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
            AddBtn = new Button();
            firstNumberBox = new TextBox();
            secondNumberBox = new TextBox();
            SubtractBtn = new Button();
            MultiplyBtn = new Button();
            DivideBtn = new Button();
            answerBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(255, 192, 192);
            AddBtn.Location = new Point(486, 29);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(56, 55);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "+";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // firstNumberBox
            // 
            firstNumberBox.Location = new Point(315, 29);
            firstNumberBox.Name = "firstNumberBox";
            firstNumberBox.Size = new Size(125, 27);
            firstNumberBox.TabIndex = 1;
            firstNumberBox.TextChanged += textBox1_TextChanged;
            // 
            // secondNumberBox
            // 
            secondNumberBox.Location = new Point(315, 81);
            secondNumberBox.Name = "secondNumberBox";
            secondNumberBox.Size = new Size(125, 27);
            secondNumberBox.TabIndex = 2;
            // 
            // SubtractBtn
            // 
            SubtractBtn.BackColor = Color.FromArgb(255, 192, 192);
            SubtractBtn.Location = new Point(560, 29);
            SubtractBtn.Name = "SubtractBtn";
            SubtractBtn.Size = new Size(57, 55);
            SubtractBtn.TabIndex = 3;
            SubtractBtn.Text = "-";
            SubtractBtn.UseVisualStyleBackColor = false;
            SubtractBtn.Click += SubtractBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.BackColor = Color.FromArgb(255, 192, 192);
            MultiplyBtn.Location = new Point(486, 101);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(56, 55);
            MultiplyBtn.TabIndex = 4;
            MultiplyBtn.Text = "x";
            MultiplyBtn.UseVisualStyleBackColor = false;
            MultiplyBtn.Click += MultiplyBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.BackColor = Color.FromArgb(255, 192, 192);
            DivideBtn.Location = new Point(560, 101);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(57, 55);
            DivideBtn.TabIndex = 5;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = false;
            DivideBtn.Click += DivideBtn_Click;
            // 
            // answerBox
            // 
            answerBox.Location = new Point(315, 190);
            answerBox.Name = "answerBox";
            answerBox.Size = new Size(125, 27);
            answerBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 36);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 7;
            label1.Text = "First number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 88);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 8;
            label2.Text = "Second Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 193);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "Answer:";
            // 
            // CaluclatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(answerBox);
            Controls.Add(DivideBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(SubtractBtn);
            Controls.Add(secondNumberBox);
            Controls.Add(firstNumberBox);
            Controls.Add(AddBtn);
            Name = "CaluclatorForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private TextBox firstNumberBox;
        private TextBox secondNumberBox;
        private Button SubtractBtn;
        private Button MultiplyBtn;
        private Button DivideBtn;
        private TextBox answerBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
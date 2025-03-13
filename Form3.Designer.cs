namespace LAB2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Monitory = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Monitory
            // 
            Monitory.FormattingEnabled = true;
            Monitory.Items.AddRange(new object[] { "Monitor 1 ", "Monitor 2 ", "Monitor 3 ", "Monitor 4", "Monitor 5" });
            Monitory.Location = new Point(34, 27);
            Monitory.Name = "Monitory";
            Monitory.Size = new Size(275, 164);
            Monitory.TabIndex = 1;
            Monitory.SelectedIndexChanged += Monitory_SelectedIndexChanged_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 215);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "Cena";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 215);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 4;
            label2.Text = "zł";
            // 
            // button1
            // 
            button1.Location = new Point(12, 260);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(237, 260);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "ANULUJ";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 301);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Monitory);
            Name = "Form3";
            Text = "Monitor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Monitory;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
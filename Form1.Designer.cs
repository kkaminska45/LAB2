namespace LAB2
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
            btnKomputer = new Button();
            btnMonitor = new Button();
            CenaCalkowita = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnKomputer
            // 
            btnKomputer.Location = new Point(12, 42);
            btnKomputer.Name = "btnKomputer";
            btnKomputer.Size = new Size(134, 46);
            btnKomputer.TabIndex = 0;
            btnKomputer.Text = "Komputer";
            btnKomputer.UseVisualStyleBackColor = true;
            btnKomputer.Click += button1_Click;
            // 
            // btnMonitor
            // 
            btnMonitor.Location = new Point(165, 42);
            btnMonitor.Name = "btnMonitor";
            btnMonitor.Size = new Size(134, 46);
            btnMonitor.TabIndex = 1;
            btnMonitor.Text = "Monitor";
            btnMonitor.UseVisualStyleBackColor = true;
            btnMonitor.Click += button2_Click;
            // 
            // CenaCalkowita
            // 
            CenaCalkowita.Location = new Point(320, 61);
            CenaCalkowita.Name = "CenaCalkowita";
            CenaCalkowita.Size = new Size(135, 27);
            CenaCalkowita.TabIndex = 2;
            CenaCalkowita.TextChanged += CenaCalkowita_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(398, 38);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 3;
            label1.Text = "Cena zł";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 120);
            Controls.Add(label1);
            Controls.Add(CenaCalkowita);
            Controls.Add(btnMonitor);
            Controls.Add(btnKomputer);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kalkulator Zestawów Komputerowych";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKomputer;
        private Button btnMonitor;
        private TextBox CenaCalkowita;
        private Label label1;
    }
}

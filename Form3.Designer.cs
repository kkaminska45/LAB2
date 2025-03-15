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
            CenaMonitora = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnOKmonitor = new Button();
            btnANULUJmonitor = new Button();
            SuspendLayout();
            // 
            // Monitory
            // 
            Monitory.FormattingEnabled = true;
            Monitory.Items.AddRange(new object[] { "Monitor 1", "Monitor 2", "Monitor 3", "Monitor 4", "Monitor 5" });
            Monitory.Location = new Point(34, 27);
            Monitory.Name = "Monitory";
            Monitory.Size = new Size(275, 164);
            Monitory.TabIndex = 1;
            Monitory.SelectedIndexChanged += Monitory_SelectedIndexChanged_1;
            // 
            // CenaMonitora
            // 
            CenaMonitora.Location = new Point(106, 212);
            CenaMonitora.Name = "CenaMonitora";
            CenaMonitora.Size = new Size(125, 27);
            CenaMonitora.TabIndex = 2;
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
            // btnOKmonitor
            // 
            btnOKmonitor.Location = new Point(12, 260);
            btnOKmonitor.Name = "btnOKmonitor";
            btnOKmonitor.Size = new Size(94, 29);
            btnOKmonitor.TabIndex = 5;
            btnOKmonitor.Text = "OK";
            btnOKmonitor.UseVisualStyleBackColor = true;
            btnOKmonitor.Click += btnOKmonitor_Click_1;
            // 
            // btnANULUJmonitor
            // 
            btnANULUJmonitor.Location = new Point(237, 260);
            btnANULUJmonitor.Name = "btnANULUJmonitor";
            btnANULUJmonitor.Size = new Size(94, 29);
            btnANULUJmonitor.TabIndex = 6;
            btnANULUJmonitor.Text = "ANULUJ";
            btnANULUJmonitor.UseVisualStyleBackColor = true;
            btnANULUJmonitor.Click += btnANULUJmonitor_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 301);
            Controls.Add(btnANULUJmonitor);
            Controls.Add(btnOKmonitor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CenaMonitora);
            Controls.Add(Monitory);
            Name = "Form3";
            Text = "Monitor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Monitory;
        private TextBox CenaMonitora;
        private Label label1;
        private Label label2;
        private Button btnOKmonitor;
        private Button btnANULUJmonitor;
    }
}
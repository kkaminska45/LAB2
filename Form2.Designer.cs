namespace LAB2
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            CenaProcesora = new TextBox();
            btnOKkomputer = new Button();
            btnANULUJkomputer = new Button();
            Procesory = new ComboBox();
            label3 = new Label();
            CenaDysku = new TextBox();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Procesor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 34);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 1;
            label2.Text = "zł";
            // 
            // CenaProcesora
            // 
            CenaProcesora.Location = new Point(93, 27);
            CenaProcesora.Name = "CenaProcesora";
            CenaProcesora.Size = new Size(125, 27);
            CenaProcesora.TabIndex = 2;
            // 
            // btnOKkomputer
            // 
            btnOKkomputer.Location = new Point(12, 336);
            btnOKkomputer.Name = "btnOKkomputer";
            btnOKkomputer.Size = new Size(94, 29);
            btnOKkomputer.TabIndex = 3;
            btnOKkomputer.Text = "OK";
            btnOKkomputer.UseVisualStyleBackColor = true;
            btnOKkomputer.Click += btnOKkomputer_Click;
            // 
            // btnANULUJkomputer
            // 
            btnANULUJkomputer.Location = new Point(189, 336);
            btnANULUJkomputer.Name = "btnANULUJkomputer";
            btnANULUJkomputer.Size = new Size(94, 29);
            btnANULUJkomputer.TabIndex = 4;
            btnANULUJkomputer.Text = "ANULUJ";
            btnANULUJkomputer.UseVisualStyleBackColor = true;
            btnANULUJkomputer.Click += btnANULUJkomputer_Click;
            // 
            // Procesory
            // 
            Procesory.FormattingEnabled = true;
            Procesory.Items.AddRange(new object[] { "Procesor 1", "Procesor 2", "Procesor 3", "Procesor 4" });
            Procesory.Location = new Point(12, 73);
            Procesory.Name = "Procesory";
            Procesory.Size = new Size(271, 28);
            Procesory.TabIndex = 5;
            Procesory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 6;
            label3.Text = "Dysk";
            // 
            // CenaDysku
            // 
            CenaDysku.Location = new Point(93, 135);
            CenaDysku.Name = "CenaDysku";
            CenaDysku.Size = new Size(125, 27);
            CenaDysku.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 142);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 8;
            label4.Text = "zł";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(38, 180);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(108, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "240 GB SSD";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(38, 240);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(123, 24);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "1000 GB SATA";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(38, 210);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(115, 24);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "500 GB SATA";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(174, 336);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-5, 104);
            label5.Name = "label5";
            label5.Size = new Size(309, 20);
            label5.TabIndex = 13;
            label5.Text = "__________________________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-5, 267);
            label6.Name = "label6";
            label6.Size = new Size(309, 20);
            label6.TabIndex = 14;
            label6.Text = "__________________________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 298);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 15;
            label7.Text = "Reszta: 1000 zł";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 381);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(CenaDysku);
            Controls.Add(label3);
            Controls.Add(Procesory);
            Controls.Add(btnANULUJkomputer);
            Controls.Add(btnOKkomputer);
            Controls.Add(CenaProcesora);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Komputer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CenaProcesora;
        private Button btnOKkomputer;
        private Button btnANULUJkomputer;
        private ComboBox Procesory;
        private Label label3;
        private TextBox CenaDysku;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private LinkLabel linkLabel1;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
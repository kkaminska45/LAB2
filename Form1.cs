namespace LAB2
{
    public partial class Form1 : Form
    {
        public int cena1;
        public int cena2;
        public int cena3;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this); 
            form3.Show();
        }

        public void ustawCene()
        {
            CenaCalkowita.Text = (cena1 + cena2 + cena3).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void CenaCalkowita_TextChanged(object sender, EventArgs e)
        {
        }

    }
}

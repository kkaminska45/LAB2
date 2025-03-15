using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Form2 : Form

    {
        private Form1 glowneOkno;
        public Form2(Form1 okno)
        {
            InitializeComponent();
            glowneOkno = okno;
        }

        private void btnANULUJkomputer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> cenyProcesorow = new Dictionary<string, string>()
            {
                { "Procesor 1", "359" },
                { "Procesor 2", "2499" },
                { "Procesor 3", "789" },
                { "Procesor 4", "1359" }
            };

            string wybranyProcesor = Procesory.SelectedItem.ToString();

            CenaProcesora.Text = cenyProcesorow[wybranyProcesor];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string cenaDysku1 = "499";
            CenaDysku.Text = cenaDysku1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string cenaDysku2 = "999";
            CenaDysku.Text = cenaDysku2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string cenaDysku3 = "1599";
            CenaDysku.Text = cenaDysku3;
        }

        private void btnOKkomputer_Click(object sender, EventArgs e)
        {
            glowneOkno.cena2 = int.Parse(CenaProcesora.Text);
            glowneOkno.cena3 = int.Parse(CenaDysku.Text);
            glowneOkno.cena3 = glowneOkno.cena3 + 1000;
            glowneOkno.ustawCene();

            this.Close();
        }
    }
}

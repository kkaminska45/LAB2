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
    public partial class Form3 : Form

    {
        private Form1 glowneOkno;

        public Form3(Form1 okno)
        {
            InitializeComponent();
            glowneOkno = okno;
        }

        private void Monitory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Dictionary<string, string> cenyMonitorów = new Dictionary<string, string>()
            {
                { "Monitor 1", "899" },
                { "Monitor 2", "1199" },
                { "Monitor 3", "1599" },
                { "Monitor 4", "699" },
                { "Monitor 5", "299" }
            };

            string wybranyMonitor = Monitory.SelectedItem.ToString();

            if (cenyMonitorów.ContainsKey(wybranyMonitor))
            {
                CenaMonitora.Text = cenyMonitorów[wybranyMonitor];
            }
            else
            {
                CenaMonitora.Text = "Brak ceny";
            }
        }

        private void btnANULUJmonitor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOKmonitor_Click_1(object sender, EventArgs e)
        {
            glowneOkno.cena1 = int.Parse(CenaMonitora.Text);
            glowneOkno.ustawCene();

            this.Close();
        }
    }
}

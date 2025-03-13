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
        public Form3()
        {
            InitializeComponent();
        }

        private void monitory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Monitory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Dictionary<string, string> cenyMonitorów = new Dictionary<string, string>()
            {
                { "Monitor 1", "899 zł" },
                { "Monitor 2", "1199 zł" },
                { "Monitor 3", "1599 zł" },
                { "Monitor 4", "699 zł" },
                { "Monitor 5", "299 zł" }
            };

            string wybranyMonitor = Monitory.SelectedItem.ToString();

            if (cenyMonitorów.ContainsKey(wybranyMonitor))
            {
                textBox1.Text = cenyMonitorów[wybranyMonitor];
            }
            else
            {
                textBox1.Text = "Brak ceny";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

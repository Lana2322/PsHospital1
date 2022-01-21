using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PsHospital1
{
    public partial class Func : Form
    {
        public Func()
        {
            InitializeComponent();
        }

        private void WomanButton_Click(object sender, EventArgs e)
        {
            Woman wmn = new Woman();
        }

        private void DangerButton_Click(object sender, EventArgs e)
        {
            DangerPacient DP = new DangerPacient();
        }

        private void AllButton_Click(object sender, EventArgs e)
        {
            AllAge AA = new AllAge();
        }

        private void ComeButton_Click(object sender, EventArgs e)
        {
            Grafik Graf = new Grafik();
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            Diagrama Diag = new Diagrama();
        }

        private void DiagnosButton_Click(object sender, EventArgs e)
        {
            Stolbik Stolb = new Stolbik();
        }
    }
}

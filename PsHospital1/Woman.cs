using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PsHospital1.Pacient;
using PsHospital1.File;
using PsHospital1.Hospital;
using PsHospital1.Func;
using System.IO;

namespace PsHospital1
{
    public partial class Woman : Form
    {
        private Hospital Hos = new Hospital();
        private int PacientIndex;

        public Woman()
        {
            InitializeComponent();
        }

        public void UpdateInfo()
        {
            int al, f;
            foreach (var number in Hos.Pacients)
            {
                if (Hos.Pacients.Data == dateTimePicker1)
                {
                    if (Hos.Pacients.Gender == "женский")
                    {
                        al = al + 1;
                        f = f + 1;
                    }
                    else
                    {
                        al = al + 1;
                    }
                }
            }
            int d = f/al * 100;
            this.ProcentTextBox.Text = d + "%";

        private void YesButton_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }
    }
}

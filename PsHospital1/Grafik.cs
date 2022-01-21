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
using System.Data.SqlClient;
using System.Data;

namespace PsHospital1
{
    public partial class Grafik : Form
    {
        private Hospital Hos = new Hospital();
        private int PacientIndex;

        public Grafik()
        {
            InitializeComponent();
        }

        static List<Pacient> UpdateInfo()
        {
            List<Pacient> BetaPacient = new List<Pacient>();
            foreach (var number in Hos.Pacients)
            {
                if (Hos.Pacients[number].Data == dateTimePicker1.year)
                {
                    BetaPacient.Add(Hos.Pacients[number]);
                }
            }
            return BetaPacient;
            
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            List<Pacient> beta = UpdateInfo();
            double a = dateTimePicker1.month, b = (dateTimePicker1.month + 12), h = 1, x, y;
            chart1.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = beta.Count;
                chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }
    }
}

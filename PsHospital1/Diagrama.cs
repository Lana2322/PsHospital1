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

namespace PsHospital1
{
    public partial class Diagrama : Form
    {
        private Hospital Hos = new Hospital();
        private int PacientIndex;

        public Diagrama()
        {
            InitializeComponent();
        }

        static double[] UpdateInfo()
        {
            double a, b, c;
            foreach (var number in Hos.Pacients)
            {
                if (Hos.Pacients[number].Data == dateTimePicker1.year)
                {
                    if (Hos.Pacients[number].Status == "Содержится")
                    {
                        a += 1;
                    }
                    else
                    {
                        if (Hos.Pacients[number].Status == "Под наблюдением")
                        {
                            b += 1;
                        }
                        else
                        {
                            c += 1;
                        }
                    }
                }
            }
            double[] array = new double[3] {a, b, c};
            return array;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            double[] betaArray = UpdateInfo();
            double a = betaArray[0], b = betaArray[1], c = betaArray[2];
            chart1.Series.Clear();
            double[] yValues = { a, b, c };
            string[] xValues = { "Содержится", "Под наблюдением", "Сбежал" };
            chart1.Series[0].Points.DataBindXY(xValues, yValues);
        }

        
    }
}

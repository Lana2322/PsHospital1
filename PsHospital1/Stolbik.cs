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
    public partial class Stolbik : Form
    {
        public Stolbik()
        {
            InitializeComponent();
        }
        private Hospital Hos = new Hospital();
        private int PacientIndex;

        static double[] UpdateInfo()
        {
            double a, b, c, d, e;
            foreach (var number in Hos.Pacients)
            {
                if (Hos.Pacients[number].Data == dateTimePicker1.year)
                {
                    if (Hos.Pacients[number].Diagnos == "Шизофрения")
                    {
                        a += 1;
                    }
                    else
                    {
                        if (Hos.Pacients[number].Diagnos == "Биполярное аффективное расстройство")
                        {
                            b += 1;
                        }
                        else
                        {
                            if (Hos.Pacients[number].Diagnos == "Посттравматическое стрессовое расстройство")
                            {
                                c += 1;
                            }
                            else
                            {
                                if (Hos.Pacients[number].Diagnos == "Расстройство личности")
                                {
                                    d += 1;
                                }
                                else
                                {
                                    e += 1;
                                }
                            }
                        }
                    }
                }
            }
            double[] array = new double[5] { a, b, c, d, e };
            return array;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            double[] betaArray = UpdateInfo();
            double a1 = betaArray[0], b1 = betaArray[1], c1 = betaArray[2], d1 = betaArray[1], e1 = betaArray[2];
            chart1.Series.Clear();
            double[] yValues = { a1, b1, c1, d1, e1 };
            chart1.Series[0].Points.DataBindXY(yValues);
        }
    }
}

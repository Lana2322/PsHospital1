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
    public partial class AllAge : Form
    {

        private Hospital Hos = new Hospital();
        private int PacientIndex;

        public AllAge()
        {
            InitializeComponent();
        }

        static void UpdateInfo()
        {

            var sortedPacient = from u in Hos.Pacients
                  orderby u.Age
                  select u;

            foreach (var number in sortedPacient)
            {
                if (Hos.Pacients.Data == dateTimePicker1)
                {
                    INSERT [INTO] dataGridView1 VALUES (Pacients.Name, Pacients.Age, Pacient.Gender, Pacient.Data, Pacient.Status, Pacient.Diagnos, Pacient.Danger);
                }
            }
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }
    }
}

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
    public partial class DangerPacient : Form
    {

        private Hospital Hos = new Hospital();
        private int PacientIndex;

        public DangerPacient()
        {
            InitializeComponent();
        }


        /*
        private void LoadData()
        {
            string connectString = "Data Source= Hos.Pacients;" +
                "Integrated Security=true;";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM Faculty ORDER BY fac_id";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        */

        static void UpdateInfo()
        {
            foreach (var number in Hos.Pacients)
            {
                if (Hos.Pacients.Data == dateTimePicker1)
                {
                    if (Hos.Pacients.Danger == true)
                    {
                        INSERT [INTO] dataGridView1 VALUES (Pacient.Name, Pacient.Age, Pacient.Gender, Pacient.Data, Pacient.Status, Pacient.Diagnos, Pacient.Danger);
                    }
                }
            }
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }
    }
}

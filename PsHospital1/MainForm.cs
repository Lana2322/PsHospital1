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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        private File Fil = new File();
        private Hospital Hos = new Hospital();
        private int PacientIndex;

        public void CreatHospital()
        {
            Hos = new Hospital();
            Hos.Pacients.Add(new Pacient("Пациент"));
            UpdatePacient(0);
        }
     
        public void UpdatePacient(int ind)
        {
            if (ind == -1) { PacientIndex = 0; }
            else { PacientIndex = ind; }
            NameTextBox.Text = Hos.Pacients[PacientIndex].Name;
            AgeNumericUpDown.Value = Hos.Pacients[PacientIndex].Age;
            comboBox1.Text = Hos.Pacients[PacientIndex].Gender;
            dateTimePicker1.Text = Hos.Pacients[PacientIndex].Data;
            DiagnosTextBox.Text = Hos.Pacients[PacientIndex].Diagnos;
            StatusNumericUpDown.Value = Hos.Pacients[PacientIndex].Status;
            if (Hos.Pacients[PacientIndex].Danger == true)
            {
                DangerCheckBox.CheckState = CheckState.Checked;
            }
            else
            {
                DangerCheckBox.CheckState = CheckState.Unchecked;
            }
        }
        
        public void SaveCheck()
        {
            if (Fil.FileChanged == true)
            {
                DialogResult choice = MessageBox.Show("Сохранить", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (choice == DialogResult.Cancel) { return; }
                if (choice == DialogResult.Yes) 
                { 
                    Fil.Save(Hos);
                }
            }
        }

        //

        private void Creat_button_Click(object sender, EventArgs e)
        {
            SaveCheck();
            CreatHospital();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Select_button_Click(object sender, EventArgs e)
        {
            SaveCheck();
            openFileDialog1.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";
            openFileDialog1.Title = "Выберите файл...";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            Fil.Path = openFileDialog1.FileName;
            Hos = Fil.Load();
            UpdatePacient(0);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";
            saveFileDialog1.Title = "Выберите файл...";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            Fil.Path = saveFileDialog1.FileName;
            Fil.Save(Hos);
        }

        private void Everything_button_Click(object sender, EventArgs e)
        {
            Func funcs = new Func();
        }

    }
}

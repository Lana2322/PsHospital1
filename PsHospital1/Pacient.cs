using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsHospital1
{
    class Pacient
    {
        private string name = "";
        private int age = 0;
        private string data = "";
        private string gender = "";
        private bool danger = false;
        private int status = 0;
        private string diagnos = "";

        public Pacient()
        {
        }

        public Pacient(string inputName)
        {
            this.Name = inputName;
        }
        public Pacient(string inputName, int inputAge, string inputData, string inputGender)
        {
            this.Name = inputName;
            this.Age = inputAge;
            this.Data = inputData;
            this.Gender = inputGender;
        }

        public string Name { get ; set ; }
        public int Age { get; set; }
        public string Data { get ; set ; }
        public string Gender { get; set; }
        public bool Danger { get; set; }
        public int Status { get; set; }
        public string Diagnos { get; set; }
    }
}

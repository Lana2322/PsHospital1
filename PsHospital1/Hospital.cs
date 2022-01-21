using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PsHospital1
{
    class Hospital
    {
        private List<Pacient> folder;
        public IEnumerator<Pacient> GetEnumerator()
        {
            return folder.GetEnumerator();
        }
        public Hospital()
        {
            this.folder = new List<Pacient>();
        }

        public int Count
        {
            get
            {
                return folder.Count;
            }
        }

        public List<Pacient> Pacients
        {
            get
            {
                return folder;
            }
        }

        public void Push(Pacient inputPeople)
        {
            folder.Add(inputPeople);
        }

        public Pacient Pull(int number)
        {
            return folder[number];
        }

        public void Delete(int number)
        {
            folder.RemoveAt(number);
        }
    }
}

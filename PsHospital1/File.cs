using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace PsHospital1
{
    class File
    {
        private string path;
        private bool fileChanged = false;
        public File(string path)
        {
            this.path = path;
        }

        public File()
        {
            this.path = Environment.CurrentDirectory + @"\openme.json";
        }

        public string Path { get ; set ; }
        public bool FileChanged { get ; set ; }

        public Hospital Load()
        {
            try
            {
                StreamReader fS = new StreamReader(path);
                Hospital hosptl = JsonConvert.DeserializeObject<Hospital>(fS.ReadToEnd());
                fS.Close();
                return hosptl;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
                Hospital exLib = new Hospital();
                return exLib;
            }
        }

        public void Save(Hospital libIn)
        {
            try
            {
                StreamWriter fS = new StreamWriter(path);
                fS.Write(JsonConvert.SerializeObject(libIn));
                fS.Close();
                this.FileChanged = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
        }
    }
}

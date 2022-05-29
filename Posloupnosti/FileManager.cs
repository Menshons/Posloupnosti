using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posloupnosti
{
    public class FileManager
    {
        public string Load(string fileName)
        {
            string data = "";
            if (!File.Exists(fileName))
            {
                var file = File.Create(fileName);
                file.Close();
                return data;
            }
            using (StreamReader readtext = new StreamReader(fileName))
            {
                return readtext.ReadToEnd();
            }
        }

        public void Save(string fileName, string data)
        {
            if (!File.Exists(fileName))
            {
                var file = File.Create(fileName);
                file.Close();
            }
            using (StreamWriter writetext = new StreamWriter(fileName))
            {
                writetext.Write(data);
            }
        }
    }
}

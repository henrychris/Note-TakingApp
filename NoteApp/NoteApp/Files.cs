using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NoteApp
{
    class Files
    {
        public void createFile(String filename)
        {
            StreamWriter sw = File.CreateText(filename);
            sw.Close();
        }

        public void writeFile(String filename, String text)
        {
            File.AppendAllText(filename, text);
        }

        public string readFile(string filename)
        {
            string text = File.ReadAllText(filename);
            return text;
        }

        public void deleteFile(string filename)
        {
            File.Delete(filename);
        }
    }
}

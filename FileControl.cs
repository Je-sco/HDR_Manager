using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HDR_Manager
{
    public class FileControl
    {
        private bool alreadyExist = true;
        private string dataPath;
        public FileControl(string dataPath)
        {
            this.dataPath = dataPath;

            if (!File.Exists(dataPath))
            {
                alreadyExist = false;
                File.Create(dataPath).Close();
            }

        }

        public List<String> GetAsList()
        {
            List<String> savedData = new List<String>();
            string line;
            StreamReader sr = new StreamReader(dataPath);


            line = sr.ReadLine();
            while (line != null)
            {
                savedData.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();
            return savedData;
        }

        public void AppendToFile(string text)
        {
            StreamWriter sw = new StreamWriter(dataPath, true);
            sw.WriteLine(text);
            sw.Close();
        }

        public void ReplaceLine(int line, string value)
        {
            List<string> lines = File.ReadAllLines(dataPath).ToList();
            lines[line] = value;
            File.WriteAllLines(dataPath, lines);
        }

        public void DeleteLineByContent(string content)
        {
            List<string> lines = File.ReadAllLines(dataPath).ToList();
            lines.Remove(content);
            File.WriteAllLines(dataPath, lines);
        }

        public void EmptyFile()
        {
            File.WriteAllLines(dataPath, null);
        }

        public void OpenDataLocation()
        {
            Process.Start("explorer.exe", dataPath);
        }

        public bool IsFileEmpty()
        {
            string[] line = File.ReadAllLines(dataPath);
            if (line.Length > 0)
            {
                return false;
            }
            return true;
        }

        public bool GetAlreadyExist()
        {
            return alreadyExist;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCSubChanger
{
    class FileHandler
    {
        private string _Path;
        public string Path
        {
            get
            {
                return _Path;
            }
            set
            {
                _Path = value;
            }
        }

        public FileHandler(string filePath)
        {
            Path = filePath;
        }

        public string[] Read()
        {
            string[] result = null;

            try
            {
                result = File.ReadAllLines(Path);
            }
            catch (Exception e)
            {
                result = null;

                throw e;
            }

            return result;
        }

        public void Write(string[] lines)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Path.Substring(0, Path.IndexOf('.')) + "New.PLT");

                for (int i = 0; i < lines.Length; i++)
                {
                    sw.WriteLine(lines[i]);
                }

                sw.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

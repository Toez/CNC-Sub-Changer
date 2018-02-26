using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNCSubChanger
{
    class FileHandler
    {
        private string _Path;

        /// <summary>
        /// Path of file
        /// </summary>
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

        /// <summary>
        /// Custom constructor
        /// </summary>
        /// <param name="filePath">Path of file</param>
        public FileHandler(string filePath)
        {
            Path = filePath;
        }

        /// <summary>
        /// Reads all lines in file
        /// </summary>
        /// <returns>All lines as string array</returns>
        public string[] Read()
        {
            string[] result = null;

            try
            {
                result = File.ReadAllLines(Path);
            }
            catch (FileNotFoundException e)
            {
                result = null;

                throw e;
            }
            catch (Exception e)
            {
                result = null;

                throw e;
            }

            return result;
        }

        /// <summary>
        /// Writes a new CNC file
        /// </summary>
        /// <param name="lines">Lines you want to write</param>
        public void WriteCNC(string[] lines)
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

        /// <summary>
        /// Writes a new text file
        /// </summary>
        /// <param name="lines">Lines you want to write</param>
        public void Write(string[] lines)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Path);

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

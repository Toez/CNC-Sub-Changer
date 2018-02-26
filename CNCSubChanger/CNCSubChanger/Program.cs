using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNCSubChanger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                XmlHandler xh = new XmlHandler();
                FileHandler fh = new FileHandler(@args[0]);
                CNCHandler ch = new CNCHandler(fh.Read());
                fh.Write(ch.ChangeSub(xh.ReadXml(@"./Config.xml", "oldsub"), args[1], xh.ReadXml(@"./Config.xml", "subref")));
                MessageBox.Show("Done");
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
        }
    }
}

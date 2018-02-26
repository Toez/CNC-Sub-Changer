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
            try
            {
                string configfile = @".\Config1.txt";

                if (args.Length >= 1)
                {
                    configfile = args[0];
                }

                if (Properties.Settings.Default.autoStart)
                {
                    ConfigurationHandler cfh = new ConfigurationHandler(new FileHandler(configfile));
                    FileHandler fh = new FileHandler(cfh.ReturnConfig("path"));
                    CNCHandler ch = new CNCHandler(fh.Read());
                    fh.WriteCNC(ch.ChangeSub(cfh.ReturnConfig("oldhead"), cfh.ReturnConfig("newhead"), cfh.ReturnConfig("oldsub"), cfh.ReturnConfig("newsub"), cfh.ReturnConfig("subref"), cfh.ReturnConfig("subcall"), cfh.ReturnConfig("increment")));
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormMain(configfile));
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCSubChanger
{
    class ConfigurationHandler
    {
        private string _Path;

        /// <summary>
        /// Path of configuration file
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
        /// Handles writing and reading files
        /// </summary>
        private FileHandler FileHandler;

        /// <summary>
        /// Configuration file inner text
        /// </summary>
        private string[] Configurations;

        /// <summary>
        /// Configuration file template
        /// </summary>
        private string[] TextConfiguration
        {
            get
            {
                return new string[] { "path", "subref", "oldhead", "newhead", "oldsub", "newsub", "subcall", "increment" };
            }
        }

        /// <summary>
        /// Default constructor. Uses ".\Config.txt"
        /// </summary>
        public ConfigurationHandler()
        {
            FileHandler = new FileHandler(@".\Config1.txt");
            Path = FileHandler.Path;
            Configurations = FileHandler.Read();
        }

        /// <summary>
        /// Custom constructor
        /// </summary>
        /// <param name="fileHandler">FileHandler to write and read confige file</param>
        public ConfigurationHandler(FileHandler fileHandler)
        {
            Path = fileHandler.Path;
            Configurations = fileHandler.Read();
            FileHandler = fileHandler;
        }

        /// <summary>
        /// Gets the value of given key
        /// </summary>
        /// <param name="key">Key in cofiguration file</param>
        /// <returns>Returns key's value from config file as a string</returns>
        public string ReturnConfig(string key)
        {
            string result = "";

            try
            {
                int index = GetKeyIndex(key);
                
                result = Configurations[index].Substring(Configurations[index].IndexOf('=') + 1);
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        /// <summary>
        /// Change context in config file
        /// </summary>
        /// <param name="key">Key of object you want to change</param>
        /// <param name="value">Value of object you want to change</param>
        public void ChangeConfig(string key, string value)
        {
            int index = GetKeyIndex(key);
            Configurations[index] = TextConfiguration[index] + "=" + value;
        }

        /// <summary>
        /// Saves changes to config file
        /// </summary>
        public void SaveChanges()
        {
            FileHandler.Write(Configurations);
        }

        /// <summary>
        /// Gets index of key from config file
        /// </summary>
        /// <param name="key">Key you want to get the index from</param>
        /// <returns>Index of key in config file as int</returns>
        private int GetKeyIndex(string key)
        {
            int result = 0;

            for (int i = 0; i < TextConfiguration.Length; i++)
            {
                if (TextConfiguration[i] == key)
                    result = i;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCSubChanger
{
    class CNCHandler
    {
        private string[] Lines;

        public CNCHandler(string[] progLines)
        {
            Lines = progLines;
        }

        public string[] ChangeSub(string oldSub, string newSub, string subCmd)
        {
            string[] result = null;

            try
            {
                result = Lines.Select(s => s.Replace(subCmd + oldSub, subCmd + newSub)).ToArray();
            }
            catch (Exception e)
            {
                result = null;

                throw e;
            }

            return result;
        }
    }
}

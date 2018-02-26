using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCSubChanger
{
    class CNCHandler
    {
        /// <summary>
        /// All lines in CNC file
        /// </summary>
        private string[] Lines;

        /// <summary>
        /// Custom constructor
        /// </summary>
        /// <param name="progLines">All lines in file</param>
        public CNCHandler(string[] progLines)
        {
            Lines = progLines;
        }

        /// <summary>
        /// Changes submains, subs and sub calls to new sub
        /// </summary>
        /// <param name="oldSub">Old sub</param>
        /// <param name="newSub">New sub</param>
        /// <param name="subCmd">Refence to search for</param>
        /// <returns>All lines with subs changed as string array</returns>
        public string[] ChangeSub(string oldHead, string newHead, string oldSub, string newSub, string subCmd, string subCall, string increment)
        {
            string[] result = null;

            try
            {
                string temp = newSub;
                result = ChangeSubArray(oldSub, newSub, subCmd);
                
                do
                {
                    oldSub = (int.Parse(oldSub) + int.Parse(increment)).ToString();
                    newSub = (int.Parse(newSub) + int.Parse(increment)).ToString();

                    result = ChangeSubArray(oldSub, newSub, subCall);
                } while (string.Join("", result).Contains(subCall + oldSub) || string.Join("", result).Contains(subCall + (int.Parse(oldSub) + int.Parse(increment)).ToString()));

                do
                {
                    result = ChangeSubArray(oldHead, newHead, subCmd);
                    
                    oldHead = (int.Parse(oldHead) + int.Parse(increment)).ToString();
                    newHead = (int.Parse(newHead) + int.Parse(increment)).ToString();
                } while (string.Join("", result).Contains(subCmd + oldHead));
            }
            catch (Exception e)
            {
                result = null;

                throw e;
            }

            return result;
        }

        private string[] ChangeSubArray(string oldSub, string newSub, string subCmd)
        {
            string[] result = null;

            try
            {
                result = Lines = Lines.Select(s => s.Replace(subCmd + oldSub, subCmd + newSub)).ToArray();
            }
            catch (Exception e)
            {
                
                throw e;
            }

            return result;
        }
    }
}

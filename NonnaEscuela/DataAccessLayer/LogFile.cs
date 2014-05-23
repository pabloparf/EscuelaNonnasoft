using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LogFile
    {
        private const string FileName = "LogFile.log";
         
        /// <summary>
        /// Write text to the Log File
        /// </summary>
        /// <param name="textoCadena"></param>
        public static void WriteLogFile(string textoCadena)
        {

            if (!File.Exists(FileName))
                File.WriteAllText(FileName, textoCadena); //create the file then close it
            else
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(FileName, true))
                {
                    file.WriteLine(textoCadena); //Append text to the file
                }
            }
        }
    }
}

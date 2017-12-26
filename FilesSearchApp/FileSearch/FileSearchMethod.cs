using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearch
{
    public class FileSearchMethod

    {
        public delegate void DisplayFileName(string file);
        public event DisplayFileName SendFileName;
        public void Search(string dirName)
        {

            foreach (string dir in Directory.GetDirectories(dirName))
            {
                foreach (string str in Directory.GetFiles(dir))
                {
                    SendFileName(str);
                }
                Search(dir);
            }
        }

    }
}

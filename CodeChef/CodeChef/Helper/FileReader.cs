using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CodeChef.Helper
{
    public static class FileReader
    {
        public  static string[] ReadFileToStringArray(string filename)
        {
            return File.ReadAllLines(filename);            
        }

    }
}

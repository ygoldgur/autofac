using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace autofac_tutorial
{
    public class SystemIOFileReader : IFileReader
    {
        public string ReadFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}

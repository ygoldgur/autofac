using System;
using System.Collections.Generic;
using System.Text;

namespace autofac_tutorial
{
    public interface IFileReader
    {
        string ReadFile(string path);
    }
}

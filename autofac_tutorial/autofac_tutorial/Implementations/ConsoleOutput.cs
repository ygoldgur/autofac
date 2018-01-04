using System;
using System.Collections.Generic;
using System.Text;

namespace autofac_tutorial
{
    public class ConsoleOutput : IOutput
    {
        public void Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}

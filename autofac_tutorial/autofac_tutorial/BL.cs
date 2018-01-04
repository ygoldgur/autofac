using System;
using System.Collections.Generic;
using System.Text;

namespace autofac_tutorial
{
    public class BL
    {
        private IOutput _output;
        private IFileReader _reader;


        public BL(IOutput output, IFileReader reader)
        {
            _output = output;
            _reader = reader;
        }


        public void DoLogic(string filePath)
        {
            var fileContents = _reader.ReadFile(filePath);
            _output.Output(fileContents);
        }

    }
}

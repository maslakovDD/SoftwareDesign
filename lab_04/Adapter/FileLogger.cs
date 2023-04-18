using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileLogger : Logger
    {
        private FileWriter _writer;

        public FileLogger(FileWriter writer)
        {
            _writer = writer;
        }

        public override void Log(string message)
        {
            _writer.WriteLine(message);
        }
        public override void Warn(string message)
        {
            _writer.Write("Warn! ");
            _writer.WriteLine(message);

        }
        public override void Error(string message)
        {
            _writer.Write("Error! ");
            _writer.WriteLine(message);
        }
    }
}

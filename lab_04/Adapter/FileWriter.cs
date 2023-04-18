using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileWriter
    {
        private string _docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public void Write(string message)
        {
            using (StreamWriter writer = new(Path.Combine(_docPath, "file.txt"),true))
            {
                writer.Write(message);
            }
        }
        public void WriteLine(string message) 
        {
            using (StreamWriter writer = new(Path.Combine(_docPath, "file.txt"),true))
            {
                writer.WriteLine(message);
            }
        }

    }
}

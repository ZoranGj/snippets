using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProcessor.Files
{
    public class FileReader : IFileReader
    {
        public bool FileExists(string fileName)
        {
            throw new NotImplementedException();
        }

        public string ReadContent(string fileName)
        {
            throw new NotImplementedException();
        }

        public HashSet<string> ReadContentSeparated(string fileName, char separator)
        {
            throw new NotImplementedException();
        }
    }
}

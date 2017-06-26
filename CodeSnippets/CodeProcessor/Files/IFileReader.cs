using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProcessor.Files
{
    public interface IFileReader
    {
        bool FileExists(string fileName);

        string ReadContent(string fileName);

        HashSet<string> ReadContentSeparated(string fileName, char separator);
    }
}

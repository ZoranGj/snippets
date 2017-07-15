using CodeProcessor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProcessor.Files
{
    public interface IFileReader
    {
        string ReadContent(ProgrammingLanguage language);

        HashSet<string> ReadContentSeparated(ProgrammingLanguage language, char separator);
    }
}

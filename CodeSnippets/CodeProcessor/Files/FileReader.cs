using CodeProcessor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProcessor.Files
{
    public class FileReader : IFileReader
    {
        private string filePath;

        public FileReader()
        {
            filePath = string.Format("{0}/Data", AppDomain.CurrentDomain.BaseDirectory);
        }

        public string ReadContent(ProgrammingLanguage language)
        {
            var file = string.Format("{0}/{1}", filePath, GetFileName(language));
            if (!File.Exists(file)) throw new FileNotFoundException("Programming language file not exists.");

            var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                return streamReader.ReadToEnd();
            }
        }

        public HashSet<string> ReadContentSeparated(ProgrammingLanguage language, char separator)
        {
            throw new NotImplementedException();
        }

        //todo: change logic - create custom attribute in enumeration values
        private string GetFileName(ProgrammingLanguage language)
        {
            switch (language)
            {
                case ProgrammingLanguage.CSharp:
                    return "csharp.txt";
                case ProgrammingLanguage.CSS:
                    return "css.txt";
                case ProgrammingLanguage.HTML:
                    return "html.txt";
                case ProgrammingLanguage.Java:
                    return "java.txt";
                case ProgrammingLanguage.Javascript:
                    return "javascript.txt";
                default:
                    return null;
            }
        }
    }
}

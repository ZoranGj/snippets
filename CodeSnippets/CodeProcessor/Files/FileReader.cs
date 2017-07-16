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
            var file = GetFileName(language);
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

        public void UpdateContent(ProgrammingLanguage language, string content)
        {
            var file = GetFileName(language);
            if (!File.Exists(file)) throw new FileNotFoundException("Programming language file not exists.");

            var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
            using (var streamWriter = new StreamWriter(file))
            {
                streamWriter.WriteLine(content);
            }
        }

        public string GetFileName(ProgrammingLanguage language)
        {
            string file = null;
            switch (language)
            {
                case ProgrammingLanguage.CSharp:
                    file = "csharp.txt";
                    break;
                case ProgrammingLanguage.CSS:
                    file = "css.txt";
                    break;
                case ProgrammingLanguage.HTML:
                    file = "html.txt";
                    break;
                case ProgrammingLanguage.Java:
                    file = "java.txt";
                    break;
                case ProgrammingLanguage.Javascript:
                    file = "javascript.txt";
                    break;
                default:
                    return null;
            }

            return string.Format("{0}/{1}", filePath, file);
        }
    }
}

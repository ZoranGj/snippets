using NUnit.Framework;
using CodeProcessor.Files;
using CodeProcessor.Models;

namespace Tests
{
    [TestFixture]
    public class FileTests
    {
        private FileReader _fileReader;

        [OneTimeSetUp]
        public void Initialize()
        {
            _fileReader = new FileReader();
        }

        [TestCase(ProgrammingLanguage.CSharp)]
        [TestCase(ProgrammingLanguage.CSS)]
        [TestCase(ProgrammingLanguage.HTML)]
        [TestCase(ProgrammingLanguage.Java)]
        [TestCase(ProgrammingLanguage.Javascript)]
        public void FileByLanguage_OpenedSuccessfully(ProgrammingLanguage language)
        {
            string file = _fileReader.GetFileName(language);
            Assert.That(file, Is.Not.Null);
        }

        [Test]
        public void AddingCodeSnippet_FileUpdated()
        {
            string updateContent = @"public void Linq6() 
            { 
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
  
                var numsPlusOne = 
                    from n in numbers 
                    select n + 1; 
  
                foreach (var i in numsPlusOne)
                        {
                            Console.WriteLine(i);
                        }
            }";

            //content before updating
            string content = _fileReader.ReadContent(ProgrammingLanguage.CSharp);
            Assert.That(content, Is.Not.Empty);

            //update content
            _fileReader.UpdateContent(ProgrammingLanguage.CSharp, updateContent);

            //content after updating
            string newContent = _fileReader.ReadContent(ProgrammingLanguage.CSharp);
            Assert.That(newContent, Is.Not.Empty);
            Assert.That(newContent, Has.Length.GreaterThan(content));
        }
    }
}

using System;
using CodeProcessor.Common;

namespace CodeProcessor.NaiveBayes
{
    public class NaiveBayesProcessor : ILanguageComparer
    {
        public string[] IgnoreList
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string[] Tokenize(string codeSnippetText)
        {
            throw new NotImplementedException();
        }

        public string BestLanguageMatch(string[] codeSnippetTokenized)
        {
            throw new NotImplementedException();
        }

        public int OccurreancesByLanguage(string[] codeSnippetTokenized, string language)
        {
            throw new NotImplementedException();
        }

        public double ProbabilityByLanguage(string[] codeSnippetTokenized, string language)
        {
            throw new NotImplementedException();
        }
    }
}
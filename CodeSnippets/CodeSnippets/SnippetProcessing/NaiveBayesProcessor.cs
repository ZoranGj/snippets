using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSnippets.SnippetProcessing
{
    public class NaiveBayesProcessor : ITokenizer, ILanguageComparer
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
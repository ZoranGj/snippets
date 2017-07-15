using System.Collections.Generic;

namespace CodeProcessor.Logic.Interfaces
{
    public interface ITokenizer
    {
		HashSet<string> KeywordIgnoreList { get; }

		HashSet<string> OperatorIgnoreList { get; }

		HashSet<string> Tokenize(string codeSnippetText);
    }
}

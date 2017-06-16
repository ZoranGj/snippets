
namespace CodeSnippets.SnippetProcessing
{
    public interface ITokenizer
    {
        string [] IgnoreList { get; }

        string[] Tokenize(string codeSnippetText);
    }
}

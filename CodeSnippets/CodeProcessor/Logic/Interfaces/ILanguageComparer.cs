
namespace CodeProcessor.Logic.Interfaces
{
    public interface ILanguageComparer
    {
        int OccurreancesByLanguage(string [] codeSnippetTokenized, string language);

        double ProbabilityByLanguage(string[] codeSnippetTokenized, string language);

        string BestLanguageMatch(string[] codeSnippetTokenized);
    }
}


using System.Collections.Generic;

namespace CodeProcessor.Logic
{
    public interface IValidator
    {
        HashSet<string> IsValid(string target);
    }
}

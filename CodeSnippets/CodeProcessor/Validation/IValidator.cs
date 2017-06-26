
using System.Collections.Generic;

namespace CodeProcessor.Logic
{
    public interface IValidator
    {
        bool IsValid(string target);

        HashSet<string> ErrorMessages { get; set; }
    }
}

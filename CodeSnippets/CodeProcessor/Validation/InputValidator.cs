using CodeProcessor.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProcessor.Logic
{
    public class InputValidator : IValidator
    {
        public HashSet<string> IsValid(string target)
        {
            var validationMessages = new HashSet<string>();
            validationMessages.AddMessage(target.IsNotEmpty());
            return validationMessages;
        }
    }
}

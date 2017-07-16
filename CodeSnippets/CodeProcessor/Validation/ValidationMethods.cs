using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProcessor.Validation
{
    public static class ValidationMethods
    {
        public static string IsNotEmpty(this string content)
        {
            bool result = string.IsNullOrEmpty(content);
            return result ? "Content must not be empty." : null;
        }

        public static void AddMessage(this HashSet<string> messages, string message)
        {
            if (!string.IsNullOrEmpty(message)) messages.Add(message);
        }
    }
}

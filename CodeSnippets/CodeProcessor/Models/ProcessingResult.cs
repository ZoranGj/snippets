using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProcessor.Models
{
    public class ProcessingResult
    {
        public ProgrammingLanguage RecognizedLanguage { get; set; }
        public double Probability { get; set; }
        public string Note { get; set; }
    }
}

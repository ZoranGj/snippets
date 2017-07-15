using System;
using CodeProcessor.Models;

namespace CodeProcessor.NaiveBayes
{
    public class NaiveBayesProcessor : CodeProcessor.Logic.CodeProcessor
    {
        protected override string ProcessorInfo
        {
            get
            {
                return "Naive bayes processing";
            }
        }

        public override ProcessingResult Process(string input)
        {
            throw new NotImplementedException();
        }
    }
}
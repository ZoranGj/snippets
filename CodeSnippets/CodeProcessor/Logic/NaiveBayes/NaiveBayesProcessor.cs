using System;
using CodeProcessor.Models;
using CodeProcessor.Logic;
using CodeProcessor.Files;

namespace CodeProcessor.NaiveBayes
{
    public class NaiveBayesProcessor : Logic.CodeProcessor
    {
        public NaiveBayesProcessor(IFileReader _fileReader, IValidator _validator) : base(_fileReader, _validator) { }

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
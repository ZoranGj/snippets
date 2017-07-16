using System;
using CodeProcessor.Logic;
using CodeProcessor.Models;
using CodeProcessor.Files;

namespace CodeProcessor.SupportVectorMachine
{
    public class SVMProcessor : Logic.CodeProcessor
    {
        public SVMProcessor(IFileReader _fileReader, IValidator _validator) : base(_fileReader, _validator) { }

        protected override string ProcessorInfo
        {
            get
            {
                return "Support Vector Machine processing";
            }
        }

        public override ProcessingResult Process(string input)
        {
            throw new NotImplementedException();
        }
    }
}
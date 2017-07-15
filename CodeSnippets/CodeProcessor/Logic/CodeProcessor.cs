using System;
using System.Collections.Generic;
using CodeProcessor.Logic.Interfaces;
using CodeProcessor.Models;
using CodeProcessor.Files;

namespace CodeProcessor.Logic
{
	public abstract class CodeProcessor : ITokenizer, IProcessor {
        protected readonly IFileReader fileReader;
        protected readonly IValidator validator;
        protected HashSet<string> Keywords;
		protected HashSet<string> Operators;
		protected HashSet<string> CodeSnippetTokens;

        public CodeProcessor(IFileReader _fileReader, IValidator _validator)
        {
            fileReader = _fileReader;
            validator = _validator;
        }

		#region ITokenizer Members

		public HashSet<string> KeywordIgnoreList 
		{
			get { return Keywords = Keywords ?? new HashSet<string> { "if", "else", "while", "do", "for" }; }
		}

		public HashSet<string> OperatorIgnoreList {
			get { return Operators = Operators ?? new HashSet<string> { "||", "&&", "&", "|", "(", ")", "[", "]" }; }
		}

		public HashSet<string> Tokenize(string codeSnippetText) {
			if (string.IsNullOrEmpty(codeSnippetText)) return null;

			throw new NotImplementedException("Not implemented yet.");
		}

        #endregion

        public abstract ProcessingResult Process(string input);

        protected abstract string ProcessorInfo { get; }
    }
}

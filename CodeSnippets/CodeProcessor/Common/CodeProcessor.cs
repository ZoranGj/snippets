using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeProcessor.Common 
{
	public abstract class CodeProcessor : ITokenizer {
		protected HashSet<string> Keywords;
		protected HashSet<string> Operators;
		protected HashSet<string> CodeSnippetTokens;

		#region ITokenizer Members

		public HashSet<string> KeywordIgnoreList 
		{
			get { return Keywords = Keywords ?? new HashSet<string> { "if", "else", "while", "do", "for" }; }
		}

		public HashSet<string> OperatorIgnoreList {
			get { return Operators = Operators ?? new HashSet<string> { "||", "&&", "&", "|" }; }
		}

		public HashSet<string> Tokenize(string codeSnippetText) {
			if (string.IsNullOrEmpty(codeSnippetText)) return null;

			throw new NotImplementedException("Not implemented yet.");
		}

		#endregion
	}
}

using CodeProcessor.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class ValidationTests
    {
        private IValidator _inputValidator;

        [OneTimeSetUp]
        public void Initialize()
        {
            _inputValidator = new InputValidator();
        }

        [Test]
        public void EmptyCodeSnippet_NotValid()
        {
            string content = string.Empty;
            var result = _inputValidator.IsValid(content);
            Assert.That(result, Is.Not.Null, "Error messages result is not null");
            Assert.That(result, Has.Count.EqualTo(1), "One error message has been added");
        }
    }
}

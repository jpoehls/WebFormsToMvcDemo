using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TTFWebFormsToMvc.Web;

namespace TTFWebFormsToMvc.Tests.Web
{
    [TestFixture]
    public class JsonHelpersTests
    {
        [Test]
        public void JsonEncode_should_escape_characters_and_wrap_in_quotes()
        {
            // arrange
            // act
            string encoded = "A sentence with \"quoted\" 'portions'.".ToJsonString();
            
            // assert
            Assert.AreEqual("\"A sentence with \\\"quoted\\\" \\u0027portions\\u0027.\"", encoded);
        }
    }
}

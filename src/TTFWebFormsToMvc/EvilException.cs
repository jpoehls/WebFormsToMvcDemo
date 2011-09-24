using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTFWebFormsToMvc
{
    public class EvilException : ApplicationException
    {
        public EvilException(string message) : base(message) { }
    }
}

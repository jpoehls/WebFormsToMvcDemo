using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace TTFWebFormsToMvc.Web
{
    public static class JsonHelpers
    {
        private static JavaScriptSerializer Serializer = new JavaScriptSerializer();

        public static string ToJsonString(this string input)
        {
            return Serializer.Serialize(input);
        }
    }
}

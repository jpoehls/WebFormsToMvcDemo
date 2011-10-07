using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTFWebFormsToMvc.Web
{
    public class CustomRequestValidator : System.Web.Util.RequestValidator
    {
        private static readonly string[] ExcludedUrls = new[] {
            "~/samples/home/skip-validation"
        };

        protected override bool IsValidRequestString(System.Web.HttpContext context, string value, System.Web.Util.RequestValidationSource requestValidationSource, string collectionKey, out int validationFailureIndex)
        {
            // bypass validation for specific URLs
            if (ExcludedUrls.Any(url=>string.Equals(url, context.Request.AppRelativeCurrentExecutionFilePath, StringComparison.OrdinalIgnoreCase)))
            {
                validationFailureIndex = -1;
                return true;
            }

            return base.IsValidRequestString(context, value, requestValidationSource, collectionKey, out validationFailureIndex);
        }
    }
}

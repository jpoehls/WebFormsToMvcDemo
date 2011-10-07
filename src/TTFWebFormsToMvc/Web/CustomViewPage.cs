using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using TTFWebFormsToMvc.Security;

namespace TTFWebFormsToMvc.Web
{
    public class CustomViewPage : CustomViewPage<dynamic> { }

    public class CustomViewPage<TModel> : WebViewPage<TModel>
    {
        private ISecurityContext _securityContext;

        // views will have have access to this property
        public ISecurityContext SecurityContext { get { return _securityContext; } }

        public CustomViewPage()
        {
            _securityContext = new SecurityContext();
        }

        public override void Execute()
        {
            // Move along, there is nothing to see here.
        }
    }
}

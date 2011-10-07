using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using TTFWebFormsToMvc.Web;

namespace TTFWebFormsToMvc.Security
{
    public class SecurityContext : ISecurityContext
    {
        private HttpContextBase _context;

        public SecurityContext()
        {
            _context = HttpContext.Current.Wrap();
        }

        public string Username
        {
            get { return _context.User.Identity.Name; }
        }

        public bool UserIsInRole(string roleName)
        {
            return Roles.IsUserInRole(roleName);
        }
    }
}

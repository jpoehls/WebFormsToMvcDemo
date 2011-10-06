using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;

namespace TTFWebFormsToMvc.Security
{
    public class SecurityContext : ISecurityContext
    {
        private HttpContextBase _context;

        public SecurityContext(HttpContextBase context)
        {
            _context = context;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TTFWebFormsToMvc.Security
{
    public interface ISecurityContext
    {
        string Username { get; }
        bool UserIsInRole(string roleName);
    }
}

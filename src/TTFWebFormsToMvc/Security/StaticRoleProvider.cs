using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;

namespace TTFWebFormsToMvc.Security
{
    public class StaticRoleProvider : RoleProvider
    {
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotSupportedException();
        }

        public override string ApplicationName { get; set; }

        public override void CreateRole(string roleName)
        {
            throw new NotSupportedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotSupportedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotSupportedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotSupportedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            if (string.Equals("joshua", username, StringComparison.OrdinalIgnoreCase))
                return new[] { "admin" };

            return new string[] { };
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotSupportedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            if (string.Equals("joshua", username, StringComparison.OrdinalIgnoreCase) &&
                string.Equals("admin", roleName, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotSupportedException();
        }

        public override bool RoleExists(string roleName)
        {
            if (string.Equals("admin", roleName, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        }
    }
}

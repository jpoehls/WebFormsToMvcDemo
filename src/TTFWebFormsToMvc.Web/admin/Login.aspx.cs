using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TTFWebFormsToMvc.Web.Web.admin
{
    public partial class Login : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Logout.
            FormsAuthentication.SignOut();

            // Set default focus.
            SetFocus(txtUser);
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Validation.
            if (IsValid)
            {
                string username = txtUser.Text;
                string password = txtPassword.Text;

                // Authentication.
                bool authenticated = FormsAuthentication.Authenticate(username, password);

                if (authenticated)
                {
                    // Redirection.
                    FormsAuthentication.RedirectFromLoginPage(username, createPersistentCookie: false);
                    return;
                }
            }

            // Validation or authentication failed.
            ShowError("Login failed.");
        }
    }
}
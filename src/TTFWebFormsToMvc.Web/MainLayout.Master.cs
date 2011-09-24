using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TTFWebFormsToMvc.Web
{
    public partial class MainLayout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                lnkLogin.Text = "Logout";
                lnkLogin.NavigateUrl = "~/protected/logout.aspx";
                lblCurrentUser.Text = string.Format("({0})", Context.User.Identity.Name);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TTFWebFormsToMvc.Web.evil
{
    public partial class Throw : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            throw new EvilException("Mwahahaha!");
        }
    }
}
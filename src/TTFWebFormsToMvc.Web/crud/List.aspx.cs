using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TTFWebFormsToMvc.Data;

namespace TTFWebFormsToMvc.Web.crud
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            gv.DataSource = Product.GetAll();
            gv.DataBind();
        }
    }
}
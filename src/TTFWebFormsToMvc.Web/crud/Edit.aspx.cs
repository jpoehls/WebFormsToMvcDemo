using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TTFWebFormsToMvc.Data;

namespace TTFWebFormsToMvc.Web.crud
{
    public partial class Edit : System.Web.UI.Page
    {
        protected Product GetActiveProduct()
        {
            int editId;
            Int32.TryParse(Request.QueryString["id"], out editId);

            return Product.GetById(editId);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindListControls();
            }

            // init the JavaScript by passing in the ID of our shipping options checklist
            ClientScript.RegisterStartupScript(this.GetType(), "init",
                string.Format("EditPage.init({{cblShippingOptionsId: '{0}'}});",
                cblShippingOptions.ClientID), true);

            // get the product being edited
            var editProduct = GetActiveProduct();
            var isEdit = (editProduct != null);

            if (!IsPostBack && editProduct != null)
            {
                BindProduct(editProduct);
            }

            btnSave.Text = (isEdit ? "Save Changes" : "Create");
            btnDelete.Visible = isEdit;
        }

        private void BindProduct(Product p)
        {
            txtName.Text = p.Name;
            txtPrice.Text = p.Price.ToString("0.00");
            ddlCategory.SelectedValue = p.Category.Id.ToString();

            foreach (ListItem item in cblShippingOptions.Items)
            {
                if (p.ShippingOptions.Any(option => option.Id.ToString() == item.Value))
                {
                    item.Selected = true;
                }
            }

            rblStock.SelectedValue = p.Stock.Id.ToString();

        }

        private void BindListControls()
        {
            ddlCategory.DataSource = Category.GetAll();
            ddlCategory.DataTextField = "Name";
            ddlCategory.DataValueField = "Id";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("Select Category", string.Empty));

            cblShippingOptions.DataSource = ShippingOption.GetAll();
            cblShippingOptions.DataTextField = "Name";
            cblShippingOptions.DataValueField = "Id";
            cblShippingOptions.DataBind();

            rblStock.DataSource = StockOption.GetAll();
            rblStock.DataTextField = "Name";
            rblStock.DataValueField = "Id";
            rblStock.DataBind();
            rblStock.SelectedIndex = 0;
        }

        protected void ValidateShippingOptions(object sender, ServerValidateEventArgs e)
        {
            e.IsValid = cblShippingOptions.SelectedItem != null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Product.Delete(GetActiveProduct());

            Response.Redirect("list.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Ensure the validators passed. (Incase JavaScript was disabled on the client.)
            if (IsValid)
            {
                var p = GetActiveProduct() ?? new Product();
                p.Name = txtName.Text;
                p.Price = Decimal.Parse(txtPrice.Text);
                p.Category = Category.GetById(Int32.Parse(ddlCategory.SelectedValue));
                p.Stock = StockOption.GetById(Int32.Parse(rblStock.SelectedValue));

                p.ShippingOptions.Clear();
                foreach (ListItem item in cblShippingOptions.Items)
                {
                    if (item.Selected)
                    {
                        p.ShippingOptions.Add(ShippingOption.GetById(Int32.Parse(item.Value)));
                    }
                }

                Product.Save(p);
            }

            Response.Redirect("list.aspx");
        }
    }
}
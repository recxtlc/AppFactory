using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppFactoryRedone
{
    public partial class SuccessfulPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var QueryString = Request.QueryString.ToString();

            string message = QueryString.Replace("+", " ");

            textDynamicTextLabel.Text = message;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            HttpContext.Current.Response.Redirect("InternsDataTable.aspx");
        }

    }
}
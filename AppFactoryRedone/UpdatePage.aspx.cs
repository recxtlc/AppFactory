using AppFactoryRedone.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppFactoryRedone
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        private string requestID;
        private int interID;
        protected void Page_Load(object sender, EventArgs e)
        {
             requestID = Request.QueryString.ToString();
             interID = Int32.Parse(requestID);

            if(!IsPostBack)
            {
                var db = new AccessDB();
                db.QueryType = CommandType.StoredProcedure;
                db.QueryString = "GetSpeciedData";
                var internObj = db.ReadDataToUpdate(interID);

                first_name.Text = internObj.FirstName;
                last_name.Text = internObj.LastName;
                contact_number.Text = internObj.ContactNumber;
                email_address.Text = internObj.Email;
                Role.SelectedIndex = internObj.Role;
                PrimaryCheckBox.Checked = internObj.IsPrimary;
                IsBusinesCheckBox.Checked = internObj.IsBusiness;
                DOB.SelectedDate = DateTime.Parse(internObj.DateOfBirth);

            }

                
        }

        protected void sand_to_DB_Click(object sender, EventArgs e)
        {
            
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("InternsDataTable.aspx");
        }

        protected void Update_to_DB_Click(object sender, EventArgs e)
        {
            var db = new AccessDB();
            db.QueryType = CommandType.StoredProcedure;
            db.QueryString = "UpdateDataToAllTable";

            var intern = new InternData();

            intern.FirstName = first_name.Text;
            intern.LastName = last_name.Text;

            intern.FullName = first_name.Text  + " "+ last_name.Text;
            intern.ContactNumber = contact_number.Text;
            intern.Email = email_address.Text;
            intern.Role = Int32.Parse(Role.SelectedValue.ToString());
            intern.IsPrimary = PrimaryCheckBox.Checked;
            intern.IsBusiness = IsBusinesCheckBox.Checked;
            intern.DateOfBirth = DOB.SelectedDate.ToShortDateString();
            intern.personID = interID;
            db.Update(intern);

            string message = intern.FullName + " You have Sucessfully Updated Your Details";

            HttpContext.Current.Response.Redirect("SuccessfulPage.aspx?" + message);
        }

        protected void actie_Click(object sender, EventArgs e)
        {

        } 
    }
}
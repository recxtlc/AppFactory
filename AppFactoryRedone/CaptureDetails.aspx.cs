using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppFactoryRedone.Classes;
using System.Data;

namespace AppFactoryRedone
{
    public partial class CaptureDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

          
          //  System.Diagnostics.Debug.WriteLine(get.FirstName);

        }

        protected void sand_to_DB_Click(object sender, EventArgs e)
        {

            var intern = new InternData();
            var db = new AccessDB();
            
            intern.FirstName = first_name.Text;
            intern.LastName = last_name.Text;
           
            intern.FullName = first_name.Text +" "+ last_name.Text;


            intern.ContactNumber = contact_number.Text;
            intern.Email = email_address.Text;
            intern.Role = Int32.Parse(Role.SelectedValue.ToString());
            intern.IsPrimary = PrimaryCheckBox.Checked;
            intern.IsBusiness = IsBusinesCheckBox.Checked;
            intern.DateOfBirth = DOB.SelectedDate.ToShortDateString();

            db.QueryType = CommandType.StoredProcedure;
            db.QueryString = "InsertDataToAllTables";
             var get = db.InsertIntoDB(intern);

          

            var dob = DOB.SelectedDate.ToShortDateString();


            System.Diagnostics.Debug.WriteLine(intern.FirstName);

            System.Diagnostics.Debug.WriteLine(intern.LastName);
            System.Diagnostics.Debug.WriteLine(intern.ContactNumber);
            System.Diagnostics.Debug.WriteLine(intern.Email);
            System.Diagnostics.Debug.WriteLine(intern.DateOfBirth);
            System.Diagnostics.Debug.WriteLine(intern.Role);

            System.Diagnostics.Debug.WriteLine(intern.IsPrimary);

            System.Diagnostics.Debug.WriteLine(intern.IsBusiness);
            if (get > 0)
            {
                System.Diagnostics.Debug.WriteLine("Data Stored");
                var message = intern.FullName + " You have Sucessfully Registered Your Details";
                HttpContext.Current.Response.Redirect("SuccessfulPage.aspx?" + message);
            }


        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("Default.aspx");
        }
    }
}
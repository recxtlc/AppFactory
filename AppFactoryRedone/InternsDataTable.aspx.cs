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
    public partial class InternsDataTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var db = new AccessDB();

            db.QueryType = CommandType.StoredProcedure;
            db.QueryString = "GetDataTODisplay";
            var interList = db.ReadDataToTable();
            foreach (var intern in interList)
            {

                var row = new TableRow();
                var InterID = new TableCell();
                var Fullname = new TableCell();
                var DOB = new TableCell();
                var Email = new TableCell();
                var IsBusiness = new TableCell();
                var CellNumber = new TableCell();
                var IsPrimary = new TableCell();
                var buttonEdit = new TableCell();

                var butObj = new Button();
                butObj.Text = "Edit";
                butObj.Click += On_ObjClick;
                butObj.CssClass = "btn btn-primary";
                butObj.ID = intern.personID.ToString();
                row = new TableRow();
                InterID.Text = intern.personID.ToString();
                Fullname.Text = intern.FullName.ToString();

                DOB.Text = intern.DateOfBirth.ToString();
                Email.Text = intern.Email.ToString();
                IsBusiness.Text = intern.IsBusiness == true ? "Yes" : "No";
                CellNumber.Text = intern.ContactNumber.ToString();
                IsPrimary.Text = intern.IsPrimary == true ? "Yes" : "No";
                buttonEdit.Controls.Add(butObj);
                row.Cells.Add(InterID);

                row.Cells.Add(Fullname);
                row.Cells.Add(DOB);
                row.Cells.Add(Email);
                row.Cells.Add(IsBusiness);
                row.Cells.Add(CellNumber);
                row.Cells.Add(IsPrimary);
                row.Cells.Add(buttonEdit);
                internsDataTable.Rows.Add(row);

                System.Diagnostics.Debug.WriteLine(intern.FullName);
                System.Diagnostics.Debug.WriteLine(intern.Email);
            }

        }

        protected void On_ObjClick( object sander , EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Am clicked");

            var btnID = (Button)sander;


            HttpContext.Current.Response.Redirect("UpdatePage.aspx?"+btnID.ID);
                
          // HttpContext.Current.Response.Redirect($"UPDATE.aspx?{btn.ID}");//move to the next link i.e default.aspx
        }
    }
}
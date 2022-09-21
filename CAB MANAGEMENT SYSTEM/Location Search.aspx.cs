using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAB_MANAGEMENT_SYSTEM
{
    public partial class Location_Search : System.Web.UI.Page
    {

        
         
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            // Response.Redirect("querystring2.aspx?sname=" + txtSname.Text + "&sid=" + txtSid.Text);
          
           // Response.Redirect("Book Cab.aspx?q=" + txtSource.Value + "&dist=" + dist.value);

        }

        protected void lnklogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("User Login.aspx");
        }


    }
}
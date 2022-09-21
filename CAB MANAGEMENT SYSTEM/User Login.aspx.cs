using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;

namespace CAB_MANAGEMENT_SYSTEM
{
    public partial class User_Login : System.Web.UI.Page
    {

        string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        //user login
        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            string check = "select count(*) from [dbo].[register] where username='" + txtUid.Text + "' and password='" + txtPwd.Text + "'";
            SqlCommand cmd = new SqlCommand(check, con);
            con.Open();
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            if (temp == 1)
            {
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                Label3.Text = "Your username and password is incorrect";
                Label3.ForeColor = System.Drawing.Color.Red;
            }
            con.Close();

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("User Registration.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAB_MANAGEMENT_SYSTEM
{
    public partial class Register : System.Web.UI.Page
    {

        string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(constring);

            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[register]
           ([username]
           ,[phone]
           ,[email]
           ,[password])
     VALUES
            ('" + txtUname.Text + "','" + txtPno.Text + "','" + txtEmail.Text + "','" + txtPwd.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>('Registered Successfully')</script>");
            Response.Redirect("User Login.aspx");
        }
    }
}
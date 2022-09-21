using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAB_MANAGEMENT_SYSTEM
{
    public partial class Register : System.Web.UI.Page
    {
        string constring = System.Configuration.ConfigurationManager.AppSettings["constring"];
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Users values('" + txtUname.Text + "','" + txtPno.Text + "','" + txtEmail.Text + "','" + txtPwd.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>('Register Successfully')</script>");
                Response.Redirect("User Login.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>('Register Failed. User Name you choosed is already exist. please try with another username.')</script>");
            }

        }

       
    }
}
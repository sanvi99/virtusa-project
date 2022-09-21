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
            SqlCommand cmd = new SqlCommand("select * from userregitration where username=@username and word=@word", con);
            cmd.Parameters.AddWithValue("@username", txtUid.Text);
            cmd.Parameters.AddWithValue("word", txtPwd.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (dt.Rows.Count > 0)
            {
                Response.Redirect("Driver Details.aspx");
            }
            else
            {
                Label3.Text = "Your username and word is incorrect";
                Label3.ForeColor = System.Drawing.Color.Red;

            }

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("User Registration.aspx");
        }
    }
}
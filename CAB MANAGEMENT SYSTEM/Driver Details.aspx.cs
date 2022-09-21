using Newtonsoft.Json.Linq;
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
    public partial class Driver_Details : System.Web.UI.Page
    {
        string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GVdriver();
            }
        }
         void clear( )
        {
            txtDname.Text = "";
            txtDpno.Text = "";
            txtDemail.Text = " ";
            txtCabmodel.Text = "";
            txtFare.Text = "";
            txtLocation.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[cabdetails]
           ([Driver_name]
           ,[Driver_phone]
           ,[Driver_email]
           ,[Cabmodel]
           ,[Fare]
           ,[Location])
     VALUES
          ('" + txtDname.Text + "','" + txtDpno.Text + "','" + txtDemail.Text + "','" + txtCabmodel.Text + "','" + txtFare.Text + "','" + txtLocation.Text + "')", con);

                int t = cmd.ExecuteNonQuery();
                if (t > 0)
                {
                    Response.Write("<script>('Data has been submitted Successfully')</script>");
                    GVdriver();
                }
                clear();
            }
        }

        protected void lnklogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txtDname.Text = "";
            txtDpno.Text = "";
            txtDemail.Text = " ";
            txtCabmodel.Text = "";
            txtFare.Text = "";
            txtLocation.Text = "";

        }
        protected void GVdriver()
        {
            using(SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[cabdetails]",con);
                SqlDataReader dr = cmd.ExecuteReader(); 
                if (dr.HasRows==true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }
        }
    }

}
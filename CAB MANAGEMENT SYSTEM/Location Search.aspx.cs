using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Xml.Linq;

namespace CAB_MANAGEMENT_SYSTEM
{
    public partial class Location_Search : System.Web.UI.Page
    {

        string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GVlocation();
            }
        }
        void clear()
        {
            txtsource.Text = "";
            txtdestination.Text = "";
        }
        protected void GVlocation()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[locationdetails]", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }

            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[locationdetails]
                ([Locations]
           ,[Destination])
     VALUES('" + txtsource.Text + "','" + txtdestination.Text + "')", con);

                int t = cmd.ExecuteNonQuery();
                if (t > 0)
                {
                    Response.Write("<script>('Data has been submitted Successfully')</script>");

                }
                clear();
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("Book Cab.aspx");

        }

        protected void lnklogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("User Login.aspx");
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            string source = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string destination = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update [dbo].[locationdetails] set L_id='"+id+"', Locations='" + source + "',Destination='" + destination + "'", con);
                int t = cmd.ExecuteNonQuery();
                if (t > 0)
                {
                    Response.Write("<script>alter('Data has updated')</script>");
                    GridView1.EditIndex = -1;
                    GVlocation();
                }
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GVlocation();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from [dbo].[locationdetails] where L_id='" + id + "'", con);
                int t = cmd.ExecuteNonQuery();
                if (t > 0)
                {

                    Response.Write("<script>alter('Data has deleted')</script>");
                    GridView1.EditIndex = -1;
                    GVlocation();
                }
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GVlocation();
        }
    }
}
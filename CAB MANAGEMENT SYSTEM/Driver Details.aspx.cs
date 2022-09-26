using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace CAB_MANAGEMENT_SYSTEM
{
    public partial class Driver_Details : System.Web.UI.Page
    {

        string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GVbind();
            }

        }
        void clear()
        {
            txtDname.Text = "";
            txtDpno.Text = "";
            txtDemail.Text = " ";
            txtCabmodel.Text = "";
            txtFare.Text = "";
            txtLocation.Text = "";

        }
        protected void GVbind()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[cabdetails]", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                }
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[cabdetails]
           ([Driver_id]
           ,[Driver_name]
           ,[Driver_phone]
           ,[Driver_email]
           ,[Cabmodel]
           ,[Fare]
           ,[Locations])
     VALUES
          ('" + txtDid.Text + "','" + txtDname.Text + "','" + txtDpno.Text + "','" + txtDemail.Text + "','" + txtCabmodel.Text + "','" + txtFare.Text + "','" + txtLocation.Text + "')", con);

                int t = cmd.ExecuteNonQuery();
                if (t > 0)
                {
                    Response.Write("<script>('Data has been submitted Successfully')</script>");
                    Response.Redirect("Location Search.aspx");
                    GVbind();
                }
                clear();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txtDid.Text = " ";
            txtDname.Text = "";
            txtDpno.Text = "";
            txtDemail.Text = " ";
            txtCabmodel.Text = "";
            txtFare.Text = "";
            txtLocation.Text = "";

        }

        protected void lnklogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Location Search.aspx");
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string phone = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string email = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string cabmodel = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string fare = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
            string location = ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text;
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update [dbo].[cabdetails] set Driver_id='" + id + "', Driver_name='" + name + "',Driver_phone='" + phone + "',Driver_email='" + email + "',Cabmodel='" + cabmodel + "',Fare='" + fare + "',Locations='" + location + "' ", con);
                int t = cmd.ExecuteNonQuery();
                if (t > 0)
                {
                    Response.Write("<script>alter('Data has updated')</script>");
                    GridView1.EditIndex = -1;
                    GVbind();
                }
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GVbind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GVbind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from [dbo].[cabdetails] where Driver_id='" + id + "'", con);
                int t = cmd.ExecuteNonQuery();
                if (t > 0)
                {

                    Response.Write("<script>alter('Data has updated')</script>");
                    GridView1.EditIndex = -1;
                    GVbind();
                }
            }
        }
    }
}
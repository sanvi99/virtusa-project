using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;

namespace CAB_MANAGEMENT_SYSTEM
{
    public partial class Book_Cab : System.Web.UI.Page
    {

        string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(constring);
                string query = "select c.Driver_id,c.Driver_name,c.Driver_phone,c.Cabmodel,c.Fare,c.Locations  from cabdetails c join locationdetails l on c.Locations = l.Locations";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    GridView3.DataSource = ds.Tables[0];
                    GridView3.DataBind();
                }
           
            }

        }
        protected void btnRevise_Click(object sender, EventArgs e)
        {
            Response.Redirect("Location Search.aspx");
        }

        protected void lnklogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("User Login.aspx");
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = GridView3.SelectedRow;
            Response.Redirect("Booked Details.aspx?id=" +gr.Cells[0].Text+ "&name=" +gr.Cells[1].Text+"&phone=" +gr.Cells[2].Text+"&cabmodel=" +gr.Cells[3].Text+"&fare=" +gr.Cells[4].Text+"&location=" +gr.Cells[5].Text+"");
        }
    }
}
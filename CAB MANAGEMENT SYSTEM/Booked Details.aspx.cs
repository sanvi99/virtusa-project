using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace CAB_MANAGEMENT_SYSTEM
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtDid.Text = Request.QueryString["id"].ToString();
            txtDname.Text = Request.QueryString["name"].ToString();
            txtDpno.Text = Request.QueryString["phone"].ToString();
            txtCabmodel.Text = Request.QueryString["cabmodel"].ToString();
            txtFare.Text = Request.QueryString["fare"].ToString();
            txtLocation.Text = Request.QueryString["location"].ToString();
            Label1.Text = "cab is booked with above details";
        }

    }
}
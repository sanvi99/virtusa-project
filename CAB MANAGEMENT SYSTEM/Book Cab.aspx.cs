﻿using System;
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

namespace CAB_MANAGEMENT_SYSTEM
{
    public partial class Book_Cab : System.Web.UI.Page
    {

        string constring = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con;
        string sourcepalce;
        string dist;
        protected void Page_Load(object sender, EventArgs e)
        {
            sourcepalce = Request.QueryString["q"].ToString();
            dist = Request.QueryString["dist"];
            if (!IsPostBack)
            {
                con = new SqlConnection(constring);
                string query = "select c.CabID,c.CabModel,c.Fare,c.Location,d.DriverPhno,d.DriverName,c.fare,d.DriverId,d.DriverEmail from CabDetails c join DriversDetails d on d.CabId=c.CabId where lower(c.Locaion) like '%" + sourcepalce.ToString().ToLower().Substring(0, sourcepalce.IndexOf(',')) + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                }
                else
                {
                    lblFare.Font.Size = 18;
                    lblFare.ForeColor = System.Drawing.Color.Red;
                    lblFare.Text = "No Cabs are available.";
                }
            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SelectCab")
            {
                LinkButton btn = e.CommandSource as LinkButton;
                GridViewRow gr = btn.NamingContainer as GridViewRow;
                string demail = (string)GridView1.DataKeys[gr.RowIndex]["DriverEmail"];
                int fare = (int)GridView1.DataKeys[gr.RowIndex]["fare"];
                string DriverPhno = (string)GridView1.DataKeys[gr.RowIndex]["DriverPhno"];
                double distance = Convert.ToDouble(dist.Substring(0, dist.IndexOf("km")));
                double approxFare = fare * distance;
                lblFare.Font.Size = 18;
                lblFare.ForeColor = System.Drawing.Color.Red;
                lblFare.Text = "Approxmate fare for your trip is: $" + approxFare.ToString();
                sendemail(demail, "Your customer phone number is " + Session["PhNo"].ToString() + ". Please contact with customer");
                if (Session["EmailId"] != null)
                    sendemail(Session["EmailId"].ToString(), "Your cab driver phone number is " + DriverPhno + ". Please contact with him for any query.");
            }
        }
        public void sendemail(string to, string message)
        {
            try
            {

                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(
                  "jellasanghavi2018@gmail.com", "sanghavijella");
                MailMessage msg = new MailMessage();
                msg.To.Add(to);
                msg.From = new MailAddress("jellasanghavi2018@gmail.com");
                msg.Subject = "Booking cab..";
                msg.Body = message;

                client.Send(msg);
            }
            catch (Exception ex)
            { }
        }

        protected void btnRevise_Click(object sender, EventArgs e)
        {
            Response.Redirect("Location Search.aspx");
        }

        protected void lnklogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("User Login.aspx");
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAB_MANAGEMENT_SYSTEM
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("User Login.aspx");
        }
    }
}
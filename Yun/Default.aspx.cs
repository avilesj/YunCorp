﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DATLYR;

namespace Yun
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbConnect cnStr = new dbConnect();
            TextBox1.Text = cnStr.connect();
        }
    }
}

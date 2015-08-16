using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yun
{
    public partial class NuevoDept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Departamentos.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BSNLYR.bsnssDept emp = new BSNLYR.bsnssDept();
            emp.registrarDept(TextBox1.Text, int.Parse(TextBox2.Text));
            Response.Redirect("Departamentos.aspx");
        }
    }
}
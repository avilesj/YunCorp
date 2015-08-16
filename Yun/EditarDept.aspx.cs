using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yun
{
    public partial class EditarDept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BSNLYR.bsnssDept emp = new BSNLYR.bsnssDept();
                emp.consultarID(int.Parse(Request["id"]));
                TextBox1.Text = emp.dept_nombre;
                Label2.Text = int.Parse(emp.dept_id).ToString();
                Label1.Text = emp.dept_gerente;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Departamentos.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BSNLYR.bsnssDept objEd = new BSNLYR.bsnssDept();
            objEd.actualizarDept(int.Parse(Label2.Text), TextBox1.Text);
            Response.Redirect("Departamentos.aspx");
        }
    }
}
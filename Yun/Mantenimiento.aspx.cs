using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Yun
{
    public partial class Mantenimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           DataTable dtTable = new DataTable();
           BSNLYR.bsnssEmployee emp = new BSNLYR.bsnssEmployee();
           dtTable = emp.ConsultarCliente(TextBox1.Text, 1);
           GridView1.DataSource = dtTable;
           GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = int.Parse(e.CommandArgument.ToString());

            if (e.CommandName.CompareTo("selectEmp") == 0)
            {
                Response.Redirect("EditarEmp.aspx?id="+ GridView1.Rows[indice].Cells[1].Text);
            }
        }

    }
}
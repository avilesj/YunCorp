using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Yun
{
    public partial class Departamentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dtTable = new DataTable();
                BSNLYR.bsnssDept emp = new BSNLYR.bsnssDept();
                dtTable = emp.consultarTodos();
                GridView1.DataSource = dtTable;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            {
                int indice = int.Parse(e.CommandArgument.ToString());

                if (e.CommandName.CompareTo("selectReg") == 0)
                {
                    Response.Redirect("EditarDept.aspx?id=" + GridView1.Rows[indice].Cells[1].Text);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mantenimiento.aspx");
        }

        protected void NuevoDept_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoDept.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Yun
{
    public partial class Reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dtTable = new DataTable();
                BSNLYR.bsnssDept emp2 = new BSNLYR.bsnssDept();
                dtTable = emp2.consultarDept();
                txtDept.DataSource = dtTable;
                txtDept.DataTextField = "Departamentos";
                txtDept.DataValueField = "Departamentos";
                txtDept.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mantenimiento.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int parametro = 8;
            DataTable dtTable = new DataTable();
            BSNLYR.bsnssEmployee emp = new BSNLYR.bsnssEmployee();
            dtTable = emp.ConsultarCliente(txtDept.SelectedValue, parametro);
            GridView1.DataSource = dtTable;
            GridView1.DataBind();
        }
    }
}
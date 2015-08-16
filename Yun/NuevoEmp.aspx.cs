using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BSNLYR;
using System.Data;

namespace Yun
{
    public partial class NuevoEmp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dtTable = new DataTable();
            BSNLYR.bsnssDept emp2 = new BSNLYR.bsnssDept();
            dtTable = emp2.consultarDept();
            txtDept.DataSource = dtTable;
            txtDept.DataTextField = "Departamentos";
            txtDept.DataValueField = "Departamentos";
            txtDept.DataBind();
        }

        protected void guardar_Click(object sender, EventArgs e)
        {
            bsnssEmployee emp = new bsnssEmployee();
            emp.registrarEmpleado(txtNombre.Text, txtApellido.Text,
                                txtCedula.Text, txtExtension.Text, txtFlota.Text,
                                txtDept.SelectedIndex + 1);
            Response.Redirect("Mantenimiento.aspx");
        }

        protected void cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mantenimiento.aspx");
        }
    }
}
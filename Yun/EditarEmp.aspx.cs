using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlTypes;

namespace Yun
{
    public partial class EditarEmp : System.Web.UI.Page
    {
 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BSNLYR.bsnssEmployee emp = new BSNLYR.bsnssEmployee();
                emp.selectEmployee(Request["id"], 7);
                txtNombre.Text = emp.emp_nombre;
                txtApellido.Text = emp.emp_apellido;
                txtCedula.Text = emp.emp_cedula;
                txtExtension.Text = emp.emp_ext;
                txtFlota.Text = emp.emp_flota;
                txtDept.Text = emp.dept_id;
                lbCod.Text = int.Parse(emp.emp_id).ToString();
            }
        }

        protected void guardar_Click(object sender, EventArgs e)
        {

            BSNLYR.bsnssEmployee emp = new BSNLYR.bsnssEmployee();
            emp.guardarEmpleado(int.Parse(lbCod.Text), txtNombre.Text, txtApellido.Text,
                                txtCedula.Text, txtExtension.Text, txtFlota.Text,
                                1);
        }

        protected void eliminar_Click(object sender, EventArgs e)
        {
            BSNLYR.bsnssEmployee emp = new BSNLYR.bsnssEmployee();
            emp.eliminarEmpleado(int.Parse(lbCod.Text));
            Response.Redirect("Mantenimiento.aspx");
        }

        protected void cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mantenimiento.aspx");
        }
    }
}
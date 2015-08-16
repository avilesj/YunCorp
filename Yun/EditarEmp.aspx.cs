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
         //   txtNombre.Text = int.Parse(lbCod.Text).ToString();
         //   txtApellido.Text = int.Parse(txtDept.Text).ToString();

            BSNLYR.bsnssEmployee emp = new BSNLYR.bsnssEmployee();
            emp.guardarEmpleado(int.Parse(lbCod.Text), txtNombre.Text, txtApellido.Text,
                                txtCedula.Text, txtExtension.Text, txtFlota.Text,
                                1);
        }
    }
}
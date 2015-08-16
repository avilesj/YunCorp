using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yun
{
    public partial class EditarEmp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           BSNLYR.bsnssEmployee emp = new BSNLYR.bsnssEmployee();
           emp.selectEmployee(Request["id"], 7);
           txtNombre.Text = emp.emp_nombre;
           txtApellido.Text = emp.emp_apellido;
           txtCedula.Text = emp.emp_cedula;
           txtExtension.Text = emp.emp_ext;
           txtFlota.Text = emp.emp_flota;
           txtDept.Text = emp.dept_id;
        }
    }
}
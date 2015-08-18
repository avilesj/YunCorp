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
            if (!IsPostBack)
            {
                DataTable dtTable = new DataTable();
                BSNLYR.bsnssDDL emp = new BSNLYR.bsnssDDL();
                dtTable = emp.obtenerDDL();
                DropDownList1.DataSource = dtTable;
                DropDownList1.DataTextField = "Parametros";
                DropDownList1.DataValueField = "Parametros";
                DropDownList1.DataBind();
                DropDownList1.SelectedValue = "General";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int parametro = 0;

            if (DropDownList1.SelectedItem.Text == "Nombre")
            {
                parametro = 1;
            }


            if (DropDownList1.SelectedItem.Text == "Apellido")
            {
                parametro = 2;
            }


            if (DropDownList1.SelectedItem.Text == "Cedula")
            {
                parametro = 3;
            }

            if (DropDownList1.SelectedItem.Text == "Codigo Departamento")
            {
                parametro = 4;
            }

            if (DropDownList1.SelectedItem.Text == "Extension")
            {
                parametro = 5;
            }

            if (DropDownList1.SelectedItem.Text == "Flota")
            {
                parametro = 6;
            }
            if (DropDownList1.SelectedItem.Text == "General")
            {
                parametro = 8;
            }
           DataTable dtTable = new DataTable();
           BSNLYR.bsnssEmployee emp = new BSNLYR.bsnssEmployee();
           dtTable = emp.ConsultarCliente(TextBox1.Text, parametro);
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoEmp.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Departamentos.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reporte.aspx");
        }


    }
}
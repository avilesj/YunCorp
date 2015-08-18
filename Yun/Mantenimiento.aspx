<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mantenimiento.aspx.cs" Inherits="Yun.Mantenimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Busqueda</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Width="383px"></asp:TextBox>
        buscar por:
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Buscar" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Nuevo Empleado" />
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
            Text="Departamentos" />
    </p>
    <asp:GridView ID="GridView1" runat="server" onrowcommand="GridView1_RowCommand" 
        Width="309px">
        <Columns>
            <asp:ButtonField ButtonType="Button" CausesValidation="True" 
                CommandName="selectEmp" Text="Button" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
        Text="Reporte" />
</asp:Content>

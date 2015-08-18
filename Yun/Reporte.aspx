<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="Yun.Reporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    REPORTE DE EMPLEADOS POR DEPARTAMENTO<br />
    Departamento:
    <asp:DropDownList ID="txtDept" runat="server" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
&nbsp;
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Generar" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Atras" />
</asp:Content>

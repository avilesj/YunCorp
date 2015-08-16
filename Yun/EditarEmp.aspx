<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarEmp.aspx.cs" Inherits="Yun.EditarEmp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        CODIGO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbCod" runat="server" Text="Label"></asp:Label>
    </p>
    NOMBRE&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <br />
    <br />
   APELLIDO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
    <br />
    <br />
    CEDULA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
    <br />
    <br />
    EXTENSION&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ;
    <asp:TextBox ID="txtExtension" runat="server"></asp:TextBox>
    <br />
    <br />
    FLOTA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtFlota" runat="server"></asp:TextBox>
    <br />
    <br />
    DEPARTAMENTO<asp:TextBox ID="txtDept" runat="server" style="text-align: center"></asp:TextBox>
    <br />
</asp:Content>

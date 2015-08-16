<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mantenimiento.aspx.cs" Inherits="Yun.Mantenimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headcontent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Width="383px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </p>
    <asp:GridView ID="GridView1" runat="server" onrowcommand="GridView1_RowCommand" 
        Width="309px">
        <Columns>
            <asp:ButtonField ButtonType="Button" CausesValidation="True" 
                CommandName="selectEmp" Text="Button" />
        </Columns>
    </asp:GridView>
</asp:Content>

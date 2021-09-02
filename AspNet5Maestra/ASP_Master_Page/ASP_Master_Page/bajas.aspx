<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="bajas.aspx.cs" Inherits="ASP_Master_Page.bajas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>> BAJAS</h2>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Id a eliminar"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="id" DataValueField="id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:simulacroSQLConnectionString %>" SelectCommand="SELECT [id] FROM [cliente]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
        <br />
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="pellido1" HeaderText="pellido1" SortExpression="pellido1" />
            <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
            <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
            <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:simulacroSQLConnectionString %>" SelectCommand="SELECT * FROM [cliente]"></asp:SqlDataSource>
    <asp:Label ID="Resultado" runat="server" Text=""></asp:Label>
    
</asp:Content>

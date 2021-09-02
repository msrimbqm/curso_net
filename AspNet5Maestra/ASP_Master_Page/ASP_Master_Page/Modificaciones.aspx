<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modificaciones.aspx.cs" Inherits="ASP_Master_Page.Modificaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

    <h2>Modificaciones de clientes</h2>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Id:  "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="id" DataValueField="id"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:simulacroSQLConnectionString %>" SelectCommand="SELECT [id] FROM [cliente]"></asp:SqlDataSource>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
     </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Nombre:  "></asp:Label>

        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Apellido 1:  "></asp:Label>

        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
    </div>
    <div>

        <asp:Label ID="Label4" runat="server" Text="Apellido 2 :  "></asp:Label>

        <asp:TextBox ID="txtApellido2" runat="server"></asp:TextBox>
    </div>
    <div>

         <asp:Label ID="Label5" runat="server" Text="Ciudad : "></asp:Label>

        <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
    </div>
    <div>

        <asp:Label ID="Label6" runat="server" Text="Categoria : "></asp:Label>

        <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
    </div>

        </div>
    <asp:Button ID="btnModi" runat="server" Text="Modificar" OnClick="btnModi_Click" />
    <asp:Label ID="LabelResultado" runat="server" Text=""></asp:Label>



</div>

</asp:Content>

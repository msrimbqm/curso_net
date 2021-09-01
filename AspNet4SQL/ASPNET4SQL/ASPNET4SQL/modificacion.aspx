<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificacion.aspx.cs" Inherits="ASPNET4SQL.modificacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>MODIFICACION </h1>
             <asp:Label ID="Label1" runat="server" Text="Nombre Usuario:"></asp:Label>

            <asp:TextBox ID="txtNombreUsuario" runat="server" Width="226px"></asp:TextBox>
            <br />
            </br>
            <asp:Button ID="btnModificar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" Width="74px" />
            <br />
            </br>
             <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
             <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
         
            </br>
             <asp:Label ID="Label3" runat="server" Text="Mail:"></asp:Label>
             <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
            <br />
            </br>
            <asp:Button ID="btnModi" runat="server" OnClick="btnModi_Click" Text="Modificar" />
            </br>
             <asp:Label ID="Resultado" runat="server" Text=""></asp:Label>
            <br />
            </br>
            <a href="Default.aspx">Volver</a>


        </div>
    </form>
</body>
</html>

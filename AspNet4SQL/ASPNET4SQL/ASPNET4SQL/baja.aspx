<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="baja.aspx.cs" Inherits="ASPNET4SQL.baja" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>BAJAS </h1>

            <asp:Label ID="Label1" runat="server" Text="Nombre Usuario:"></asp:Label>

            <asp:TextBox ID="txtNombreUsuario" runat="server" Width="226px"></asp:TextBox>
            <br />
            </br>
            <asp:Button ID="btnbaja" runat="server" Text="Borrar" OnClick="btnBuscar_Click" />
            <br />
            </br>
             <asp:Label ID="Resultado" runat="server" Text=""></asp:Label>
            <br />
            </br>
            <a href="Default.aspx">Volver</a>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alta.aspx.cs" Inherits="ASPNET4SQL.alta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>ALTAS </h1>
            
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Rellene el cuadro de texto" ControlToValidate="txtNombre">
             </asp:RequiredFieldValidator>
            </br>

            <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
             <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
         
            </br>
             <asp:Label ID="Label3" runat="server" Text="Mail:"></asp:Label>
             <asp:TextBox ID="txtMail" runat="server" TextMode="Email"></asp:TextBox>
            </br>
            </br>

            <asp:Button ID="btnAlta" runat="server" Text="Alta" OnClick="btnAlta_Click" />
            <asp:Label ID="labelresultado" runat="server" Text=""></asp:Label>

            </br>

            </br>
            <a href="Default.aspx">Volver</a>



        </div>
    </form>
</body>
</html>

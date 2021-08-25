<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPNET1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="StyleSheet1.css" />


<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" BackColor="#FF6699" Text="1"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sumar" />
        </p>
        <asp:Label ID="Label2" runat="server" Text="Primer Valor"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Segundo Valor"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:RadioButton ID="Sumar" Groupname="x" runat="server" Text="Sumar" />
        <br />
        <br />
        <asp:RadioButton ID="Restar" Groupname="x" runat="server" Text="Restar" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Resultado" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Resultado"></asp:Label>
        <br />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Sumar</asp:ListItem>
            <asp:ListItem>Restar</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btncalcular2" runat="server" Height="27px" OnClick="btncalcular2_Click" Text="Resultado2" Width="97px" />
        <br />
    </form>
</body>
</html>

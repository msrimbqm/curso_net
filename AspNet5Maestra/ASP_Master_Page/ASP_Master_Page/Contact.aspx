<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ASP_Master_Page.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Mi pagina de contacto</h3>
    <address>
         Yavio City<br />
         Oerlora - Asturies<br />
        <abbr title="Telf">P:</abbr>
        334567</address>
    <address>
         &nbsp;<img alt="" src="img/delta.jpg" style="width: 123px; height: 79px; margin-right: 0px" /></address>

    <address>
        <strong>Soporte:</strong>   <a href="mailto:Soporte@nasa.gov">Support@nasa.gob</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@enasa.gov">Marketing@nasa.gob</a></address>
</asp:Content>

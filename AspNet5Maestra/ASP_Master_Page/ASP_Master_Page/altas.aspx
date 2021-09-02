<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="altas.aspx.cs" Inherits="ASP_Master_Page.altas" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
    <link href="css/StyleSheet1.css" rel="stylesheet"/>
    



    </br> </br>

    <h2>Altas de clientes</h2>


    <div class="filas">
        <div class="titulos">
        <asp:Label ID="Label1" runat="server" Text="Id:  "></asp:Label>
        </div>
        <div class="controles">
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        </div>
    </div>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Rellene el cuadro de texto" ControlToValidate="txtId">
             </asp:RequiredFieldValidator>
       
	
     
    <div class="filas">
        <div class="titulos">
            <asp:Label ID="Label2" runat="server" Text="Nombre:  "></asp:Label>
        </div>
        <div class="controles">
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="filas">
         <div class="titulos">
            <asp:Label ID="Label3" runat="server" Text="Apellido 1:  "></asp:Label>
        </div>
        <div class="controles">
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="filas">
         <div class="titulos">

            <asp:Label ID="Label4" runat="server" Text="Apellido 2 :  "></asp:Label>
        </div>
        <div class="controles">
        <asp:TextBox ID="txtApellido2" runat="server"></asp:TextBox>
         </div>
    </div>
    <div class="filas">
         <div class="titulos">

         <asp:Label ID="Label5" runat="server" Text="Ciudad : "></asp:Label>
         </div>
        <div class="controles">
        <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="filas">
         <div class="titulos">

        <asp:Label ID="Label6" runat="server" Text="Categoria : "></asp:Label>
         </div>
        <div class="controles">
        <asp:TextBox ID="txtCategoria" runat="server" TextMode="Number"></asp:TextBox>
        </div>

    </div>





    </br>
    </br>

        <asp:Button class="boton" ID="btnAlta" runat="server" Text="Añadir" OnClick="btnAlta_Click" />

        </>

    </br>

    <asp:Label ID="LabelResultado" runat="server" Text=""></asp:Label>

</div> 


</asp:Content>



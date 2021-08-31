<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPnet3_validacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="/css/estilos.css"  rel="stylesheet" type="text/css">

    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div id="DV1" class="flexbox">
        <asp:Label runat="server" Text="Nombre Usuario:"></asp:Label>
        <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
   
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Rellene el cuadro de texto" ControlToValidate="txtNombreUsuario">
             </asp:RequiredFieldValidator>
        </br></br>

        
            <asp:Label runat="server" Text="Clave:"></asp:Label>
        <asp:TextBox ID="txtClave1" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Rellene el cuadro de texto" ControlToValidate="txtClave1">
             </asp:RequiredFieldValidator>
        </br></br>

        
            <asp:Label runat="server" Text="Repita Clave:"></asp:Label>
        <asp:TextBox ID="txtClave2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Rellene el cuadro de texto" ControlToValidate="txtClave2">
             </asp:RequiredFieldValidator>
      
       <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="No iguales" Text="" ControlToCompare="txtClave1" ControlToValidate="txtClave2"></asp:CompareValidator>
       </br></br>
       


        <asp:Label runat="server" Text="Correo:"></asp:Label>
        <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email"></asp:TextBox> 
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Mail Incorrecto" ControlToValidate="txtCorreo" ValidationExpression="(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|&quot;(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*&quot;)@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])"></asp:RegularExpressionValidator> 

        </br></br>

       

        <asp:Label runat="server" Text="Apellido:"></asp:Label>
        <asp:TextBox ID="txtApellido2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Rellene el cuadro de texto" ControlToValidate="txtApellido2">
             </asp:RequiredFieldValidator>
        </br></br>

        
        <asp:Label runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Rellene el cuadro de texto" ControlToValidate="txtNombre">
             </asp:RequiredFieldValidator>
        
        </br></br>

    

        <asp:Label runat="server" Text="Pais Origen:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem> Argelia </asp:ListItem>
            <asp:ListItem> España </asp:ListItem>
            <asp:ListItem>Japon </asp:ListItem>
    
        </asp:DropDownList>

        </br></br>

        <asp:Label runat="server" Text="Comentarios:"></asp:Label>
        <asp:Label runat="server" Text="Provincia:"></asp:Label>
        <asp:TextBox ID="txtProvincia" runat="server"></asp:TextBox>
        
        </br></br>
        

        <asp:Label runat="server" Text="Codigo Postal:"></asp:Label>
        <asp:TextBox ID="txtCP" runat="server" TextMode="Number"></asp:TextBox>
           
        </br></br>

        
        <asp:Label runat="server" Text="Sexo:"></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" text="Hombre" GroupName="a" Checked="true"/>
            <asp:RadioButton ID="RadioButton2" runat="server" text="Mujer" GroupName="a"/>
        </br></br>

      
         <asp:Label runat="server" Text="Fecha Nacimiento :"></asp:Label>
           <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

        </br></br>

    

        <asp:Label runat="server" Text="Comentarios:"></asp:Label>

        <asp:TextBox ID="TextBox1" runat="server" Height="95px" Width="393px"></asp:TextBox>
                                      

        </br>    </br> 

        <asp:Label runat="server" Text="Acepto los terminos y condiciones:"></asp:Label>

         <asp:CheckBox ID="CheckBox1" runat="server" checked="false" Text=""/>
            
       
            <asp:Label ID="labelfinal" runat="server" Text=""></asp:Label>
       
            </br>    </br>

            <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" />


        </div>
    </form>
</body>
</html>


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CuestionarioASP._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/estilos.css" />
     <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
                        
               
                    <div ID="x">
                        <asp:Image ID="Image1" runat="server" src="img/vacaypollo.png" />
                    </div>

                 <h2>  La receta de arroz con leche, lleva arroz?</h2>

                 <asp:RadioButton ID="RadioButton1" runat="server" GroupName="A" Text="Si, lo lleva" /> 
                </br>
                  <asp:RadioButton ID="RadioButton2" runat="server" GroupName="A" Text="No lo lleva" />
                </br>
                 <asp:RadioButton ID="RadioButton3" runat="server" GroupName="A" Text="Depende del cocinero" />
                </br>
        <br />
        <br />

        </div>
          <div>
        
                        
               <h2> La receta de Cachopo, lleva Pescado?</h2>

                 <asp:RadioButton ID="RadioButton4" runat="server" GroupName="B" Text="Si, lo lleva" /> 
                </br>
                  <asp:RadioButton ID="RadioButton5" runat="server" GroupName="B" Text="No lo lleva" />
                </br>
                 <asp:RadioButton ID="RadioButton6" runat="server" GroupName="B" Text="Depende del cocinero" />
                </br>
        <br />
        <br />

        </div>

        <div>
        
                        
               <h2> La receta de Fabes con almejas, lleva moluscos?</h2>

                 <asp:RadioButton ID="RadioButton7" runat="server" GroupName="C" Text="Si, lo lleva" /> 
                </br>
                  <asp:RadioButton ID="RadioButton8" runat="server" GroupName="C" Text="No lo lleva" />
                </br>
                 <asp:RadioButton ID="RadioButton9" runat="server" GroupName="C" Text="Depende del cocinero" />
                </br>
                
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Rellene el cuadro de texto" ControlToValidate="TextBox1">

                     Debe introducir algo en este cuadro

                </asp:RequiredFieldValidator>

                <h3> INTRUDUCE VALORES ENTRES 1 Y 99</h3>
               <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Error de rango" Text="El valor no esta rango permito" ControlToValidate="TextBox2" MaximumValue="99" MinimumValue="0" Type="Integer">

                    Rango no permitido

                </asp:RangeValidator>


            <h3> EJEMPLO COMPARE VALIDATOR DEBEN SER IGUALES </h3>
                Contraseña
               <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            </br>
                  Repita contraseña         
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>                                  
            </br>

             <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="No iguales" Text="No coinciden" ControlToCompare="TextBox3" ControlToValidate="TextBox4"></asp:CompareValidator>


            </br></br>

                 <asp:Button ID="Button1" runat="server" Text="RESULTADO" OnClick="Button1_Click" />

        <br />
            
        </div>

        </br>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </br>
        
                

                


        </div>
       

        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    </form>
       

        <br />
</body>
</html>

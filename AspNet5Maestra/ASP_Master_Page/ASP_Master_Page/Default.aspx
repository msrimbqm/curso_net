<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_Master_Page._Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Aplicacion de gestion MSR</h1>
        <p class="lead">Para mas informacion ,pulsa</p>
        <p><a href="http://www.mamadapa.tk" class="btn btn-primary btn-lg">Acerca de MSR &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Panel de Comerciales</h2>
            <p>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource2">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                        <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
                        <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
                        <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
                        <asp:BoundField DataField="comision" HeaderText="comision" SortExpression="comision" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:simulacroSQLConnectionString2 %>" SelectCommand="SELECT * FROM [comercial]"></asp:SqlDataSource>
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948"> &raquo;</a></p>
        </div>
        <div class="col-md-4">
            <h2>Panel de Clientes</h2>
            
               
            <p>
                &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                        <asp:BoundField DataField="pellido1" HeaderText="pellido1" SortExpression="pellido1" />
                        <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
                        <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
                        <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:simulacroSQLConnectionString %>" SelectCommand="SELECT * FROM [cliente]"></asp:SqlDataSource>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Panel de Pedidos</h2>
            <p>

            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource3" Height="173px" Width="375px">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="cantidad" HeaderText="cantidad" SortExpression="cantidad" />
                    <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
                    <asp:BoundField DataField="id_cliente" HeaderText="id_cliente" SortExpression="id_cliente" />
                    <asp:BoundField DataField="Id_comercial" HeaderText="Id_comercial" SortExpression="Id_comercial" />
                </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:simulacroSQLConnectionString3 %>" SelectCommand="SELECT * FROM [pedido]"></asp:SqlDataSource>
                </p>
            
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>

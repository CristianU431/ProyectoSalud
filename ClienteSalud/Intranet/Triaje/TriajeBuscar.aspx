<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Triaje/MPTriaje.master" AutoEventWireup="true" CodeBehind="TriajeBuscar.aspx.cs" Inherits="ClienteSalud.Intranet.Triaje.TriajeBuscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Buscar para la Tabla Triaje -->
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <h3>Buscar en la Tabla Triaje</h3>
    <p> Texto: <asp:TextBox runat="server" Id="txtTexto"/></p>
    <p>&nbsp;</p>
    <p> Criterio: <asp:TextBox runat="server" Id="txtCriterio"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Buscar" runat="server" Id="btnBuscar" OnClick="btnBuscar_Click"/>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:GridView runat="server" ID ="gvTriaje"></asp:GridView>
    </p>

</asp:Content>

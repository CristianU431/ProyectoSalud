<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Historial/MPHistorial.master" AutoEventWireup="true" CodeBehind="HistorialBuscar.aspx.cs" Inherits="ClienteSalud.Intranet.Historial.HistorialBuscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Buscar para la Tabla Historial -->
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <h3>Buscar en la Tabla Historial</h3>
    <p> Texto: <asp:TextBox runat="server" Id="txtTexto"/></p>
    <p>&nbsp;</p>
    <p> Criterio: <asp:TextBox runat="server" Id="txtCriterio"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Buscar" runat="server" Id="btnBuscar" OnClick="btnBuscar_Click"/>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:GridView runat="server" ID ="gvHistorial"></asp:GridView>
    </p>

</asp:Content>

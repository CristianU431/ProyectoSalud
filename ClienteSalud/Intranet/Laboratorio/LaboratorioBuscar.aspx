<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Laboratorio/MPLaboratorio.master" AutoEventWireup="true" CodeBehind="LaboratorioBuscar.aspx.cs" Inherits="ClienteSalud.Intranet.Laboratorio.LaboratorioBuscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Buscar para la Tabla Laboratorio -->
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <h3>Buscar en la Tabla Analisis de Laboratorio</h3>
    <p> Texto: <asp:TextBox runat="server" Id="txtTexto"/></p>
    <p>&nbsp;</p>
    <p> Criterio: <asp:TextBox runat="server" Id="txtCriterio"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Buscar" runat="server" Id="btnBuscar" OnClick="btnBuscar_Click"/>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:GridView runat="server" ID ="gvLaboratorio"></asp:GridView>
    </p>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Consultorio/MPConsultorio.master" AutoEventWireup="true" CodeBehind="ConsultorioBuscar.aspx.cs" Inherits="ClienteSalud.Intranet.Consultorio.ConsultorioBuscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Buscar para la Tabla Consultorio -->
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <h3>Buscar en la Tabla Consultorio</h3>
    <p> Texto: <asp:TextBox runat="server" Id="txtTexto"/></p>
    <p>&nbsp;</p>
    <p> Criterio: <asp:TextBox runat="server" Id="txtCriterio"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Buscar" runat="server" Id="btnBuscar" OnClick="btnBuscar_Click"/>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:GridView runat="server" ID ="gvConsultorio"></asp:GridView>
    </p>

</asp:Content>

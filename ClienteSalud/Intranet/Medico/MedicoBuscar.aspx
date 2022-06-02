<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Medico/MPMedico.master" AutoEventWireup="true" CodeBehind="MedicoBuscar.aspx.cs" Inherits="ClienteSalud.Intranet.Medico.MedicoBuscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Buscar para la Tabla Medico -->
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <h3>Buscar en la Tabla Medico</h3>
    <p> Texto: <asp:TextBox runat="server" Id="txtTexto"/></p>
    <p>&nbsp;</p>
    <p> Criterio: <asp:TextBox runat="server" Id="txtCriterio"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Buscar" runat="server" Id="btnBuscar" OnClick="btnBuscar_Click"/>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:GridView runat="server" ID ="gvMedico"></asp:GridView>
    </p>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Medicamentos/MPMedicamentos.master" AutoEventWireup="true" CodeBehind="MedicamentosBuscar.aspx.cs" Inherits="ClienteSalud.Intranet.Medicamentos.MedicamentosBuscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Buscar para la Tabla Medicamentos -->
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <h3>Buscar en la Tabla Medicamentos</h3>
    <p> Texto: <asp:TextBox runat="server" Id="txtTexto"/></p>
    <p>&nbsp;</p>
    <p> Criterio: <asp:TextBox runat="server" Id="txtCriterio"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Buscar" runat="server" Id="btnBuscar" OnClick="btnBuscar_Click"/>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:GridView runat="server" ID ="gvMedicamentos"></asp:GridView>
    </p>

</asp:Content>

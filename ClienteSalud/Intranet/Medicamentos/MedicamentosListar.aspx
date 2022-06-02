<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Medicamentos/MPMedicamentos.master" AutoEventWireup="true" CodeBehind="MedicamentosListar.aspx.cs" Inherits="ClienteSalud.Intranet.Medicamentos.MedicamentosListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">

    <!-- Listar para la Tabla Medicamentos -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>Tabla Medicamentos</h3>

    <p>
        <asp:GridView runat="server" ID ="gvMedicamentos"></asp:GridView>
    </p>

</asp:Content>

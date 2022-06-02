<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Laboratorio/MPLaboratorio.master" AutoEventWireup="true" CodeBehind="LaboratorioListar.aspx.cs" Inherits="ClienteSalud.Intranet.Laboratorio.LaboratorioListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">

    <!-- Listar para la Tabla AnalisisLaboratorio -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>Tabla Analisis de Laboratorio</h3>

    <p>
        <asp:GridView runat="server" ID ="gvLaboratorio"></asp:GridView>
    </p>

</asp:Content>

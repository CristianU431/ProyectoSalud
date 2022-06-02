<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Consultorio/MPConsultorio.master" AutoEventWireup="true" CodeBehind="ConsultorioListar.aspx.cs" Inherits="ClienteSalud.Intranet.Consultorio.ConsultorioListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">

    <!-- Listar para la Tabla Consultorio -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>Tabla Consultorio</h3>

    <p>
        <asp:GridView runat="server" ID ="gvConsultorio"></asp:GridView>
    </p>

</asp:Content>

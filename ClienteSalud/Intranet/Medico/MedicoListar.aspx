<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Medico/MPMedico.master" AutoEventWireup="true" CodeBehind="MedicoListar.aspx.cs" Inherits="ClienteSalud.Intranet.Medico.MedicoListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">

    <!-- Listar para la Tabla Medico -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>Tabla Medico</h3>

    <p>
        <asp:GridView runat="server" ID ="gvMedico"></asp:GridView>
    </p>

</asp:Content>

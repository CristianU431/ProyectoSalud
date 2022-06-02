<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Historial/MPHistorial.master" AutoEventWireup="true" CodeBehind="HistorialListar.aspx.cs" Inherits="ClienteSalud.Intranet.Historial.HistorialListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">

    <!-- Listar para la Tabla Historial -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>Tabla Historial</h3>

    <p>
        <asp:GridView runat="server" ID ="gvHistorial"></asp:GridView>
    </p>

</asp:Content>

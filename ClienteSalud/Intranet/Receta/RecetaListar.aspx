<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Receta/MPReceta.master" AutoEventWireup="true" CodeBehind="RecetaListar.aspx.cs" Inherits="ClienteSalud.Intranet.Receta.RecetaListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">

    <!-- Listar para la Tabla Receta -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>Tabla Receta</h3>

    <p>
        <asp:GridView runat="server" ID ="gvReceta"></asp:GridView>
    </p>

</asp:Content>

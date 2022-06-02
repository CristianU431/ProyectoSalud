<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Triaje/MPTriaje.master" AutoEventWireup="true" CodeBehind="TriajeListar.aspx.cs" Inherits="ClienteSalud.Intranet.Triaje.TriajeListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">

    <!-- Listar para la Tabla Triaje -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>Tabla Triaje</h3>

    <p>
        <asp:GridView runat="server" ID ="gvTriaje"></asp:GridView>
    </p>

</asp:Content>

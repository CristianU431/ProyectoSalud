<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Especialidad/MPEspecialidad.master" AutoEventWireup="true" CodeBehind="EspecialidadListar.aspx.cs" Inherits="ClienteSalud.Intranet.Especialidad.EspecialidadListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">

    <!-- Listar para la Tabla Especialidad -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>Tabla Especialidad</h3>

    <p>
        <asp:GridView runat="server" ID ="gvEspecialidad"></asp:GridView>
    </p>

</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Especialidad/MPEspecialidad.master" AutoEventWireup="true" CodeBehind="EspecialidadBuscar.aspx.cs" Inherits="ClienteSalud.Intranet.Especialidad.EspecialidadBuscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Buscar para la Tabla Especialidad -->
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    <h3>Buscar en la Tabla Especialidad</h3>
    <p> Texto: <asp:TextBox runat="server" Id="txtTexto"/></p>
    <p>&nbsp;</p>
    <p> Criterio: <asp:TextBox runat="server" Id="txtCriterio"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Buscar" runat="server" Id="btnBuscar" OnClick="btnBuscar_Click"/>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:GridView runat="server" ID ="gvEspecialidad"></asp:GridView>
    </p>

</asp:Content>

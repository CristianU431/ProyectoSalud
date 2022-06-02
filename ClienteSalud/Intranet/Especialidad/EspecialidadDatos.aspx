<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Especialidad/MPEspecialidad.master" AutoEventWireup="true" CodeBehind="EspecialidadDatos.aspx.cs" Inherits="ClienteSalud.Intranet.Especialidad.EspecialidadDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Formulario del CRUD para la tabla Especialidad -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>CRUD de la tabla Especialidad</h3>

    <p> Id: <asp:TextBox runat="server" Id="txtId"/></p>
    <p>&nbsp;</p>

    <p> Nombre de Especialidad: <asp:TextBox runat="server" Id="txtNombreEspecialidad"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click"/>
    </p>

</asp:Content>

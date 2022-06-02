<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Paciente/MPPaciente.master" AutoEventWireup="true" CodeBehind="PacienteDatos.aspx.cs" Inherits="ClienteSalud.Intranet.Paciente.PacienteDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Formulario del CRUD para la tabla Paciente -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>CRUD de la tabla Paciente</h3>

    <p> Dni: <asp:TextBox runat="server" Id="txtDni"/></p>
    <p>&nbsp;</p>

    <p> Nombre del Paciente: <asp:TextBox runat="server" Id="txtNombrePaciente"/></p>
    <p>&nbsp;</p>
    <p> Apellido del Paciente: <asp:TextBox runat="server" Id="txtApellidoPaciente"/></p>
    <p>&nbsp;</p>
    <p> Dirección: <asp:TextBox runat="server" Id="txtDireccion"/></p>
    <p>&nbsp;</p>
    <p> Genero: <asp:TextBox runat="server" Id="txtGenero"/></p>
    <p>&nbsp;</p>
    <p> Fecha de Nacimiento: <asp:TextBox runat="server" Id="txtFechaNacimiento"/></p>
    <p>&nbsp;</p>

    <p> 
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click"/>
    </p>

</asp:Content>

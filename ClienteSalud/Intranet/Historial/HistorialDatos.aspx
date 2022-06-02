<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Historial/MPHistorial.master" AutoEventWireup="true" CodeBehind="HistorialDatos.aspx.cs" Inherits="ClienteSalud.Intranet.Historial.HistorialDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Formulario del CRUD para la tabla Historial -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>CRUD de la tabla Historial</h3>

    <p> Id: <asp:TextBox runat="server" Id="txtId"/></p>
    <p>&nbsp;</p>

    <p> Dni del Paciente: <asp:TextBox runat="server" Id="txtDni"/></p>
    <p>&nbsp;</p>
    <p> Fecha de Entrada: <asp:TextBox runat="server" Id="txtFechaEntrada"/></p>
    <p>&nbsp;</p>
    <p> Fecha de Alta: <asp:TextBox runat="server" Id="txtFechaAlta"/></p>
    <p>&nbsp;</p>
    <p> Codigo del Medico: <asp:TextBox runat="server" Id="txtCodMedico"/></p>
    <p>&nbsp;</p>
    <p> Id del Consultorio: <asp:TextBox runat="server" Id="txtIdConsultorio"/></p>
    <p>&nbsp;</p>
    <p> Id de Receta: <asp:TextBox runat="server" Id="txtIdReceta"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click"/>
    </p>

</asp:Content>

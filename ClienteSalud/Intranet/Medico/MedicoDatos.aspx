<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Medico/MPMedico.master" AutoEventWireup="true" CodeBehind="MedicoDatos.aspx.cs" Inherits="ClienteSalud.Intranet.Medico.MedicoDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Formulario del CRUD para la tabla Medico -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>CRUD de la tabla Medico</h3>

    <p> Codigo del Medico: <asp:TextBox runat="server" Id="txtCod"/></p>
    <p>&nbsp;</p>

    <p> Nombre del Medico: <asp:TextBox runat="server" Id="txtNombreMedico"/></p>
    <p>&nbsp;</p>
    <p> Apellido del Medico: <asp:TextBox runat="server" Id="txtApellidoMedico"/></p>
    <p>&nbsp;</p>
    <p> Id de la Especialidad: <asp:TextBox runat="server" Id="txtIdEspecialidad"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click"/>
    </p>

</asp:Content>

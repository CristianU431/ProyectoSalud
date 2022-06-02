<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Consultorio/MPConsultorio.master" AutoEventWireup="true" CodeBehind="ConsultorioDatos.aspx.cs" Inherits="ClienteSalud.Intranet.Consultorio.ConsultorioDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Formulario del CRUD para la tabla Consultorio -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>CRUD de la tabla Consultorio</h3>

    <p> Id: <asp:TextBox runat="server" Id="txtId"/></p>
    <p>&nbsp;</p>

    <p> Numero de Consultorio: <asp:TextBox runat="server" Id="txtNumConsultorio"/></p>
    <p>&nbsp;</p>
    <p> Codigo de Medico: <asp:TextBox runat="server" Id="txtCodMedico"/></p>
    <p>&nbsp;</p>
    <p> Id de la Especialidad: <asp:TextBox runat="server" Id="txtIdEspecialidad"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click"/>
    </p>


</asp:Content>

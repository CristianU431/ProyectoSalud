<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Laboratorio/MPLaboratorio.master" AutoEventWireup="true" CodeBehind="LaboratorioDatos.aspx.cs" Inherits="ClienteSalud.Intranet.Laboratorio.LaboratorioDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Formulario del CRUD para la tabla Laboratorio -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>CRUD de la tabla Laboratorio</h3>

    <p> Id: <asp:TextBox runat="server" Id="txtId"/></p>
    <p>&nbsp;</p>

    <p> Tipo de Laboratorio: <asp:TextBox runat="server" Id="txtTipoLab"/></p>
    <p>&nbsp;</p>
    <p> Nombre de Laboratorio: <asp:TextBox runat="server" Id="txtNombreLab"/></p>
    <p>&nbsp;</p>
    <p> Dni del Paciente: <asp:TextBox runat="server" Id="txtDni"/></p>
    <p>&nbsp;</p>
    <p> Resultado de Laboratorio: <asp:TextBox runat="server" Id="txtResul"/></p>
    <p>&nbsp;</p>
    <p> Codigo de Medico: <asp:TextBox runat="server" Id="txtCodMedico"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click"/>
    </p>

</asp:Content>

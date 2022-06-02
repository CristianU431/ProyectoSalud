<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Receta/MPReceta.master" AutoEventWireup="true" CodeBehind="RecetaDatos.aspx.cs" Inherits="ClienteSalud.Intranet.Receta.RecetaDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Formulario del CRUD para la tabla Receta -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>CRUD de la tabla Receta</h3>

    <p> Id: <asp:TextBox runat="server" Id="txtId"/></p>
    <p>&nbsp;</p>

    <p> Dni del Paciente: <asp:TextBox runat="server" Id="txtDni"/></p>
    <p>&nbsp;</p>
    <p> Enfermedad: <asp:TextBox runat="server" Id="txtEnfermedad"/></p>
    <p>&nbsp;</p>
    <p> Id de Medicamentos: <asp:TextBox runat="server" Id="txtIdMedicamentos"/></p>
    <p>&nbsp;</p>
    <p> Descripcion: <asp:TextBox runat="server" Id="txtDescipcion"/></p>
    <p>&nbsp;</p>
    <p> Fecha de Inicio: <asp:TextBox runat="server" Id="txtFechaInicio"/></p>
    <p>&nbsp;</p>
    <p> Feca Limite: <asp:TextBox runat="server" Id="txtFechaLimite"/></p>
    <p>&nbsp;</p>
    <p> Tipo de Receta: <asp:TextBox runat="server" Id="txtTipoReceta"/></p>
    <p>&nbsp;</p>
    <p> Codigo del Medico: <asp:TextBox runat="server" Id="txtCodMedico"/></p>
    <p>&nbsp;</p>
    <p> Id del Consultorio: <asp:TextBox runat="server" Id="txtIdConsultorio"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click"/>
    </p>

</asp:Content>

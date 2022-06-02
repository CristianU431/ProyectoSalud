<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Triaje/MPTriaje.master" AutoEventWireup="true" CodeBehind="TriajeDatos.aspx.cs" Inherits="ClienteSalud.Intranet.Triaje.TriajeDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Formulario del CRUD para la tabla Triaje -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>CRUD de la tabla Triaje</h3>

    <p> Id: <asp:TextBox runat="server" Id="txtId"/></p>
    <p>&nbsp;</p>

    <p> Dni del Paciente: <asp:TextBox runat="server" Id="txtDni"/></p>
    <p>&nbsp;</p>
    <p> Talla del Paciente: <asp:TextBox runat="server" Id="txtTalla"/></p>
    <p>&nbsp;</p>
    <p> Sintomas del Paciente: <asp:TextBox runat="server" Id="txtSintomas"/></p>
    <p>&nbsp;</p>
    <p> Peso del Paciente: <asp:TextBox runat="server" Id="txtPeso"/></p>
    <p>&nbsp;</p>
    <p> Temperatura del Paciente: <asp:TextBox runat="server" Id="txtTemperatura"/></p>
    <p>&nbsp;</p>
    
    <p> 
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click"/>
    </p>

</asp:Content>

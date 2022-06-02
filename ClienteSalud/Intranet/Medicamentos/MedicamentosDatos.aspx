<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Medicamentos/MPMedicamentos.master" AutoEventWireup="true" CodeBehind="MedicamentosDatos.aspx.cs" Inherits="ClienteSalud.Intranet.Medicamentos.MedicamentosDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">
    
    <!-- Formulario del CRUD para la tabla Medicamentos -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>CRUD de la tabla Medicamentos</h3>

    <p> Id: <asp:TextBox runat="server" Id="txtId"/></p>
    <p>&nbsp;</p>

    <p> Nombre de Medicamentos: <asp:TextBox runat="server" Id="txtNombreMedicamentos"/></p>
    <p>&nbsp;</p>
    <p> Tipo de Medicamentos: <asp:TextBox runat="server" Id="txtTipMedicamentos"/></p>
    <p>&nbsp;</p>
    <p> Detalle: <asp:TextBox runat="server" Id="txtDetalle"/></p>
    <p>&nbsp;</p>
    <p> Cantidad: <asp:TextBox runat="server" Id="txtCantidad"/></p>
    <p>&nbsp;</p>
    <p> 
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click"/>
    </p>

</asp:Content>

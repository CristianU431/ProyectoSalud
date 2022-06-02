<%@ Page Title="" Language="C#" MasterPageFile="~/Intranet/Paciente/MPPaciente.master" AutoEventWireup="true" CodeBehind="PacienteListar.aspx.cs" Inherits="ClienteSalud.Intranet.Paciente.PacienteListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contendoPrincipal" runat="server">

    <!-- Listar para la Tabla Paciente -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>Tabla Paciente</h3>

    <p>
        <asp:GridView runat="server" ID ="gvPaciente"></asp:GridView>
    </p>

</asp:Content>

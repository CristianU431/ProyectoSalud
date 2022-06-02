<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="ClienteSalud.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>INICIO DE SESIÓN POSTA MÉDICA SAN JERÓNIMO</title>

    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&display=swap" 
        rel="stylesheet"/>
    <link rel="stylesheet" href="/Imagenes/estilos.css"/>

</head>
<body>
    <main>

        <div class="contenedor__todo">
            <div class="caja__trasera">
                <div class="caja__trasera-login">
                    <h3>Coloque su cuenta Actual</h3>
                    <p>Inicia sesión para ingresar al sistema</p>
                    <button id="btn__iniciar-sesion">Iniciar Sesión</button>
                </div>
                <div class="caja__trasera-register">
                    <h3>Cree su cuenta nueva</h3>
                    <p>Regístrese para ingresar al sistema</p>
                    <button id="btn__registrarse">Regístrarse</button>
                </div>
            </div>

            <!--Formulario de Login y registro-->
            <div class="contenedor__login-register">
                <!--Login-->
                <form action="" class="formulario__login" runat ="server">
                    
                    <h2>Iniciar Sesión</h2>
                    <asp:TextBox ID="txtUsuario" placeholder="Ingrese Usuario" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtContrasenia" placeholder="Contraseña" runat="server" TextMode ="Password"></asp:TextBox>
                    <asp:Button ID="btnAgregar" runat="server" Text="Ingresar" OnClick="btnAgregar_Click"/>
                    <!--<button ID ="btnAgregar2" runat="server">Ingresar</button>-->
                </form>

                <!--Register-->
                <form action="" class="formulario__register">
                    <h2>Registro de Pacientes</h2>
                    <input type="text" placeholder="Nombre completo"/>
                    <input type="text" placeholder="Correo Electronico"/>
                    <input type="text" placeholder="Usuario"/>
                    <input type="password" placeholder="Contraseña"/>
                    <button>Registrarse</button>
                </form>
            </div>
        </div>
    </main>
    <script src="script.js"></script>
</body>
</html>

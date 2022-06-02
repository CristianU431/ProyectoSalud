using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaDato;
using CapaNegocio;

using System.Web.Security;

namespace ClienteSalud
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            verificarUser();
        }

        private void verificarUser()
        {
            try
            {
                string user = txtUsuario.Text.Trim();
                string contrasenia = txtContrasenia.Text.Trim();

                CapaDato.logindc.Login datousuario = new CapaDato.logindc.Login();
                datousuario = LogicUsuarios.getEmailxPass(user, CapaNegocio.Autentificacion.encriptar.GetMD5Hash(contrasenia));
                if (datousuario != null)
                {
                    FormsAuthentication.RedirectFromLoginPage(user, false);
                }
                else
                {
                    Response.Write("<script>alert('El Usuario o Contraseña es invalida')</script>");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato.logindc;

namespace CapaNegocio
{
    public class LogicUsuarios
    {
        private static dcLoginDataContext dc = new dcLoginDataContext();

        public static Login getEmailxPass(string Usuario, string Contrasenia)
        {
            try
            {
                var usuario = dc.Login.Where(user => user.Usuario.Equals(Usuario)
                                              && user.Contrasenia.Equals(Contrasenia)).FirstOrDefault();

                return usuario;
            }
            catch (Exception)
            {
                throw new Exception("Usuario no encontrado.");
            }

        }
    }
}

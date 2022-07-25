using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAppp
{
    [TestClass]
    public class IdentificarUsuario
    {
        [TestMethod]
        public void IdentificarUsuario_CuandoRecibeUnPasswordYNombreDeUsuarioQueEstaEnLaBaseDeDatos_DebeRetornarTrue()
        {
            string password = "1234";
            string nombreUsuario = "rtejeda";

            Assert.IsTrue(UsuarioDTV.IdentificarUsuarioSQL(nombreUsuario, password));
        }
    }
}

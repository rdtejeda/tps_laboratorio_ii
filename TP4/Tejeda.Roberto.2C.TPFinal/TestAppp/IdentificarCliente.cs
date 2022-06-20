using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestAppp
{
    [TestClass]
    public class IdentificarCliente
    {
        [TestMethod]
        public void IdentificarCliente_CuandoRecibeUnDNIQueEstaEnLaBaseDeDatos_DebeRetornarClienteConMismoDni()
        {
            string dni = "18223125";

            Assert.AreEqual(ClienteDTV.IdentificarCliente(dni).Dni, dni);
        }
    }
}

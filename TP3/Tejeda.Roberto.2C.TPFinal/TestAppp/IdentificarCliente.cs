using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Entidades;


namespace TestAppp
{
    [TestClass]
    public class IdentificarCliente
    {
        [TestMethod]
        public void IdentificarCliente_CuandoRecibeUnDNIQueEstaEnLaBaseDeDatos_DebeRetornarCliente()
        {
            List<Servicio.ESenialesPremiun> listasnial = new List<Servicio.ESenialesPremiun>();
            listasnial.Add(Servicio.ESenialesPremiun.HBO);
            listasnial.Add(Servicio.ESenialesPremiun.Paramount);
            listasnial.Add(Servicio.ESenialesPremiun.FutbolArgentino);
            listasnial.Add(Servicio.ESenialesPremiun.NBA);
            listasnial.Add(Servicio.ESenialesPremiun.Star);
            ClienteDTV cliente = new ClienteDTV("18223125", "Roberto", "Tejeda", "Amoedo 234",
            new Servicio(Servicio.EServicios.DTVGo, Servicio.EFormaPago.TarjetaCredito, Servicio.ECantidadDecos.Dos, listasnial));
            string dni = "18223125";
            Assert.AreEqual<ClienteDTV>((ClienteDTV.IdentificarCliente(dni)),cliente);
        }
    }
}

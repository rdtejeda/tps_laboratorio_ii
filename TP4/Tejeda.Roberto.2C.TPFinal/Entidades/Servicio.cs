using System.Collections.Generic;

namespace Entidades
{
    public class Servicio
    {
        public enum EServicios
        {
            NoActivo, DTVGo, Plata, Oro
        }
        public enum EFormaPago
        {
            TarjetaCredito, TarjetaDebito
        }
        public enum ESenialesPremiun
        {
            HBO, Star, Paramount, FutbolArgentino, NBA
        }
        public enum ECantidadDecos
        {
            Cero, Uno, Dos, Tres, Cuatro, Cinco
        }
        private EServicios servivio;
        private EFormaPago formaPago;
        private ECantidadDecos cantidadDecos;
        private List<ESenialesPremiun> senialPremium;
        public Servicio()
        {
            this.SenialPremium = new List<ESenialesPremiun>();
        }
        public Servicio(EServicios servivio, EFormaPago formaPago, ECantidadDecos cantidadDecos, List<ESenialesPremiun> senialPremium)
        {
            this.servivio = servivio;
            this.formaPago = formaPago;
            this.cantidadDecos = cantidadDecos;
            this.senialPremium = senialPremium;
        }
        public EServicios Servivio { get => servivio; set => servivio = value; }
        public EFormaPago FormaPago { get => formaPago; set => formaPago = value; }
        public ECantidadDecos CantidadDecos { get => cantidadDecos; set => cantidadDecos = value; }
        public List<ESenialesPremiun> SenialPremium { get => senialPremium; set => senialPremium = value; }
    }
}

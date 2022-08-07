using System.Collections.Generic;
using System.Text;

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
        private EServicios servicio;
        private EFormaPago formaPago;
        private ECantidadDecos cantidadDecos;
        private List<ESenialesPremiun> senialPremium;
        public Servicio()
        {
            this.SenialPremium = new List<ESenialesPremiun>();
        }
        public Servicio(EServicios servivio, EFormaPago formaPago, ECantidadDecos cantidadDecos, List<ESenialesPremiun> senialPremium)
        {
            this.servicio = servivio;
            this.formaPago = formaPago;
            this.cantidadDecos = cantidadDecos;
            this.senialPremium = senialPremium;
        }
        public EServicios Servivio { get => servicio; set => servicio = value; }
        public EFormaPago FormaPago { get => formaPago; set => formaPago = value; }
        public ECantidadDecos CantidadDecos { get => cantidadDecos; set => cantidadDecos = value; }
        public List<ESenialesPremiun> SenialPremium { get => senialPremium; set => senialPremium = value; }

        /// <summary>
        /// Sobreescritura de Servicio
        /// </summary>
        /// <returns>String formateado</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"SERVICIO: {ToStringEServicios(this.Servivio)}");
            if (this.FormaPago == EFormaPago.TarjetaCredito)
            {
                sb.AppendLine($"FORMA DE PAGO: Tarjeta de Credito");
            }
            else
            {
                sb.AppendLine($"FORMA DE PAGO: Tarjeta de Debito");
            }
            sb.AppendLine($"CANTIDAD DE DECODIFICADORES: {this.CantidadDecos}");
            if (SenialPremium.Count > 0)
            {
                sb.AppendLine("LISTA DE SEÑALES PREMIUM");
                foreach (ESenialesPremiun item in this.SenialPremium)
                {
                    if (item == ESenialesPremiun.FutbolArgentino)
                    {
                        sb.AppendLine("Fubol Argentino");
                    }
                    else
                    {
                        sb.AppendLine($"{item}");
                    }
                }
            }
            else
            {
                sb.AppendLine($"Aún No ha contratado señales premium");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Da formato a la impresio de un servicio
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Sring builder de servicios</returns>
        public string ToStringEServicios(EServicios s)
        {
            StringBuilder sb = new StringBuilder();
            switch (this.Servivio)
            {
                case EServicios.NoActivo:
                    sb.AppendLine($"SERVICIO: NO ACTIVO");
                    break;
                case EServicios.DTVGo:
                    sb.AppendLine($"SERVICIO: DIREC TV GO");
                    break;
                case EServicios.Oro:
                    sb.AppendLine($"SERVICIO: ORO ");
                    break;
                case EServicios.Plata:
                    sb.AppendLine($"SERVICIO: PLATA ");
                    break;
                default:
                    break;
            }
            return sb.ToString();
        }
    }
}

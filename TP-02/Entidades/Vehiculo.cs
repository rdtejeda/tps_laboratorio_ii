using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo //r public sealed class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        protected EMarca marca; //r le agrhge public a los tres
        protected string chasis;
        protected ConsoleColor color;

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        public abstract ETamanio Tamanio { get;} //R abstract ETamanio Tamanio { get; set; }
                                                 //Funciona  public abstract ETamanio Tamanio { get;} 


        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar() //r sealed string Mostrar() FUNCIONA public virtual string Mostrar();
        {
            return ((string)this); //this.ToString(); //r return this;
        }
        
        /// <summary> //r lo agregue yo
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CHASIS: {p.chasis}"); //r sb.AppendLine("CHASIS: {0}\r\n", p.chasis);
            sb.AppendLine($"MAARCA : {p.marca.ToString()}"); //r sb.AppendLine("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendLine($"COLOR : {p.color.ToString()}"); //r sb.AppendLine("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString(); //r  return sb;
        }        

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis != v2.chasis);    //r return (v1.chasis == v2.chasis);
        }
    }
}

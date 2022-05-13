using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        /// <summary>
        /// Tipo de valor ETipo
        /// </summary>
        public enum ETipo
        {
            CuatroPuertas, CincoPuertas 
        }
        /// <summary>
        /// Atributo
        /// </summary>
        ETipo tipo;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : base(chasis,marca,color)
        {
           this.tipo = ETipo.CuatroPuertas;
        }
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)  : this (marca, chasis, color)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// Sobrescritura Propiedad Tamanio - Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        /// <summary>
        /// Sobreescritura Mostara Ciclomotor
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(((string)this));
            sb.AppendFormat($"TAMAÑO : {Tamanio.ToString()} TIPO : {this.tipo}\n");
            sb.AppendLine();
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}

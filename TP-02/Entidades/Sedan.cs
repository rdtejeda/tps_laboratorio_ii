using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo //R class Sedan : Vehiculo
    {
        public enum ETipo
        {
            CuatroPuertas, CincoPuertas 
        }
        ETipo tipo;
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;   
            this.color = color;
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
        /// Sedan son 'Mediano'
        /// </summary>
        public override ETamanio Tamanio //r protected override short Tamanio
        {
            get
            {
                return ETamanio.Mediano; //r return this.Tamanio;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendFormat(((string)this));
           // sb.AppendLine($"CHASIS: {this.chasis}"); //rsb.AppendLine(this);
            //sb.AppendLine($"MARCA : {this.marca.ToString()}"); //rsb.AppendLine("TAMAÑO : {0}", this.Tamanio);
           // sb.AppendLine($"COLOR : {this.color.ToString()}"); //rsb.AppendLine("TIPO : " + this.tipo);
           // sb.AppendLine($"TIPO : {this.tipo.ToString()}");
           // sb.AppendLine("---------------------");
            sb.AppendFormat($"TAMAÑO : {Tamanio.ToString()} : TIPO {this.tipo}\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}

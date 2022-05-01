using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }

        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        public override ETamanio Tamanio //r protected short Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        public override string Mostrar() //r private override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendFormat(((string)this));
           // sb.AppendLine($"CHASIS: {this.chasis}");        //r sb.AppendLine(this.Mostrar());
           // sb.AppendLine($"MARCA : {this.marca.ToString()}"); //r sb.AppendLine("TAMAÑO : {0}", this.Tamanio);
           // sb.AppendLine($"COLOR : {this.color.ToString()}");                      //r  sb.AppendLine("");
            //sb.AppendLine("---------------------");
            sb.AppendLine($"TAMAÑO : {Tamanio.ToString()}");
            sb.AppendLine("---------------------");


            return sb.ToString(); //r return sb;
        }
    }
}

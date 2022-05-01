using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo //r agregu vehiculo
    {
        public Suv(EMarca marca, string chasis, ConsoleColor color) //R: base(chasis, marca, color)
        {
            this.marca = marca;
            this.chasis = chasis;       
            this.color = color;
        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        public override ETamanio Tamanio //r protected override short Tamanio
        {
            get
            {
                return ETamanio.Grande; //return 0;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendFormat(((string)this));
           // sb.AppendLine($"CHASIS: {this.chasis}"); 
           // sb.AppendLine($"MARCA : {this.marca.ToString()}");
          //  sb.AppendLine($"COLOR : {this.color.ToString()}"); 
             //R sb.AppendLine(base);
            //r sb.AppendLine("TAMAÑO : {0}", this.Tamanio);
            //r sb.AppendLine("");
          //  sb.AppendLine("---------------------");
            sb.AppendLine($"TAMAÑO : {Tamanio.ToString()}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}

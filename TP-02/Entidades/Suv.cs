using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Suv(EMarca marca, string chasis, ConsoleColor color) :base(chasis,marca,color)
        {
            
        }
        /// <summary>
        /// Sobrescrituras Propiedad Tamanio - SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        /// <summary>
        /// Sobreescritrusa Mostara para Suv
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(((string)this));
            sb.AppendLine($"TAMAÑO : {Tamanio.ToString()}");
            sb.AppendLine();
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
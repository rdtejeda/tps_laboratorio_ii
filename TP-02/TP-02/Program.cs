using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TP_02_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuración de la pantalla
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth / 5, Console.LargestWindowHeight /1);
            
            // Nombre del alumno
            Console.Title = "Tejeda Roberto";

            const int espacioDisponible = 6;
            Taller taller = new Taller(espacioDisponible);
            
            Vehiculo c1 = new Ciclomotor(Vehiculo.EMarca.BMW, "ASD012", ConsoleColor.Black);
            Vehiculo c2 = new Ciclomotor(Vehiculo.EMarca.HarleyDavidson, "LEM666", ConsoleColor.Red);
            Vehiculo m1 = new Sedan(Vehiculo.EMarca.Toyota, "HJK789", ConsoleColor.White);
            Vehiculo m2 = new Sedan(Vehiculo.EMarca.Chevrolet, "IOP852", ConsoleColor.Blue, Sedan.ETipo.CincoPuertas);
            Vehiculo a1 = new Suv(Vehiculo.EMarca.Ford, "QWE968", ConsoleColor.Gray);
            Vehiculo a2 = new Suv(Vehiculo.EMarca.Renault, "TYU426", ConsoleColor.DarkBlue);
            Vehiculo a3 = new Suv(Vehiculo.EMarca.BMW, "IOP852", ConsoleColor.Green);
            Vehiculo a4 = new Suv(Vehiculo.EMarca.Honda, "ASD913", ConsoleColor.Green);

            // Agrego 8 ítems (los últimos 2 no deberían poder agregarse ni el m1 repetido) y muestro
            taller += c1;
            taller += c2;
            taller += m1;
            taller += m1;
            taller += m2;
            taller += a1;
            taller += a2;
            taller += a3;
            taller += a4;

            Console.WriteLine(taller.ToString());
            MostararColaDeMensaje();
           
            // Quito 2 items y muestro
            taller -= c1;
            taller -= new Ciclomotor(Vehiculo.EMarca.Honda, "ASD913", ConsoleColor.Red);

            Console.WriteLine(taller.ToString());
            MostararColaDeMensaje();
           
            // Vuelvo a agregar c2
            taller += c2;
                                    
            // Muestro solo Moto
            Console.WriteLine(Taller.Listar(taller, Taller.ETipo.Ciclomotor));
            MostararColaDeMensaje();
            
            // Muestro solo Automovil
            Console.WriteLine(Taller.Listar(taller, Taller.ETipo.Sedan));
            MostararColaDeMensaje();
          
            // Muestro solo Camioneta
            Console.WriteLine(Taller.Listar(taller, Taller.ETipo.SUV));
            MostararColaDeMensaje();

            /// <summary>
            /// Muestra la cola del Mensaje
            /// </summary>
            /// <returns>Void</returns>
            void MostararColaDeMensaje()
            {
                Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
using System.Threading;

namespace Formularios
{
    public class Temporizador
    {

        public delegate void Timer();
        public event Timer OnTiempoFinal;
        /// <summary>
        /// Ejecuta el intervalo de tiempo y verifica si se pidio cancelacion de hilo 
        /// en cuyo caso es invocado el Evento
        /// </summary>
        /// <param name="intervaloSegundos"></param>
        /// <param name="cts"></param>
        public void Ejecutar(int intervaloSegundos, CancellationToken cts)
        {
            while (intervaloSegundos >= 0)
            {
                if (cts.IsCancellationRequested)
                    break;
                Thread.Sleep(1000);
                intervaloSegundos--;
            }
            if (OnTiempoFinal is not null && !cts.IsCancellationRequested)
            {
                OnTiempoFinal.Invoke();
                this.Ejecutar(10, cts);
            }
        }
    }
}

using System;
using System.Threading;

namespace Formularios
{
    public class Temporizador
    {
        public event Action OnTiempoFinalizado;
        public void Ejecutar(int intervaloSegundos)
        {           
                while (intervaloSegundos >= 0)
                {
                    Thread.Sleep(1000);
                    intervaloSegundos--;
                }
                if (OnTiempoFinalizado is not null)
                {
                    OnTiempoFinalizado.Invoke();
                }
            this.Ejecutar(10);
        }
    }
}

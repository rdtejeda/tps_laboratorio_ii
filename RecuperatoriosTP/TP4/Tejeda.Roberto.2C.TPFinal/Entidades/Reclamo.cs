using PersistirDatos;
using System;

namespace Entidades
{
    public class Reclamo
    {
        private int numeroReclamo;
        private bool estaSolucionado;
        private string dniClienteReclama;
        public event Action OnEstadoReclamo;
        public Reclamo()
        {
        }
        public Reclamo(int numeroReclamo, string clienteReclama)
        {
            this.numeroReclamo = numeroReclamo;
            this.estaSolucionado = false;
            this.dniClienteReclama = clienteReclama;
        }
        public int NumeroReclamo { get { return numeroReclamo; } }
        public bool EstaSolucionado { get { return estaSolucionado; } set => estaSolucionado = value; }
        public string DniClienteReclama { get { return dniClienteReclama; } }
        public void ActilizarEstadoDeElReclamo()
        {
            if (OnEstadoReclamo is not null)
                this.OnEstadoReclamo.Invoke();
        }
        /// <summary>
        /// Agrega un nuevo reclamo al archivo Json
        /// </summary>
        /// <param name="nuevoReclamo">Reclamo a agregar</param>
        public static void AgregarReclamo(Reclamo nuevoReclamo)
        {
            string path = null;
            try
            {
                if (((path = Environment.CurrentDirectory + @"\Archivos\") is not null))
                {
                    Serializar<Reclamo> reclamos = new Serializar<Reclamo>();
                    reclamos.Agregar(path, "Reclamos.json", nuevoReclamo);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

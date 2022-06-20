namespace PersistirDatos
{
    internal interface IResguardarDatos<T> where T : class
    {
        public void Guardar(string path, string nombreArchivo, T contenido);
        public T Leer(string path, string nombreArchivo);
    }
}

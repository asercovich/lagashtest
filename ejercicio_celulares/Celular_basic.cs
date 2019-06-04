namespace ejercicio_celulares
{
    abstract public class Celular_basic : ICelular_Basic
    {
        public string SistemaOperativo;
        public string Peso;
        public string Almacenamiento;
        public string Pantalla;
        public string Procesador;
        public void Llamar(string numero)
        {
            throw new System.NotImplementedException();
        }
    }
}
namespace ejercicio_celulares
{
    public interface ICelular_Smartphone : ICelular_CamarayMP3
    {
        void Descargar_Aplicacion(string nombre);
        void Conectarse_Internet();
    }
}
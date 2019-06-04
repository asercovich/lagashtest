namespace ejercicio_celulares
{
    public interface ICelular_SMS : ICelular_Contacto
    {
        void Enviar_SMS(string mensaje); 
    }
}
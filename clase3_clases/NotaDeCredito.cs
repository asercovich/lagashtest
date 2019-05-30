using System;

class NotaDeCredito : DocumentoLegal
{
    public NotaDeCredito(int numero) : base(numero)
    {
    }
    public void Imprimir()
    {
        Console.WriteLine("Soy la NC: " + this.GetNumero());
    }
    static public NotaDeCredito LeerDeBaseDeDatos()
    {
        return new NotaDeCredito(3);
    }

}
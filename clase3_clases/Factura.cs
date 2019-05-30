using System;

class Factura : DocumentoLegal
{
    public Factura(int numero) : base(numero)
    {
    }
    public void Pagar()
    {
        Console.WriteLine("Fact.pagar.");
    }
}
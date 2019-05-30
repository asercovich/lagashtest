using System;

namespace ejemplo_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco Santander = new Banco();
            Santander.Operar();
            Console.WriteLine(Santander.DepositosTotales() );
        }
    }
}

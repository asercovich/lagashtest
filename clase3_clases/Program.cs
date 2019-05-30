using System;

namespace clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dl = new DocumentoLegal(3);
            var fc = new Factura(1);
            var nc = new NotaDeCredito(1);
            var nc2 = new NotaDeCredito(2);

            nc.Imprimir();
            nc2.Imprimir();

            bool si = (dl is DocumentoLegal);
            si= ( dl is Factura);
            si =( fc is Factura);
            si = ( fc is DocumentoLegal);

            HacerAlgoConDocumentos(nc);

            var nnc = NotaDeCredito.LeerDeBaseDeDatos();

        }
        static void HacerAlgoConDocumentos(DocumentoLegal dl)
        {

        }
    }
}

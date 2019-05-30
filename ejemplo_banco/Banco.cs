using System;

class Banco
{  
    Cliente Cliente1,Cliente2,Cliente3;
    public Banco()
    {
        // Cliente[] clientes = new Cliente[3];         preguntar porqué no declaro acá?
        Cliente1 = new Cliente("Pepe1");
        Cliente2 = new Cliente("Pepe2");
        Cliente3 = new Cliente("Pepe3");
    }
    public int DepositosTotales()
    {
        return Cliente1.RetornarMonto()+Cliente2.RetornarMonto()+Cliente3.RetornarMonto();
    }
    public void Operar()
    {
        Cliente1.Depositar(100);
        Cliente2.Depositar(100);
        Cliente3.Depositar(100);
        Cliente3.Extraer(50);
    }

}

//  Banco
//     atributos
//         3 Cliente (3 objetos de la clase Cliente)
//     métodos
//         constructor
//         Operar
//         DepositosTotales
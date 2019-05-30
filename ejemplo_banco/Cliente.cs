using System;

class Cliente
{
    private string Nombre;
    private int Monto;

    public Cliente(string nombre){
        this.Nombre=nombre;
        Monto=0;

    }
    public void Depositar(int monto){
        this.Monto += monto;
    }
    public void Extraer(int monto){
        this.Monto -= monto;
    }
    public int RetornarMonto(){
        return this.Monto;
    }

}
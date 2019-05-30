using System;

class Contacto
{
    public string NumTelefono{get; set;}
    public string Nombre{get; set;}
    public Contacto(string num, string name)
    {
        this.NumTelefono = num;
        this.Nombre = name;
    }
}


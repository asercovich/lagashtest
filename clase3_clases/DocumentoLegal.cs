using System;

class DocumentoLegal
{
    private int Numero;                                         //public->ven todos
    private int codEnBaseDeDatos;                              //private->solo esta clase
    protected int fechaAlta;                                   //protected->ven las que heredan

    public DateTime Fecha{
        get{
            return Fecha;
        }
        private set{
            Fecha = value;
        }
    }

    public int Edad { get; set; }

    public int GetNumero()
    {
        return Numero;
    }

    protected void SetNumero(int numero)
    {
        this.Numero = numero;
    }

    protected static void Hacer()
    {
    }

    public DocumentoLegal(int numero)
    {
        this.Numero = numero;
    }
    public void Enviar()
    {
        Console.WriteLine("Docu.enviar");
    }
    private void GuardarEnBaseDeDatos()
    {
        Console.WriteLine("Docu.guardabasedatos");
    }
}
using System;
using System.IO;
using System.Collections.Generic;

namespace tarea_files
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = "test.txt";
            List<Contacto> Lista = new List<Contacto>();

            if ( File.Exists("./" + FileName) ){ 
                string line;  
                Contacto Aux;
                System.IO.StreamReader file = new System.IO.StreamReader("./" + FileName); 
                Console.WriteLine("El archivo existe, lo leo e imprimo...\n") ;
                while((line = file.ReadLine()) != null)  
                {
                    var values = line.Split('\t');
                    Aux = new Contacto(values[1],values[0]); 
                    Lista.Add(Aux);
                }  
                file.Close(); 

                for(int i=0; i<Lista.Count;i++){
                    Console.WriteLine("Nombre: " + Lista[i].Nombre + "\tTelefono: " + Lista[i].NumTelefono);
                }

            }else{
                Contacto[] Datos = new Contacto[3];
                Datos[0] = new Contacto("1123456780","Pepe");
                Datos[1] = new Contacto("1123456781","Pedro");
                Datos[2] = new Contacto("1123456782","Julian");

                Console.WriteLine("El archivo no existe, lo creo y asigno datos de ejemplo.\n");
// No entiendo porque tengo que usar el "using" acá, si ya lo incluí al inicio del codigo.
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("./" + FileName))
                {
                     for (int i=0; i<Datos.Length ;i++)
                    {
                            file.WriteLine(Datos[i].Nombre + "\t" + Datos[i].NumTelefono);
                            Console.WriteLine(Datos[i].Nombre + "\t" + Datos[i].NumTelefono);
                    }
                }
            }
         }
    }
}

using System;

namespace codewars_vocales
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsVocal(char pepe)
            {
                if( pepe == 'a' || pepe == 'e' || pepe == 'i' || pepe == 'o' || pepe == 'u' ){
                    
                    return true;

                }
                else
                {
                    return false;
                }

                
            }

            string RemoverVocales(string input)
            {
                 string StNueva = "";
                for (int i=0; i<input.Length ; i++)
                {
                    if(!IsVocal(input[i]))
                    {
                       
                        StNueva += input[i].ToString();
                    
                    }
                }
            

                return StNueva;
            }
           
            string CambiarVocales(string input)
            {

                 string dat;  
                 string dat1;
                 
                 dat = input.Replace('a', 'x');
                 dat1 = dat.Replace('e', 'x');
                 dat = dat1.Replace('i' , 'x');
                 dat1 = dat.Replace('o', 'x');
                 dat = dat1.Replace('u','x');
           
                return dat;
             
            }
             Console.WriteLine(CambiarVocales("Murcielago"));
             Console.WriteLine(RemoverVocales("Murcielago"));
        }
    }
}

using System;

namespace tarea_division
{
    class Program
    {

             static int Sumatoria(int numero)
        {
            return ( numero == 0) ? 0 : numero + Sumatoria(numero - 1);
        }
        static int dividir(int a,int b)
        {
            int res=0;
            while(a>=b)
            {
                a -= b;
                res++;
            }
            return res;
        
        }

        static int dividir_recursivo(int a , int b)
        {
            return ( a > b ) ? dividir_recursivo(a - b , b) + 1 :  1 ;
        }

   

        static int sumatoria_norec( int num)
        {
            int sum=0;
            while (num != 0)
            {
                sum+=num;
                num--;
            }
            return sum;
        }

        static void Main(string[] args)
        {

        }

        
    }
}

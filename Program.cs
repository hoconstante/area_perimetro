using System;

namespace area_perimetro
{
    class Program
    {
        static void Main(string[] args)
         {
            Figura fig = new();
            fig.Criar();
            fig.Listar();
            Figura.Tchau();            
         }     
    }
}

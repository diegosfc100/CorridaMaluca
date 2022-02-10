using System;
using CorridaMaluca;

class Program
{
    static void Main(string[] args)
    {                
        Corredor c1 = new Corredor();
        c1.Nome = "diego";
        
        Pista pista1 = new Pista(150, c1);

        while(pista1.PosAtleta < pista1.Tamanho)
        {
            Console.Clear();
            pista1.AtualizarCorrida();
            pista1.ExibirPista();
            Console.ReadKey();         
        }
    }
}
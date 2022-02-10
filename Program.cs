using System;
using CorridaMaluca;

class Program
{
    static void Main(string[] args)
    {                
        Pista pista1 = new Pista(150, new Corredor("Diego"));
        Pista pista2 = new Pista(150, new Corredor("José"));

        Boolean ganhou = false;
        
        while(ganhou == false)
        {
            Console.Clear();
            if (pista1.AtualizarCorrida() == true) ganhou = true;
            if (pista2.AtualizarCorrida() == true) ganhou = true;
            pista1.ExibirPista();            
            pista2.ExibirPista();
            Console.ReadKey();         
        }
    }
}
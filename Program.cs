using System;
using CorridaMaluca;

class Program
{
    static void Main(string[] args)
    {      
        Boolean ganhou = false;
        String resp = "s";
        int aposta = 0;
        int ganhador = 0;

        while (resp == "s")
        {
            Pista pista1 = new Pista(150, new Corredor("Diego"));
            Pista pista2 = new Pista(150, new Corredor("José"));
            Pista pista3 = new Pista(150, new Corredor("Maria"));

            Console.Clear();

            Console.WriteLine("$#@ - Corrida Maluca - @#$");
            Console.WriteLine("Corredores  \n1 - Diego \n2 - José \n3 - Maria ");
            Console.Write("Em qual corredor vc aposta (1, 2 ou 3):");
            aposta = Convert.ToInt32(Console.ReadLine());

            ganhador = 0;
            ganhou = false;

            while(ganhou == false)
            {
                Console.Clear();
                if (pista1.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 1;
                }
                if (pista2.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 2;
                }
                if (pista3.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 3;
                }
                                        
                pista1.ExibirPista();            
                pista2.ExibirPista();
                pista3.ExibirPista();
                //Console.ReadKey();   
                Thread.Sleep(500);      
            }

            Console.Clear();
            Console.WriteLine("$#@ - Corrida Maluca - @#$");
            Console.WriteLine($"O ganhador foi o corredor de número {ganhador}");

            switch (ganhador)
            {
                case 1:
                    Console.WriteLine("Diego");
                    break;
                case 2: 
                    Console.WriteLine("José");
                    break;
                case 3: 
                    Console.WriteLine("Maria");
                    break;
            }

            if(ganhador == aposta)
            {
                Console.WriteLine("Parabéns!!!! Vc ganhou !!!");
            }
            else
            {
                Console.WriteLine("Que pena!!!! Você perdeu!!!!!");
            }
            Console.Write("Jogar novamente S ou N: ");
            resp = Console.ReadLine().ToLower();
            
            }
    }
}
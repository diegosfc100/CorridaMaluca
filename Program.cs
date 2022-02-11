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
            Pista pista1 = new Pista(150, new Corredor("00 - Dick Vigarista"));
            Pista pista2 = new Pista(150, new Corredor("1 - Irmãos Rocha"));
            Pista pista3 = new Pista(150, new Corredor("2 - Cupê Mal Assombrado"));
            Pista pista4 = new Pista(150, new Corredor("3 - Professor Aéreo"));
            Pista pista5 = new Pista(150, new Corredor("4 - Barão Vermelho"));
            Pista pista6 = new Pista(150, new Corredor("5 - Penélope Charmosa"));
            Pista pista7 = new Pista(150, new Corredor("6 - Sargento Bombarda e o Soldado Meekley"));
            Pista pista8 = new Pista(150, new Corredor("7 - Quadrilha de Morte"));
            Pista pista9 = new Pista(150, new Corredor("8 - Tio Tomás e o Urso Chorão"));
            Pista pista10 = new Pista(150, new Corredor("9 - Peter Perfeito"));
            Pista pista11 = new Pista(150, new Corredor("10 - Rufus Lenhador"));
            

            Console.Clear();

            Console.WriteLine("$#@ - Corrida Maluca - @#$");
            Console.WriteLine("Corredores  \n00 - Dick Vigarista \n1 - Irmãos Rocha \n2 - Cupê Mal Assombrado \n3 - Professor Aéreo \n4 - Barão Vermelho \n5 - Penélope Charmosa \n6 - Sargento Bombarda e o Soldado Meekley \n7 - Quadrilha de Morte \n8 - Tio Tomás e o Urso Chorão \n9 - Peter Perfeito \n10 - Rufus Lenhador");
            Console.Write("Em qual corredor você quer apostar ?");
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
                else if (pista2.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 2;
                }
                else if (pista3.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 3;
                }
                else if (pista4.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 4;
                }
                else if (pista5.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 5;
                }
                else if (pista6.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 6;
                }
                else if (pista7.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 7;
                }
                else if (pista8.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 8;
                }
                else if (pista9.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 9;
                }
                else if (pista10.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 10;
                }
                else if (pista11.AtualizarCorrida() == true) 
                {
                    ganhou = true;
                    ganhador = 11;
                }
                                      
                pista1.ExibirPista();            
                pista2.ExibirPista();
                pista3.ExibirPista();
                pista4.ExibirPista();
                pista5.ExibirPista();
                pista6.ExibirPista();
                pista7.ExibirPista();
                pista8.ExibirPista();
                pista9.ExibirPista();
                pista10.ExibirPista();
                pista11.ExibirPista();

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
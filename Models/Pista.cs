namespace CorridaMaluca
{
    public class Pista
    {
        
        private String pista = "";
        private String corredorPista = "";

        public Pista(int tamanho, Corredor atleta)
        {
            this.Tamanho = tamanho;
            this.Atleta = atleta;
            this.posAtleta = 0;
        }
        public int Tamanho { get; set; }

        private int posAtleta;
        public int PosAtleta
        {
            get { return this.posAtleta; }
            //set { this.posAtleta = value; }
        }

        public Corredor Atleta { get; set; }
        
        public Boolean AtualizarCorrida()
        {
            Boolean ganhou = false;

            if(this.posAtleta < this.Tamanho)
            {
                this.posAtleta += this.Atleta.Correr();
            }

            if(this.posAtleta >= this.Tamanho)
            {
                ganhou = true;
                this.posAtleta = this.Tamanho;
            }
            
            return ganhou;
        }
        
        public void ExibirPista()
        {
            string pista = "";
            string corredorPista = "";

            for(int i = 1; i <= this.Tamanho; i++) // monta a img do corredor na pista na posição atual
            {
                pista += "-";
                if(i == this.posAtleta)
                {
                    corredorPista += this.Atleta.Nome;
                }
                else
                {
                    corredorPista += " ";
                }
            }            

        // exibir pista e corredor
        Console.WriteLine(corredorPista);
        Console.WriteLine(pista);
        Console.ReadKey();
        }

    }
}
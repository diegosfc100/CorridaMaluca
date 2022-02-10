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
            this.corredorPista = "";
            this.pista = "";
        }
        public int Tamanho { get; set; }

        private int posAtleta;
        public int PosAtleta
        {
            get { return this.posAtleta; }
            //set { this.posAtleta = value; }
        }

        public Corredor Atleta { get; set; }

        
        public void AtualizarCorrida()
        {
            this.posAtleta += this.Atleta.Correr();
        }
        
    }
}
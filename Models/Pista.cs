namespace CorridaMaluca
{
    public class pista
    {
        public int Tamanho { get; set; }

        private int posAtleta;
        public int PosAtleta
        {
            get { return this.posAtleta; }
            //set { this.posAtleta = value; }
        }

        public Corredor Atleta { get; set; }

        //String pista = "";
        //String CorredorPista = "";

        public void AtualizarCorrida()
        {
            this.posAtleta += this.Atleta.Correr();
        }
        
    }
}
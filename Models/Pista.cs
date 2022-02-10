namespace CorridaMaluca
{
    public class pista
    {
        public int Tamanho { get; set; }

        private int posCorredor;
        public int PosCorredor
        {
            get { return this.posCorredor; }
            set { this.posCorredor = value; }
        }
        
    }
}
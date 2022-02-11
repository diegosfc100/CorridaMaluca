namespace CorridaMaluca
{
    public class Corredor
    {
        public static Random rnd = new Random();
        public Corredor() // Construtor (ctr + tab)
        {
            this.Nome = "";
        }

        public Corredor(String nome)
        {
            this.Nome = nome;
        }

        private String nome; // Propriedade (propfull + tab)
        public String Nome
        {
            get { return this.nome; }
            set { nome = value; }               
        }
        
        public int Correr() // Método
        {
            return Corredor.rnd.Next(1, 10);
        }
    }
}

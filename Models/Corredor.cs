namespace CorridaMaluca
{
    public class Corredor
    {
        
        public Corredor() // Construtor (ctr + tab)
        {
            this.Nome = "";
        }

        public Corredor(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; set; } // Propriedade (prop + tab)

        public int Correr()
        {
            Random random = new Random();
            return random.Next(1, 5); 
        }
    }
}
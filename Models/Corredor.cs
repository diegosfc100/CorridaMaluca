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

        private string nome; // Propriedade (propfull + tab)
        public string Nome
        {
            get { return this.nome; }
            set { 
                this.nome = value.ToUpper();
                if(value.Length > 1) this.nome = value[0].ToString().ToUpper();
                if(value.Length == 0) this.nome = "d";
            }
        }
        
        public int Correr()
        {
            Random random = new Random();
            return random.Next(1, 5); 
        }
    }
}
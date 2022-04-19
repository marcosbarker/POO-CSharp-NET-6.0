namespace Pizzaria.Model;
    public class Cliente
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Telefone {get; set;}
        public List<Endereco> Endereco {get; set;}
    }

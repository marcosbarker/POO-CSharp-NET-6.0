namespace ProjetoConsole
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public string SobreNome {get; set;}
        public int Idade {get; private set;}
        public string NomeCompleto => Nome + " " + SobreNome;


        public Pessoa(int idade){
            Idade = idade;
        }
    }
}
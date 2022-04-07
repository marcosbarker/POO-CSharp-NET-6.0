namespace ProjetoConsole
{
    public class Carro
    {
        #region  Atributos
        public string Cor {get; set;}
        public string Modelo {get; set;}
        public int Ano {get; set;}

        #endregion    

        #region Construtores

        public Carro(int ano, string cor, string modelo){
            this.Ano = ano;
            Cor = cor;
            Modelo = modelo;
        }

        public Carro(string cor){
            Cor = cor;
        }

        public Carro(){/*construtor padrao*/}

        #endregion

        #region Metodos

        public void LigarCarro(){
            System.Console.WriteLine("Ligando carro.");
            System.Console.WriteLine("Carro ligado.");
        }
        public void buzina(){
            System.Console.WriteLine("Buzina.");
        }

        #endregion
    }
}
namespace SistemaHotel.Models
{
    public abstract class Pessoa
    {
        public string Nome {get; set;}
        public string CPF  {get; set;}
        public string Telefone  {get; set;}


        #region Construtores
        public Pessoa(){}

        public Pessoa(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }
        #endregion           

        #region Metodos

        public abstract void SeApresentar();

        #endregion
    }
}
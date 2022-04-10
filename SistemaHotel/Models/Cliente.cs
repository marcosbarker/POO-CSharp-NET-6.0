namespace SistemaHotel.Models
{
    public class Cliente : Pessoa
    {
        public Cliente()
        {
        }
        public Cliente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public override void SeApresentar()
        {
            throw new NotImplementedException();
        }
    }
}
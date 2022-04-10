namespace SistemaHotel.Models
{
    public class Gerente : Pessoa
    {
        public Gerente()
        {
        }

        public Gerente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public override void SeApresentar()
        {
            throw new NotImplementedException();
        }
    }
}
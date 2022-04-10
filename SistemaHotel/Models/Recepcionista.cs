using SistemaHotel.Interfaces;

namespace SistemaHotel.Models
{
    public class Recepcionista : Pessoa, IRecepcionaista
    {
        public Recepcionista()
        {
        }

        public Recepcionista(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public void AtenderTelefone()
        {
            Console.WriteLine("Sei atender o telefone.");
        }

        public void Falaringles()
        {
            Console.WriteLine("Sei falar ingles.");
        }

        public override void SeApresentar()
        {
            Console.WriteLine("Prazer, sou a recepcionista, meu nome é " + Nome);
        }
    }
}
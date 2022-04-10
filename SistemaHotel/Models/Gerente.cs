using SistemaHotel.Interfaces;

namespace SistemaHotel.Models
{
    public class Gerente : Pessoa, IGerente
    {
        public Gerente()
        {
        }

        public Gerente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
        }

        public void ArrumarCama()
        {
            Console.WriteLine("Sou o gerente e sei arrumar a cama");
        }

        public void AtenderTelefone()
        {
            Console.WriteLine("Sou o gerente e sei arrumar atender o telefone");
        }

        public void ConhecimentoGeral()
        {
            Console.WriteLine("Sou o gerente sei tudo do hotel");
        }

        public void Falaringles()
        {
            Console.WriteLine("Sou o gerente e sei falar ingles");
        }

        public void LimparQuarto()
        {
            Console.WriteLine("Sou o gerente e sei limpar o quarto");
        }

        public override void SeApresentar()
        {
            Console.WriteLine("Sou o gerente, meu nome é " + Nome);
        }
    }
}
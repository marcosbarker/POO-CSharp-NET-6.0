using SistemaHotel.Interfaces;

namespace SistemaHotel.Models
{
    public class Camareira : Pessoa, ICamareira
    {
       #region Construtores
        public Camareira() : base(){}
        public Camareira(string nome, string cpf, string telefone) : base(nome, cpf, telefone){}

        public void ArrumarCama()
        {
            Console.WriteLine("Sei arrumar a cama.");
            System.Console.WriteLine();
        }

        public void LimparQuarto()
        {
            Console.WriteLine("Sei limpar o quarto.");
            System.Console.WriteLine();
        }

        public override void SeApresentar()
        {
            Console.WriteLine("Prazer, sou a camareira, meu nome é " + Nome);
        }

        #endregion
    }
}
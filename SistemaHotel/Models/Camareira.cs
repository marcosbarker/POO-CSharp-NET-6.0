namespace SistemaHotel.Models
{
    public class Camareira : Pessoa
    {
       #region Construtores
        public Camareira() : base(){}
        public Camareira(string nome, string cpf, string telefone) : base(nome, cpf, telefone){}

        public override void SeApresentar()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
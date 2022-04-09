namespace AgenciaBancaria.Models
{
    public class ConstaInvestimento : ContaBancaria
    {
         public ConstaInvestimento(Titular titular) : base(titular)
        {
        }
        public ConstaInvestimento(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }
    }
}
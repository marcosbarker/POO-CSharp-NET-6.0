namespace AgenciaBancaria.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Titular titular) : base(titular)
        {
        }
         public ContaCorrente(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }
    }
}
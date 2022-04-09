namespace AgenciaBancaria.Models
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(Titular titular) : base(titular)
        {
        }
         public ContaPoupanca(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }
         public override void ImprimirExtrato()
        {
            Console.WriteLine("Imprimindo extrato da conta poupanca");
        }
    }
}
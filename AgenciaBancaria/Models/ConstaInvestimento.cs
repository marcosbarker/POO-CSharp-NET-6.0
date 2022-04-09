namespace AgenciaBancaria.Models
{
    public class ConstaInvestimento : ContaBancaria
    {
         public double ValorInvestido {get; private set;}
         public ConstaInvestimento(Titular titular) : base(titular)
        {
        }
        public ConstaInvestimento(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }
         public override void ImprimirExtrato()
        {
            Console.WriteLine("Imprimindo extrato da conta investimento");
        }
    }
}
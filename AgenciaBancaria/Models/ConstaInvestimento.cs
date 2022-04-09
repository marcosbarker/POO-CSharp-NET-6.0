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
            Console.WriteLine();
            Console.WriteLine("########---Extrato Conta investimento---########");
            Console.WriteLine();

            Console.WriteLine("Gerado em: " + DateTime.Now);
            Console.WriteLine();

            foreach(var movimentacao in Movimentacoes)
            {
                Console.WriteLine(movimentacao.ToString());
            }
            
            Console.WriteLine("Saldo atual: R$ " + Saldo);
            Console.WriteLine("##########--------------------------##########");
        }        
    }
}
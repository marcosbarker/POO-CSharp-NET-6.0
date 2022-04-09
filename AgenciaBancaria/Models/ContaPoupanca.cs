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
            Console.WriteLine();
            Console.WriteLine("##########---Extrato Conta Poupanca---##########");
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
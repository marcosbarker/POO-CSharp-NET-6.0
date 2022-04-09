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

        public override void ImprimirExtrato()
        {
            Console.WriteLine();
            Console.WriteLine("##########---Extrato Conta Corrente---##########");
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
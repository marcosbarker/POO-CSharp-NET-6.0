using AgenciaBancaria.Enums;

namespace AgenciaBancaria.Models
{
    public abstract class ContaBancaria
    {
        #region Atributos
        public Titular Titular {get; set;}
        public double Saldo {get; private set;}
        public DateTime DataAbertura {get; private set;}
        protected List<Movimentacao> Movimentacoes {get; private set;}
        protected readonly double VALOR_MINIMO = 10.0;

        #endregion


        #region Construtores
        public ContaBancaria(Titular titular, double saldoAbertura)
        {
            Titular = titular;
            Saldo = saldoAbertura;
            DataAbertura = DateTime.Now;

            Movimentacoes = new List<Movimentacao>()
            {
                new Movimentacao(TipoMovimentacao.ABERTURA_CONTA, saldoAbertura)
            };
          //var movimentacao = new Movimentacao(TipoMovimentacao.ABERTURA_CONTA, saldoAbertura);
          //Movimentacoes.Add(movimentacao);
          //ou
          //Movimentacoes.Add(new Movimentacao(TipoMovimentacao.ABERTURA_CONTA, saldoAbertura));
        }
          public ContaBancaria(Titular titular)
        {
            Titular = titular;
            Saldo = 0.00;
            DataAbertura = DateTime.Now;
            Movimentacoes = new List<Movimentacao>();
              Movimentacoes = new List<Movimentacao>()
            {
                new Movimentacao(TipoMovimentacao.ABERTURA_CONTA, Saldo)
            };
        }
        
        #endregion
    
        #region Metodos

        public void Depositar(double valor)
        {
            if(valor < VALOR_MINIMO)
            {
                throw new Exception("O valor minimo para deposito é R$ " + VALOR_MINIMO);
            }

            Saldo += valor;
            Movimentacoes.Add(new Movimentacao(TipoMovimentacao.DEPOSITO, valor));
        }

        public double Sacar(double valor)
        {
            if(valor < VALOR_MINIMO)
            {
                throw new Exception("O valor minimo para saque é R$ " + VALOR_MINIMO);
            }
            else if (valor > Saldo)
            {
               throw new Exception("Saldo insuficiente para saque, seu saldo e R$ " + Saldo);

            }

            Saldo -= valor;
            Movimentacoes.Add(new Movimentacao(TipoMovimentacao.SAQUE, valor));
            return valor;
        }


        public void Tranferencia(ContaBancaria contaDestino, double valor)
        {
            if(valor < VALOR_MINIMO)
            {
                throw new Exception("Valor minimo para tranferencia e de R$ " + VALOR_MINIMO);
            }
             else if (valor > Saldo)
            {
               throw new Exception("Saldo insuficiente para transferencia, seu saldo e R$ " + Saldo);

            }

            contaDestino.Depositar(valor);
            Saldo -= valor;
            Movimentacoes.Add(new Movimentacao(TipoMovimentacao.TRANSFERENCIA, valor));
        }
/*
        public virtual void ImprimirExtrato()
        {
            Console.WriteLine("Imprimindo extrato");
        }
*/
         public abstract void ImprimirExtrato();       

        #endregion
    }
}
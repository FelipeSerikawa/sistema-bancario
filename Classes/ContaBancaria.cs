using System;

namespace SistemaBancario
{
    public abstract class ContaBancaria
    {
        public ContaBancaria(Cliente cliente)
        {
            Random random = new Random();
            NumeroConta = random.Next(10000, 99999);
            DigitoVerificador = random.Next(0, 9);
            ContaAberta = false;
            SaldoConta = 0M;

        }
        
        public int NumeroConta { get; private set; }
        public int DigitoVerificador { get; private set; }
        public bool ContaAberta { get; protected set; }
        public decimal SaldoConta { get; protected set; }
        public string TipoConta { get; protected set; }


        public void Depositar(decimal ValorDeposito)
        {
            SaldoConta = SaldoConta + ValorDeposito;
        }

        public void Sacar(decimal ValorSaque)
        {
            if (ValorSaque > SaldoConta)
            {
                throw new Exception("Erro: saldo insuficente para essa transacao");
            }
            else
            {
                SaldoConta = SaldoConta - ValorSaque;
            }
        }

    }

    public class ContaCorrente: ContaBancaria

    {
        public ContaCorrente(Cliente cliente): base(cliente)
        {
            TaxaManutencao = 12.50M;
            TipoConta = "Corrente";
        }
        public decimal TaxaManutencao { get; private set; }

        public void AbrirContaCorrente()
        {
            if (ContaAberta == false)
            {
                ContaAberta = true;
                Console.WriteLine("Conta CORRENTE aberta com sucesso");
            }
            else
            {
                throw new Exception("Erro: a conta corrente ja se encontra aberta");
            }
            
        }

        public void FecharContaCorrente()
        {
            if (SaldoConta == 0)
            {
                if (ContaAberta == true)
                {
                    ContaAberta = false;
                    Console.WriteLine("Conta CORRENTE fechada com sucesso");
                }
                else
                {
                    throw new Exception("Erro: a conta corrente ja se encontra fechada");
                }
            }

            else if (SaldoConta > 0)
            {
                throw new Exception("Erro: o saldo bancario deve ser sacado para encerrar a conta");
            }

            else
            {
                throw new Exception("Erro: saldo negativo");
            }
            
        }
        public void CobrarTaxaManutencao()
        {
            SaldoConta = SaldoConta - TaxaManutencao;
        }


    }

    public class ContaPoupanca: ContaBancaria
    {
        public ContaPoupanca(Cliente cliente): base(cliente)
        {
            Rendimento = 0.005M;
            TipoConta = "Poupanca";
        }

        public decimal Rendimento { get; private set; }
        
        public void AdicionarRendimento()
        {
            SaldoConta = SaldoConta + SaldoConta*Rendimento;
        }

        public void AbrirContaPoupanca()
        {
            if (ContaAberta == false)
            {
                ContaAberta = true;
                Console.WriteLine("Conta POUPANCA aberta com sucesso");
            }
            else
            {
                throw new Exception("Erro: a conta corrente ja se encontra aberta");
            }
            
        }

        public void FecharContaPoupanca()
        {
            if (SaldoConta == 0)
            {
                if (ContaAberta == true)
                {
                    ContaAberta = false;
                    Console.WriteLine("Conta POUPANCA fechada com sucesso");
                }
                else
                {
                    throw new Exception("Erro: a conta corrente ja se encontra fechada");
                }
            }

            else if (SaldoConta > 0)
            {
                throw new Exception("Erro: o saldo bancario deve ser sacado para encerrar a conta");
            }

            else
            {
                throw new Exception("Erro: saldo negativo");
            }
        }
            

    }
}
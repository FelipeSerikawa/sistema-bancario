using System;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datanasc = new DateTime(2000, 1, 1);

            Endereco endereco1 = new Endereco("Rua Teste", "1A", "Bairro do Teste", "Cidade Teste", "Teste Estado");
            Cliente cliente1 = new Cliente("Teste", datanasc, "12345678900", "987654321", endereco1);
            Console.WriteLine("\nNome: {0}\nData de nascimento: {1}\n", cliente1.Nome, cliente1.DataNascimento);
            Console.WriteLine("\nRua: {0}\nNumero: {1}\nLogradouro: {2}\nCidade: {3}\nEstado: {4}\n", endereco1.Rua, endereco1.Numero, endereco1.Logradouro, endereco1.Cidade, endereco1.Estado);

            ContaCorrente conta1 = new ContaCorrente(cliente1);
            conta1.AbrirContaCorrente();
            conta1.Depositar(10.5M);
            conta1.Depositar(234.23M);
            conta1.Sacar(100M);
            conta1.CobrarTaxaManutencao();
            /*
            conta1.Sacar(conta1.SaldoConta);
            conta1.FecharContaCorrente();
            */
            Console.WriteLine("\nTipo: {0}\nNumero: {1}-{2}\nAberta: {3}\nSaldo: R${4}\n", conta1.TipoConta, conta1.NumeroConta, conta1.DigitoVerificador, conta1.ContaAberta, conta1.SaldoConta);

            ContaPoupanca conta2 = new ContaPoupanca(cliente1);
            conta2.AbrirContaPoupanca();
            conta2.Depositar(400.50M);
            conta2.AdicionarRendimento();
            Console.WriteLine("\nTipo: {0}\nNumero: {1}-{2}\nAberta: {3}\nSaldo: R${4}\n", conta2.TipoConta, conta2.NumeroConta, conta2.DigitoVerificador, conta2.ContaAberta, conta2.SaldoConta);

            
        }
    }
}

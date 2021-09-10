using System;

namespace SistemaBancario
{
    public class Cliente
    {
        public Cliente(string nome, DateTime dataNascimento, string cpf, string rg, Endereco endereco)
        {
            Nome = nome.ValidarVazio();
            DataNascimento = dataNascimento;
            CPF = cpf.ValidarVazio();
            RG = rg.ValidarVazio();
            EnderecoCliente = endereco;
        }

        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public Endereco EnderecoCliente { get; private set; }  

    }
}
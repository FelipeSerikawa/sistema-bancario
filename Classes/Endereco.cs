namespace SistemaBancario
{
    public class Endereco
    {
        public Endereco(string rua, string numero, string logradouro, string cidade, string estado)
        {
            Rua = rua.ValidarVazio();
            Numero = numero.ValidarVazio();
            Logradouro = logradouro.ValidarVazio();
            Cidade = cidade.ValidarVazio();
            Estado = estado.ValidarVazio();
        }
        public string Rua {get; private set; }
        public string Numero { get; private set; }
        public string Logradouro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
    }
}
namespace SistemaBancario
{
    public static class Validacoes
    {
        public static string ValidarVazio(this string texto)
        {
            return (string.IsNullOrWhiteSpace(texto)) ? throw new System.Exception("Erro: entrada vazia ou com espacos em branco") : texto;
        }
    }
}
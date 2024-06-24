namespace bibliotecaSu.Entities
{
    public class Funcionario
    {
        protected internal int IdFuncionario { get; set; }

        public Funcionario(int idFuncionario)
        {
            IdFuncionario = idFuncionario;
        }
        protected void AdicionarLivro(string IsbnCode)
        {
            Console.WriteLine($"Livro '{IsbnCode}' adicionado.");
        }

        protected internal void RemoverLivro(string IsbnCode)
        {
            Console.WriteLine($"Livro '{IsbnCode}' removido.");
        }

        public static Funcionario RegistrarFuncionario(int idFuncionario)
        {
            return new Funcionario(idFuncionario);
        }
    }
}

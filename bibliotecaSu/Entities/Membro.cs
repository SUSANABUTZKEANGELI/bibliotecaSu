namespace bibliotecaSu.Entities
{
    public class Membro
    {
        private int IdMembro { get; set; }
        public string NomeMembro { get; set; }

        public Membro(string nomeMembro, int idMembro)
        {
            NomeMembro = nomeMembro;
            IdMembro = idMembro;
        }
        internal void PegarEmprestado(string livro)
        {
            Console.WriteLine($"Nome - {NomeMembro} empréstimo - '{livro}'.");
        }

        protected string ObterInformacoesDetalhadas()
        {
            return $"Nome: {NomeMembro}, ID: {IdMembro}";
        }
    }
}

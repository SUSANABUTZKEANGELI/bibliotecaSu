namespace bibliotecaSu.Entities
{
    internal class Livro
    {
        internal string IsbnCode { get; set; }
        public string Titulo { get; set; }
        protected string Autor { get; set; }
        public string Resumo { get; set; }

        public Livro(string titulo, string autor, string isbnCode, string resumo)
        {
            IsbnCode = isbnCode;
            Titulo = titulo;
            Autor = autor;
            Resumo = resumo;
        }

        public string ResumoLivro()
        {
            return $"Título: {Titulo}, Autor: {Autor}, ISBN: {IsbnCode}, Resumo: {Resumo}";
        }
    }
}

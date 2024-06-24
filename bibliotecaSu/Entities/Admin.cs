namespace bibliotecaSu.Entities
{
    public class Admin
    {
        private int IdAdmin { get; set; }

        public Admin(int idAdmin)
        {
            IdAdmin = idAdmin;
        }
        internal void GerenciarBiblioteca()
        {
            Console.WriteLine("Gerenciando ...");
        }

        protected string ObterInformacoesDetalhadas()
        {
            return $"ID do Admin: {IdAdmin}";
        }
    }
}

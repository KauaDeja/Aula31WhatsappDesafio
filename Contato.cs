namespace Aula31Whatsapp
{
    public class Contato
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }   

        /// <summary>
        /// Método construtor para Atribuir os nomes
        /// </summary>
        /// <param name="_nome">Objeto nome</param>
        /// <param name="_telefone">Objeto telfone</param>

        public Contato(string _nome, int _telefone)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
        }
    }
}
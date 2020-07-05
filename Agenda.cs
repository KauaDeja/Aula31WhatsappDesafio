using System;
using System.Collections.Generic;
using System.IO;

namespace Aula31Whatsapp
{
    public class Agenda : IAgenda
    {
        List<Contato> contato = new List<Contato>();

        private const string PATH = "Database/produto.csv";

        /// <summary>
        /// Criar Arquivo csv
        /// </summary>
        public Agenda()
        {
            string pasta = PATH.Split('/')[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        /// <summary>
        /// Vamos Cadastrar os contatos na agenda
        /// </summary>
        /// <param name="cont">Objeto Contato</param>
        public void Cadastrar(Contato cont)
        {
            var linha = new string [] {PrepararLinha(cont)};
            File.AppendAllLines(PATH, linha);   
        }
        /// <summary>
        /// Preparar linha do csv
        /// </summary>
        /// <param name="cont">Contato</param>
        /// <returns>nome=yan;telefone=12345678</returns>
          private string PrepararLinha(Contato cont)
        {
            return $"nome={cont.Nome};telefone={cont.Telefone}";
        }
        /// <summary>
        /// Fazemos um método para excluir determinados contatos da agenda
        /// </summary>
        /// <param name="Contato">Contato</param>
        public void Excluir(string Contato)
        {
            //Criando uma lista de string para salvar as linhas do csv
            List<string> linhas = new List<string>();

            //Utilizando o using para abrir e fechar o arquivo com a base de dados
            using(StreamReader file = new StreamReader(PATH)){
                //Lendo o arquivo
                string line;
                while ((line = file.ReadLine())!= null){
                    linhas.Add(line);
                }
                //Removendo todas as linhas que tenha o contato
                linhas.RemoveAll(l => l.Contains(Contato));
            }
            //Reescrevendo o arquivo
            using (StreamWriter output = new StreamWriter(PATH)){
                foreach(string ln in linhas){
                output.Write(ln + "\n");
                }
            }
        }

         public void Listar()
        {
            List<string> linhas = new List<string>();

            //Utilizando o using para abrir e fechar o arquivo com a base de dados
            using(StreamReader file = new StreamReader(PATH))
            {
                //Lendo o arquivo
                string line;
                while ((line = file.ReadLine())!= null)
                 {
                    linhas.Add(line);
                 }
            }
        }
        
        
       
    }
    
    

}
namespace Aula31Whatsapp
{
    public class Mensagem
    {
        public string TextoMensagem = "Vamos jogar um COD?";
        public Contato Destinatario { get; set; }

        public string Enviar(Contato contato)
        {   
            
             return $"Enviar a seguinte mensagem: '{TextoMensagem}' enviando para: {Destinatario}";
        }
    }
}
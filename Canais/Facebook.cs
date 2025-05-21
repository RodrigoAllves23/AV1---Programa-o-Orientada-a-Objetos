using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AV1___Programação_Orientada_a_Objetos.Canais
{
    using System;
    using AV1___Programação_Orientada_a_Objetos.Mensagens;
    public class Facebook : ICanalComunicacao
    {
        private string Usuario;

        public Facebook(string usuario)
        {
            Usuario = usuario;
        }

        public void EnviarMensagem(Mensagem mensagem)
        {
            Console.WriteLine($"[Facebook para {Usuario}]");
            mensagem.Exibir();
        }
    }
}

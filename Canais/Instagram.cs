using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1___Programação_Orientada_a_Objetos.Canais
{
    using System;
    using AV1___Programação_Orientada_a_Objetos.Mensagens;
    public class Instagram : ICanalComunicacao
    {
        private string Usuario;

        public Instagram(string usuario)
        {
            Usuario = usuario;
        }

        public void EnviarMensagem(Mensagem mensagem)
        {
            Console.WriteLine($"[Instagram para {Usuario}]");
            mensagem.Exibir();
        }
    }
}

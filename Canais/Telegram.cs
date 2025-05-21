using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1___Programação_Orientada_a_Objetos.Canais
{

    using System;
    using AV1___Programação_Orientada_a_Objetos.Mensagens;
    public class Telegram : ICanalComunicacao
    {
        private string? NumeroTelefone;
        private string? Usuario;

        public Telegram(string identificador, bool isNumero)
        {
            if (isNumero) NumeroTelefone = identificador;
            else Usuario = identificador;
        }

        public void EnviarMensagem(Mensagem mensagem)
        {
            string destino = NumeroTelefone ?? Usuario!;
            Console.WriteLine($"[Telegram para {destino}]");
            mensagem.Exibir();
        }
    }
}


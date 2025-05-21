using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1___Programação_Orientada_a_Objetos.Mensagens
{

    public abstract class Mensagem
    {
        public string Conteudo { get; protected set; }
        public DateTime DataEnvio { get; protected set; }

        protected Mensagem(string conteudo)
        {
            Conteudo = conteudo;
            DataEnvio = DateTime.Now;
        }

        public abstract void Exibir();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1___Programação_Orientada_a_Objetos.Mensagens
{
    using System;
    using AV1___Programação_Orientada_a_Objetos.Mensagens;


    public class MensagemTexto : Mensagem
    {
        public MensagemTexto(string conteudo) : base(conteudo) { }

        public override void Exibir()
        {
            Console.WriteLine($"[Texto] {DataEnvio}: {Conteudo}");
        }
    }
}

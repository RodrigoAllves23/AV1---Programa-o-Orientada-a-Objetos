using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AV1___Programação_Orientada_a_Objetos.Mensagens;

namespace AV1___Programação_Orientada_a_Objetos.Mensagens
{
    using System;

    public class MensagemFoto : Mensagem
    {
        public string Arquivo { get; private set; }
        public string Formato { get; private set; }

        public MensagemFoto(string conteudo, string arquivo, string formato) : base(conteudo)
        {
            Arquivo = arquivo;
            Formato = formato;
        }

        public override void Exibir()
        {
            Console.WriteLine($"[Foto] {DataEnvio}: {Conteudo}, Arquivo: {Arquivo}, Formato: {Formato}");
        }
    }
}


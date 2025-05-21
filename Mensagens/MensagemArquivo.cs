using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1___Programação_Orientada_a_Objetos.Mensagens
{
    using System;


    public class MensagemArquivo : Mensagem
    {
        public string Arquivo { get; private set; }
        public string Formato { get; private set; }

        public MensagemArquivo(string conteudo, string arquivo, string formato) : base(conteudo)
        {
            Arquivo = arquivo;
            Formato = formato;
        }

        public override void Exibir()
        {
            Console.WriteLine($"[Arquivo] {DataEnvio}: {Conteudo}, Arquivo: {Arquivo}, Formato: {Formato}");
        }
    }
}

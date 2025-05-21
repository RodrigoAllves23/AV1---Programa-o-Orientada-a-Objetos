using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1___Programação_Orientada_a_Objetos.Mensagens
{
    using System;


    public class MensagemVideo : Mensagem
    {
        public string Arquivo { get; private set; }
        public string Formato { get; private set; }
        public int DuracaoSegundos { get; private set; }

        public MensagemVideo(string conteudo, string arquivo, string formato, int duracao) : base(conteudo)
        {
            Arquivo = arquivo;
            Formato = formato;
            DuracaoSegundos = duracao;
        }

        public override void Exibir()
        {
            Console.WriteLine($"[Vídeo] {DataEnvio}: {Conteudo}, Arquivo: {Arquivo}, Formato: {Formato}, Duração: {DuracaoSegundos}s");
        }
    }
}

using System;
using System.Collections.Generic;
using AV1___Programação_Orientada_a_Objetos.Canais;
using AV1___Programação_Orientada_a_Objetos.Mensagens;

namespace AV1___Programação_Orientada_a_Objetos
{
    class Program
    {
        static List<string> historicoMensagens = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Chatbots ===");

            bool continuar = true;

            while (continuar)
            {
                ICanalComunicacao canal = SelecionarCanal();
                if (canal == null) continue;

                Mensagem mensagem = CriarMensagem();
                if (mensagem == null) continue;

                canal.EnviarMensagem(mensagem);

                historicoMensagens.Add($"{canal.GetType().Name} - {mensagem.DataEnvio} - {mensagem.Conteudo}");

                Console.WriteLine("\nDeseja enviar outra mensagem? (S/N)");
                string resposta = Console.ReadLine().Trim().ToUpper();

                continuar = resposta == "S";

                if (!continuar)
                {
                    Console.WriteLine("\n=== Histórico de Mensagens Enviadas ===");
                    foreach (var item in historicoMensagens)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

            Console.WriteLine("\nSistema encerrado.");
        }

        static ICanalComunicacao SelecionarCanal()
        {
            while (true)
            {
                Console.WriteLine("\nEscolha o canal:");
                Console.WriteLine("1 - WhatsApp");
                Console.WriteLine("2 - Telegram");
                Console.WriteLine("3 - Facebook");
                Console.WriteLine("4 - Instagram");

                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o número do WhatsApp: ");
                        string numeroWpp = Console.ReadLine();
                        return new WhatsApp(numeroWpp);

                    case "2":
                        Console.Write("Enviar para (1) Número ou (2) Usuário? ");
                        string tipoDest = Console.ReadLine();
                        if (tipoDest == "1")
                        {
                            Console.Write("Digite o número: ");
                            string numero = Console.ReadLine();
                            return new Telegram(numero, true);
                        }
                        else if (tipoDest == "2")
                        {
                            Console.Write("Digite o usuário: ");
                            string usuarioTg = Console.ReadLine();
                            return new Telegram(usuarioTg, false);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                            continue;
                        }

                    case "3":
                        Console.Write("Digite o usuário do Facebook: ");
                        string usuarioFb = Console.ReadLine();
                        return new Facebook(usuarioFb);

                    case "4":
                        Console.Write("Digite o usuário do Instagram: ");
                        string usuarioIg = Console.ReadLine();
                        return new Instagram(usuarioIg);

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        continue;
                }
            }
        }

        static Mensagem CriarMensagem()
        {
            while (true)
            {
                Console.WriteLine("\nEscolha o tipo de mensagem:");
                Console.WriteLine("1 - Texto");
                Console.WriteLine("2 - Foto");
                Console.WriteLine("3 - Vídeo");
                Console.WriteLine("4 - Arquivo");

                Console.Write("Opção: ");
                string tipo = Console.ReadLine();

                Console.Write("Digite o conteúdo da mensagem: ");
                string conteudo = Console.ReadLine();

                switch (tipo)
                {
                    case "1":
                        return new MensagemTexto(conteudo);

                    case "2":
                        Console.Write("Nome do arquivo da foto: ");
                        string arqFoto = Console.ReadLine();
                        Console.Write("Formato (ex: jpg): ");
                        string formatoFoto = Console.ReadLine();
                        return new MensagemFoto(conteudo, arqFoto, formatoFoto);

                    case "3":
                        Console.Write("Nome do arquivo de vídeo: ");
                        string arqVideo = Console.ReadLine();
                        Console.Write("Formato (ex: mp4): ");
                        string formatoVideo = Console.ReadLine();

                        int duracao;
                        while (true)
                        {
                            Console.Write("Duração em segundos: ");
                            if (int.TryParse(Console.ReadLine(), out duracao)) break;
                            Console.WriteLine("Por favor, insira um número inteiro válido.");
                        }

                        return new MensagemVideo(conteudo, arqVideo, formatoVideo, duracao);

                    case "4":
                        Console.Write("Nome do arquivo: ");
                        string arq = Console.ReadLine();
                        Console.Write("Formato (ex: pdf): ");
                        string formato = Console.ReadLine();
                        return new MensagemArquivo(conteudo, arq, formato);

                    default:
                        Console.WriteLine("Tipo de mensagem inválido. Tente novamente.");
                        continue;
                }
            }
        }
    }
}

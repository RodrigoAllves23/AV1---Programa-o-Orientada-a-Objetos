
# 🤖 Chatbot Multicanal em C#

Este projeto é um **sistema de chatbot em console** que permite o envio de mensagens por diferentes canais de comunicação, como WhatsApp, Telegram, Facebook e Instagram. Ele suporta diversos tipos de mensagens, incluindo texto, foto, vídeo e arquivos.

---

## 📋 Funcionalidades

- ✅ Envio de mensagens via **WhatsApp**, **Telegram**, **Facebook** e **Instagram**
- ✅ Tipos de mensagens: **Texto**, **Foto**, **Vídeo**, **Arquivo**
- ✅ **Validação de entrada** do usuário
- 🔁 Envio contínuo de mensagens com loop interativo
- 📝 Armazenamento de **histórico de mensagens**
- 🧱 Arquitetura orientada a objetos com uso de **herança**, **polimorfismo** e **interfaces**

---

## 📁 Estrutura de Pastas

```
├── Canais
│   ├── ICanalComunicacao.cs
│   ├── WhatsApp.cs
│   ├── Telegram.cs
│   ├── Facebook.cs
│   └── Instagram.cs
│
├── Mensagens
│   ├── Mensagem.cs (abstract)
│   ├── MensagemTexto.cs
│   ├── MensagemFoto.cs
│   ├── MensagemVideo.cs
│   └── MensagemArquivo.cs
│
├── Program.cs
└── README.md
```

---

## 🚀 Como executar

### Pré-requisitos

- [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/en-us/download)

### Passos para rodar

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/chatbot-csharp.git
   ```

2. Navegue até a pasta do projeto:

   ```bash
   cd chatbot-csharp
   ```

3. Compile e execute o programa:

   ```bash
   dotnet run
   ```

---

## 📌 Exemplo de uso

Ao iniciar o programa, você poderá:

1. Escolher o canal de envio da mensagem
2. Selecionar o tipo de mensagem (texto, foto, vídeo, arquivo)
3. Digitar o conteúdo e dados específicos (arquivo, duração etc.)
4. Enviar múltiplas mensagens ou encerrar
5. Ver o histórico final

---

## 💡 Conceitos aplicados

- **Programação Orientada a Objetos**
  - Abstração (`Mensagem`)
  - Herança e Polimorfismo (diferentes tipos de `Mensagem`)
  - Interfaces (`ICanalComunicacao`)
- **Princípios SOLID** (especialmente o de responsabilidade única)
- **Clean Code** (nomes claros, responsabilidades separadas)

---

## 📖 Futuras melhorias

- [ ] Exportar histórico para arquivo `.txt`
- [ ] Interface gráfica com **WinForms** ou **WPF**
- [ ] Integração real com APIs de mensagens (como Twilio, Meta API)
- [ ] Testes unitários com xUnit ou NUnit

---

## 🧑‍💻 Autor

**Rodrigo Alves dos Santos**  
💼 Estudante de Ciência da Computação (UNINOVE)  
🚀 Interesse: Desenvolvimento de sistemas, automação e IA  
📍 São Paulo - SP  

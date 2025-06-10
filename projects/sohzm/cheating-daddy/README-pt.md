# Cheating Daddy

> [!NOTE]  
> Use a versão mais recente do MacOS e Windows, versões antigas têm suporte limitado

> [!NOTE]  
> Durante os testes, ele não responderá se você apenas perguntar algo; é necessário simular o entrevistador fazendo uma pergunta, a qual ele responderá

Um assistente de IA em tempo real que fornece ajuda contextual durante videochamadas, entrevistas, apresentações e reuniões usando captura de tela e análise de áudio.

## Funcionalidades

- **Assistência de IA ao Vivo**: Ajuda em tempo real alimentada pelo Google Gemini 2.0 Flash Live
- **Captura de Tela & Áudio**: Analisa o que você vê e ouve para respostas contextuais
- **Múltiplos Perfis**: Entrevista, Chamada de Vendas, Reunião de Negócios, Apresentação, Negociação
- **Sobreposição Transparente**: Janela sempre no topo que pode ser posicionada em qualquer lugar
- **Modo Click-through**: Torna a janela transparente para cliques quando necessário
- **Multiplataforma**: Funciona em macOS, Windows e Linux (meio, não use, apenas para testes por enquanto)

## Configuração

1. **Obtenha uma Chave de API do Gemini**: Visite [Google AI Studio](https://aistudio.google.com/apikey)
2. **Instale as Dependências**: `npm install`
3. **Execute o App**: `npm start`

## Uso

1. Insira sua chave de API do Gemini na janela principal
2. Escolha seu perfil e idioma nas configurações
3. Clique em "Iniciar Sessão" para começar
4. Posicione a janela usando atalhos de teclado
5. A IA fornecerá assistência em tempo real com base na sua tela e no que o entrevistador perguntar

## Atalhos de Teclado

- **Movimentação da Janela**: `Ctrl/Cmd + Setas` - Move a janela
- **Click-through**: `Ctrl/Cmd + M` - Alterna eventos do mouse
- **Fechar/Voltar**: `Ctrl/Cmd + \` - Fecha a janela ou volta
- **Enviar Mensagem**: `Enter` - Envia texto para a IA

## Captura de Áudio

- **macOS**: [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) para áudio do sistema
- **Windows**: Captura de áudio loopback
- **Linux**: Entrada do microfone

## Requisitos

- Sistema operacional compatível com Electron (macOS, Windows, Linux)
- Chave de API do Gemini
- Permissões de gravação de tela
- Permissões de microfone/áudio

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
<div align="center">
  <img src="https://raw.githubusercontent.com/ai-shifu/ChatALL/main/src/assets/logo-cover.png" width=256></img>
  <p><strong>Converse com TODOS os Bots de IA ao Mesmo Tempo, Descubra o Melhor</strong></p>

[Deutsch](README_DE-DE.md) | English | [Español](README_ES-ES.md) | [Français](README_FR-FR.md) | [Italian](README_IT-IT.md) | [日本語](README_JA-JP.md) | [한국어](README_KO-KR.md) | [Русский](README_RU-RU.md) | [Tiếng Việt](README_VI-VN.md) | [简体中文](README_ZH-CN.md)

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/ai-shifu/ChatALL)

</div>

## Capturas de Tela

![Screenshot](https://raw.githubusercontent.com/ai-shifu/ChatALL/main/screenshots/screenshot-1.png?raw=true)

## Recursos

Bots de IA baseados em Modelos de Linguagem de Grande Porte (LLMs) são incríveis. No entanto, seu comportamento pode ser aleatório e diferentes bots se destacam em tarefas distintas. Se você quer a melhor experiência, não tente um por um. O ChatALL (nome em chinês: 齐叨) pode enviar prompts para vários bots de IA ao mesmo tempo, ajudando você a descobrir os melhores resultados. Tudo que você precisa fazer é [baixar, instalar](https://github.com/ai-shifu/ChatALL/releases) e perguntar.

### Isso é para você?

Os usuários típicos do ChatALL são:

- 🤠**Especialistas em LLMs**, que querem encontrar as melhores respostas ou criações dos LLMs.
- 🤓**Pesquisadores de LLMs**, que desejam comparar intuitivamente os pontos fortes e fracos de vários LLMs em diferentes áreas.
- 😎**Desenvolvedores de aplicações LLM**, que querem depurar rapidamente prompts e encontrar os modelos base mais eficientes.

### Bots Suportados

| Bots de IA                                                                     | Acesso Web  | API         | Observações                                 |
| ------------------------------------------------------------------------------ | ----------- | ----------- | ------------------------------------------- |
| [360 AI Brain](https://ai.360.cn/)                                             | Sim         | Sem API     |                                             |
| [Baidu ERNIE](https://yiyan.baidu.com/)                                        | Não         | Sim         |                                             |
| [Character.AI](https://character.ai/)                                          | Sim         | Sem API     |                                             |
| [ChatGLM2 6B & 130B](https://chatglm.cn/)                                      | Sim         | Sem API     | Não requer login                            |
| [ChatGPT](https://chatgpt.com)                                             | Sim         | Sim         | Navegação Web, Azure OpenAI incluído        |
| [Claude](https://www.anthropic.com/claude)                                     | Sim         | Sim         |                                             |
| [Code Llama](https://ai.meta.com/blog/code-llama-large-language-model-coding/) | Sim         | Sem API     |                                             |
| [Cohere Aya 23](https://cohere.com/blog/aya23)                                 | Não         | Sim         |                                             |
| [Cohere Command R Models](https://cohere.com/command)                          | Não         | Sim         |                                             |
| [Copilot](https://copilot.microsoft.com/)                                      | Sim         | Sem API     |                                             |
| [Dedao Learning Assistant](https://ai.dedao.cn/)                               | Em breve    | Sem API     |                                             |
| [Falcon 180B](https://huggingface.co/tiiuae/falcon-180B-chat)                  | Sim         | Sem API     |                                             |
| [Gemini](https://gemini.google.com/)                                           | Sim         | Sim         |                                             |
| [Gemma 2B & 7B](https://blog.google/technology/developers/gemma-open-models/)  | Sim         | Sem API     |                                             |
| [Gradio](https://gradio.app/)                                                  | Sim         | Sem API     | Para modelos Hugging Face/self-hosted       |
| [Groq Cloud](https://console.groq.com/docs/models)                             | Não         | Sim         |                                             |
| [HuggingChat](https://huggingface.co/chat/)                                    | Sim         | Sem API     |                                             |
| [iFLYTEK SPARK](http://xinghuo.xfyun.cn/)                                      | Sim         | Em breve    |                                             |
| [Kimi](https://kimi.moonshot.cn/               )                               | Sim         | Sem API     |                                             |
| [Llama 2 13B & 70B](https://ai.meta.com/llama/)                                | Sim         | Sem API     |                                             |
| [MOSS](https://moss.fastnlp.top/)                                              | Sim         | Sem API     |                                             |
| [Perplexity](https://www.perplexity.ai/)                                       | Sim         | Sem API     |                                             |
| [Phind](https://www.phind.com/)                                                | Sim         | Sem API     |                                             |
| [Pi](https://pi.ai)                                                            | Sim         | Sem API     |                                             |
| [Poe](https://poe.com/)                                                        | Sim         | Em breve    |                                             |
| [SkyWork](https://neice.tiangong.cn/)                                          | Sim         | Em breve    |                                             |
| [Tongyi Qianwen](http://tongyi.aliyun.com/)                                    | Sim         | Em breve    |                                             |
| [Vicuna 13B & 33B](https://lmsys.org/blog/2023-03-30-vicuna/)                  | Sim         | Sem API     | Não requer login                            |
| [WizardLM 70B](https://github.com/nlpxucan/WizardLM)                           | Sim         | Sem API     |                                             |
| [xAI Grok](https://x.ai)                                                       | Não         | Sim         |                                             |
| [YouChat](https://you.com/)                                                    | Sim         | Sem API     |                                             |
| [You](https://you.com/)                                                        | Sim         | Sem API     |                                             |
| [Zephyr](https://huggingface.co/spaces/HuggingFaceH4/zephyr-chat)              | Sim         | Sem API     |                                             |

Mais estão por vir. Vote nos seus bots favoritos nestas [issues](https://github.com/ai-shifu/ChatALL/labels/more%20LLMs).

### Nota sobre a Confiabilidade de Bots com Acesso Web

Bots de IA conectados à web (marcados com "Acesso Web") são inerentemente menos confiáveis e frequentemente enfrentam problemas de estabilidade, pois os provedores de serviço atualizam regularmente suas interfaces web e medidas de segurança. Essas conexões web dependem de engenharia reversa e são difíceis de manter, frequentemente quebrando de forma inesperada. Para uma experiência confiável, recomendamos fortemente o uso de bots que ofereçam acesso via API sempre que possível.

### Outros recursos

- Modo de prompt rápido: envie o próximo prompt sem esperar a conclusão do anterior
- Salve o histórico de chat localmente, proteja sua privacidade
- Destaque a resposta que você gostou, exclua as ruins
- Ative/desative qualquer bot a qualquer momento
- Alterne entre visualização de uma, duas ou três colunas
- Atualização automática para a última versão
- Modo escuro (contribuição de @tanchekwei)
- Teclas de atalho. Pressione <kbd>Ctrl</kbd> + <kbd>/</kbd> para ver todas (contribuição de @tanchekwei)
- Múltiplos chats (contribuição de @tanchekwei)
- Configuração de proxy (contribuição de @msaong)
- Gerenciamento de prompts (contribuição de @tanchekwei)
- Suporte a múltiplos idiomas (Chinês, Inglês, Alemão, Francês, Russo, Vietnamita, Coreano, Japonês, Espanhol, Italiano)
- Suporte a Windows, macOS e Linux

Funcionalidades planejadas:

Você é bem-vindo para contribuir com esses recursos.

- [ ] Implantar front-end no GitHub Pages

## Privacidade

Todo o histórico de chat, configurações e dados de login são salvos localmente no seu computador.

O ChatALL coleta dados anônimos de uso para nos ajudar a melhorar o produto. Incluindo:

- Quais bots de IA são usados e o tamanho do prompt. Não inclui o conteúdo do prompt.
- Tamanho da resposta e quais respostas são excluídas/destacadas. Não inclui o conteúdo da resposta.

## Pré-requisitos

O ChatALL é um cliente, não um proxy. Portanto, você deve:

1. Ter contas ativas e/ou tokens de API para os bots.
2. Ter conexões de rede confiáveis com os bots.

## Baixar / Instalar

Baixe em https://github.com/ai-shifu/ChatALL/releases

### No Windows

Basta baixar o arquivo \*-win.exe e seguir a instalação.

### No macOS

Para Macs Apple Silicon (CPU M1, M2), baixe o arquivo \*-mac-arm64.dmg.

Para outros Macs, baixe o arquivo \*-mac-x64.dmg.

Se você usa [Homebrew](https://brew.sh/), também pode instalar com:

```bash
brew install --cask chatall
```

### No Linux

Distribuições baseadas em Debian: Baixe o arquivo .deb, dê um duplo clique e instale o software.
Distribuições baseadas em Arch: Você pode clonar o ChatALL do AUR [aqui](https://aur.archlinux.org/packages/chatall-bin). Instale manualmente ou usando um helper AUR como yay ou paru.
Outras Distribuições: Baixe o arquivo .AppImage, torne-o executável e aproveite a experiência de clique para rodar. Você também pode usar o [AppimageLauncher](https://github.com/TheAssassin/AppImageLauncher).

## Solução de Problemas

Se você encontrar algum problema ao usar o ChatALL, tente os seguintes métodos para resolvê-lo:

1. **Atualizar** - pressione <kbd>Ctrl</kbd> + <kbd>R</kbd> ou <kbd>⌘</kbd> + <kbd>R</kbd>.
2. **Reiniciar** - feche o ChatALL e execute novamente.
3. **Refazer login** - clique no botão de configurações no canto superior direito, depois clique no link correspondente de login/logout para refazer login no site.
4. **Criar novo chat** - clique no botão `New Chat` e envie o prompt novamente.

Se nenhum dos métodos acima funcionar, tente **resetar o ChatALL**. Observe que isso apagará todas as suas configurações e histórico de mensagens.

Você pode resetar o ChatALL excluindo os seguintes diretórios:

- Windows: `C:\Users\<user>\AppData\Roaming\chatall\`
- Linux: `/home/<user>/.config/chatall/`
- macOS: `/Users/<user>/Library/Application Support/chatall/`

Se o problema persistir, por favor [abra uma issue](https://github.com/ai-shifu/ChatALL/issues).

## Para desenvolvedores

### Contribuir com um Bot

[O guia](https://github.com/ai-shifu/ChatALL/wiki/%E5%A6%82%E4%BD%95%E6%B7%BB%E5%8A%A0%E4%B8%80%E4%B8%AA%E6%96%B0%E7%9A%84-AI-%E5%AF%B9%E8%AF%9D%E6%9C%BA%E5%99%A8%E4%BA%BA) pode te ajudar.

### Executar

```bash
npm install
npm run electron:serve
```

### Build

Build para sua plataforma atual:

```bash
npm run electron:build
```

Build para todas as plataformas:

```bash
npm run electron:build -- -wml --x64 --arm64
```

## Créditos

### Contribuidores

<a href="https://github.com/ai-shifu/ChatALL/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ai-shifu/ChatALL" />
</a>

### Outros

- GPT-4 contribuiu com grande parte do código
- ChatGPT, Copilot e Google forneceram muitas soluções (nesta ordem)
- Inspirado por [ChatHub](https://github.com/chathub-dev/chathub). Respeito!

## Patrocínio

Se você gostou deste projeto, por favor considere:

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F1F8KZJGJ)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-22

---
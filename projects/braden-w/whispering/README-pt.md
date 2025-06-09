<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">Ditado contínuo impulsionado pelo modelo Whisper da OpenAI</p>
</p>

<p align="center">
  <!-- Última Versão -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- Licença -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges para Tecnologias -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Badges de Suporte a Plataformas -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>

## Sobre

Whispering é um aplicativo de transcrição open-source que oferece funcionalidade de reconhecimento de voz global, com opções como atalhos de teclado e cópia e colagem automática para tornar a digitação por voz o mais fluida possível.

Por trás dos panos, é impulsionado pelo modelo Whisper da OpenAI, tornando-o significativamente mais preciso do que o ditado nativo do sistema.

> **Nota Importante**: O Whispering é projetado principalmente como uma ferramenta de transcrição, não como uma ferramenta de gravação. Para gravações mais longas, onde a confiabilidade é crucial, recomendo o uso de um aplicativo dedicado de gravação no seu telefone ou dispositivo, que utilize APIs nativas de gravação. Isso garante melhor qualidade de áudio e estabilidade na gravação.

## Demonstrações

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## Principais Recursos

1. **Transcrição Global**: Acesse a funcionalidade de reconhecimento de voz do Whisper em qualquer lugar com um atalho global de teclado ou em apenas dois cliques.
2. **Experiência Multiplataforma**:
   - Aplicativo Desktop: Permite transcrição global em todos os aplicativos.
   - Extensão para Navegador: Oferece transcrição global no navegador ao se comunicar com o aplicativo web.
3. **Integração com Chats**: A extensão do navegador adiciona um botão de gravação nos sites do ChatGPT e Claude, permitindo entrada de voz e transcrição diretamente na interface do chat.
4. **Gerenciamento de Transcrições**: Revise e edite transcrições dentro do app Whispering para garantir precisão e clareza.
5. **Integração Automática com Área de Transferência**: Após a transcrição, o texto é automaticamente copiado para sua área de transferência. Há também uma opção de colagem automática.

## Como meus dados são armazenados?

O Whispering armazena o máximo de dados possível localmente no seu dispositivo, incluindo gravações e transcrições de texto. Essa abordagem garante máxima privacidade e segurança dos dados. Veja uma visão geral de como os dados são tratados:

1. **Armazenamento Local**: Gravações de voz e transcrições são armazenadas no IndexedDB, que é usado como armazenamento de blobs e para guardar todos os seus dados, como textos e transcrições.

2. **Serviço de Transcrição**: Os únicos dados enviados para outro local são suas gravações para um serviço externo de transcrição—caso você escolha um. Você tem as seguintes opções:
   - Serviços externos como OpenAI ou Groq
   - Um serviço local de transcrição, como o `faster-whisper-server`, que mantém tudo no próprio dispositivo

3. **Configurações Ajustáveis**: Você pode alterar o serviço de transcrição nas configurações para garantir máxima funcionalidade local.

## Instalação

### Aplicativo Web

Acesse [whispering.bradenwong.com](https://whispering.bradenwong.com/), que possui a versão mais recente da pasta `apps/app` hospedada na Vercel.

### Extensão para Chrome

Instale a extensão para Chrome na Chrome Web Store [aqui](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo).

### Aplicativo Desktop

Para baixar e instalar o aplicativo desktop Whispering, siga os passos para seu sistema operacional:

#### Windows

1. Baixe o pacote de instalação terminado em `.msi` na [página de lançamentos](https://github.com/braden-w/whispering/releases).
2. Abra o arquivo `.msi` baixado para iniciar o instalador.
3. Se for alertado como inseguro, clique em `Mais Informações` -> `Executar Assim Mesmo` para continuar com a instalação.
4. Siga as instruções na tela para concluir a instalação.

#### macOS

Para macOS, siga estes passos para instalar o Whispering:

1. **Baixe o pacote de instalação**:
   - Visite a [página de lançamentos](https://github.com/braden-w/whispering/releases).
   - Escolha o pacote apropriado:
     - Para Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - Para Intel: `Whispering_x.x.x_x64.dmg`

2. **Instale o aplicativo**:
   - Abra o arquivo `.dmg` baixado.
   - Arraste o app Whispering para a pasta Aplicativos.

3. **Abra o Whispering**:
   - Abra o Whispering na pasta Aplicativos.
   - Se aparecer um aviso sobre desenvolvedor não verificado:
     - Clique em `Cancelar`
     - Clique com o botão direito no app no Finder e selecione `Abrir`

4. **Resolução de Problemas** (Apenas Apple Silicon):
   Se aparecer o erro `"Whispering" está danificado e não pode ser aberto`:
   - Abra o Terminal
   - Execute o seguinte comando:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - Tente abrir o aplicativo novamente

Após concluir esses passos, o Whispering deve estar pronto para uso em seu macOS.

#### Linux

Para Linux, existem várias opções de instalação disponíveis. Escolha a que melhor se adapta ao seu ambiente:

1. **AppImage**:

   - Baixe o arquivo `.AppImage` na [página de lançamentos](https://github.com/braden-w/whispering/releases).
   - Torne o arquivo executável:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - Execute o AppImage:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **Pacote DEB (Debian/Ubuntu)**:
   - Baixe o arquivo `.deb` na [página de lançamentos](https://github.com/braden-w/whispering/releases).
   - Instale o pacote usando o `dpkg`:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - Resolva possíveis dependências:
     ```bash
     sudo apt-get install -f
     ```

Após a instalação, o aplicativo estará pronto para uso.

## Uso

### Extensão para Chrome

Após instalar a extensão para Chrome, você encontrará um ícone do Whispering na barra de extensões do navegador. Clique nesse ícone para abrir a extensão. Clique no botão do microfone para gravar sua voz e depois clique no botão quadrado quando terminar. Sua transcrição aparecerá na caixa de texto abaixo.

Para acessar o recurso do ChatGPT ou Claude, navegue até a página do ChatGPT ou Claude. Você verá um novo botão de gravação na interface do chat. Clique nesse botão para iniciar e parar a gravação, e o texto transcrito será automaticamente inserido no campo de entrada do chat.

Para acessar o recurso de atalho, pressione <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> ou <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (configurável posteriormente nos atalhos da extensão do Chrome) para iniciar uma gravação em qualquer site. A transcrição será automaticamente copiada para sua área de transferência e colada no campo de entrada atual.

A extensão do Chrome se comunica com [whispering.bradenwong.com](https://whispering.bradenwong.com), e tentará automaticamente criar uma aba em segundo plano caso não encontre uma. A maioria dos bugs pode ser atribuída a falhas nessa comunicação, como casos raros em que a aba entra em modo de suspensão.

### Aplicativo Web

O aplicativo web está disponível em [whispering.bradenwong.com](https://whispering.bradenwong.com). Clique no botão do microfone para gravar sua voz e depois clique no botão quadrado ao finalizar. Sua transcrição aparecerá na caixa de texto.

### Aplicativo Desktop

Após instalar o aplicativo desktop Whispering, pressione <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (configurável nas configurações) para iniciar uma gravação de qualquer lugar no seu desktop. A transcrição será copiada automaticamente para sua área de transferência e colada, embora ambas as funções possam ser ativadas ou desativadas nas configurações.

## Construído Com

#### Web e Desktop

O aplicativo Whispering é construído com as seguintes tecnologias e bibliotecas:

- [Svelte 5](https://svelte.dev): Biblioteca escolhida para reatividade de UI.
- [SvelteKit](https://kit.svelte.dev/docs): Para roteamento e geração de site estático, utilizado tanto no site quanto no frontend estático do app Tauri.
- [Tauri](https://tauri.studio/en/docs/intro/): Framework para aplicativo desktop.
- [Effect-TS](https://github.com/Effect-TS/effect): Para adicionar programação funcional e escrever funções extremamente seguras em tipos, onde os erros fazem parte do tipo de retorno da assinatura da função.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Uma biblioteca de toast simples e personalizável para aplicações Svelte. Utilizada para capturar e exibir erros propagados pelo Effect-TS usando a função `renderAsToast`.
- [TanStack Table](https://tanstack.com/table): Para alimentar todas as tabelas de dados.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): Uma API de baixo nível para armazenar grandes quantidades de dados estruturados no navegador. Sincronizada com Tanstack Table.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): Biblioteca de componentes de UI escolhida.
- [TailwindCSS](https://tailwindcss.com/docs): Framework CSS utilitário para criação rápida de interfaces customizadas.
- [Turborepo](https://turborepo.org/): Para gerenciamento de monorepo, permitindo que `apps/app` e `apps/extension` compartilhem a mesma base de código, reduzindo drasticamente a duplicação e, mais importante, mantendo uma única fonte de verdade.
- [Rust](https://www.rust-lang.org): Para estender recursos do app desktop, como o uso do crate `enigo` para manipulação de colagem automática.
- [Vercel](https://vercel.com/): Hospedagem adequada para projetos de hobby e com boas integrações com Turborepo.
- [Zapsplat.com](https://www.zapsplat.com/): Biblioteca de efeitos sonoros royalty-free.

#### Extensão

A extensão Chrome do Whispering é construída utilizando:

- [Plasmo](https://docs.plasmo.com/): Framework para desenvolvimento de extensões para Chrome. Utilizamos o [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) para comunicação com o site do Whispering.
- [Effect-TS](https://github.com/Effect-TS/effect): Para adicionar programação funcional e escrever funções extremamente seguras em tipos, onde os erros fazem parte do tipo de retorno da assinatura da função.
- [React](https://reactjs.org): Biblioteca de reatividade de UI para a extensão Chrome, já que o Plasmo infelizmente não suporta Svelte 5.
- [ShadCN](https://github.com/shadcn): Biblioteca de componentes de UI para a extensão Chrome.
- [TailwindCSS](https://tailwindcss.com/docs): Um framework CSS orientado a utilitários para construir interfaces de usuário personalizadas rapidamente.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): A API de extensão do Chrome.
- [Zapsplat.com](https://www.zapsplat.com/): Uma biblioteca de efeitos sonoros livres de royalties.

## Executar o Whispering em Modo de Desenvolvimento Local

Para configurar o projeto em sua máquina local, siga estes passos:

1. Clone o repositório: `git clone https://github.com/braden-w/whispering.git`
2. Entre no diretório do projeto: `cd whispering`
3. Instale as dependências necessárias: `pnpm i`

Para executar o aplicativo desktop e o site do Whispering em modo de desenvolvimento:

4. Entre no diretório do aplicativo: `cd apps/app`
5. Execute o servidor de desenvolvimento: `pnpm tauri dev`

O aplicativo desktop deve abrir automaticamente para desenvolvimento local. Para desenvolver o aplicativo web, abra o navegador e acesse `http://localhost:5173`.

Para executar a extensão do Whispering para Chrome em modo de desenvolvimento:

4. Entre no diretório da extensão: `cd apps/extension`
5. Execute o servidor de desenvolvimento: `pnpm dev --target=chrome-mv3`

Para desenvolver a extensão para o Chrome, carregue-a no Chrome acessando `chrome://extensions`, habilite o modo de desenvolvedor e carregue a pasta `apps/extension/build/{platform}-{manifest-version}-dev` como uma extensão não empacotada.

## Compile o Executável Você Mesmo

Se você tiver dúvidas quanto à confiabilidade dos instaladores ou quiser mais controle, sempre poderá compilar o executável por conta própria. Isso requer uma configuração extra, mas garante que você está executando o código que espera. Essa é a beleza do software open-source!

### Chrome

1. Entre no diretório da extensão: `cd apps/extension`
2. Instale as dependências necessárias: `pnpm i`
3. Execute o build do Plasmo: `pnpm plasmo build --target=chrome-mv3`
4. O resultado estará em `apps/extension/build/chrome-mv3-prod`, que pode ser carregado no Chrome como uma extensão não empacotada.
5. Alternativamente, você pode compilar a extensão para a Chrome Web Store: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. Entre no diretório da extensão: `cd apps/extension`
2. Instale as dependências necessárias: `pnpm i`
3. Execute o build do Plasmo: `pnpm plasmo build --target=firefox-mv3`
4. O resultado estará em `apps/extension/build/firefox-mv3-prod`, que pode ser carregado no Chrome como uma extensão não empacotada.
5. Alternativamente, você pode compilar a extensão para a Chrome Web Store: `pnpm plasmo build --target=firefox-mv3 --release`

### Desktop

1. Entre no diretório do aplicativo: `cd apps/app`
2. Instale as dependências necessárias: `pnpm i`
3. Execute o build do Tauri: `pnpm tauri build`
4. Você pode encontrar o executável no diretório `apps/app/target/release`.

## Contribuindo

Agradecemos contribuições da comunidade! Se você quiser contribuir com o Whispering, siga estes passos:

1. Faça um fork do repositório.
2. Crie um novo branch para sua funcionalidade ou correção de bug: `git checkout -b feature/nome-da-sua-funcionalidade` ou `git checkout -b fix/nome-da-sua-correção`
3. Faça suas alterações e faça commit delas com uma mensagem descritiva.
4. Envie seu branch para o seu fork: `git push origin nome-do-seu-branch`
5. Crie um pull request do seu fork para o repositório original.

Por favor, certifique-se de que seu código segue as convenções estabelecidas e está bem documentado.

## Licença

Whispering é distribuído sob a [Licença MIT](https://opensource.org/licenses/MIT).

## Patrocinadores

Este projeto conta com o apoio das seguintes pessoas e organizações incríveis:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## Suporte e Feedback

Se você encontrar algum problema ou tiver sugestões de melhorias, por favor, abra uma issue na [aba de issues do GitHub](https://github.com/braden-w/whispering/issues) ou entre em contato pelo [whispering@bradenwong.com](mailto:whispering@bradenwong.com). Seu feedback é muito apreciado!

Obrigado por usar o Whispering e boa escrita!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---
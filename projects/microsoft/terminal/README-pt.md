![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Bem-vindo ao repositório do Windows Terminal, Console e Linha de Comando

<details>
  <summary><strong>Índice</strong></summary>

- [Instalando e executando o Windows Terminal](#installing-and-running-windows-terminal)
  - [Microsoft Store \[Recomendado\]](#microsoft-store-recommended)
  - [Outros métodos de instalação](#other-install-methods)
    - [Via GitHub](#via-github)
    - [Via Windows Package Manager CLI (também conhecido como winget)](#via-windows-package-manager-cli-aka-winget)
    - [Via Chocolatey (não oficial)](#via-chocolatey-unofficial)
    - [Via Scoop (não oficial)](#via-scoop-unofficial)
- [Instalando o Windows Terminal Canary](#installing-windows-terminal-canary)
- [Roteiro do Windows Terminal](#windows-terminal-roadmap)
- [Visão geral do Terminal e Console](#terminal--console-overview)
  - [Windows Terminal](#windows-terminal)
  - [O Host do Console do Windows](#the-windows-console-host)
  - [Componentes Compartilhados](#shared-components)
  - [Criando o novo Windows Terminal](#creating-the-new-windows-terminal)
- [Recursos](#resources)
- [FAQ](#faq)
  - [Compilei e executei o novo Terminal, mas ele parece igual ao console antigo](#i-built-and-ran-the-new-terminal-but-it-looks-just-like-the-old-console)
- [Documentação](#documentation)
- [Contribuindo](#contributing)
- [Comunicando-se com a Equipe](#communicating-with-the-team)
- [Orientação para Desenvolvedores](#developer-guidance)
- [Pré-requisitos](#prerequisites)
- [Compilando o Código](#building-the-code)
  - [Compilando no PowerShell](#building-in-powershell)
  - [Compilando no Cmd](#building-in-cmd)
- [Executando e Depurando](#running--debugging)
  - [Orientação de Codificação](#coding-guidance)
- [Código de Conduta](#code-of-conduct)

</details>

<br />

Este repositório contém o código-fonte para:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* O host do console do Windows (`conhost.exe`)
* Componentes compartilhados entre os dois projetos
* [ColorTool](./src/tools/ColorTool)
* [Projetos de exemplo](./samples)
  que mostram como consumir as APIs do Console do Windows

Repositórios relacionados incluem:

* [Documentação do Windows Terminal](https://docs.microsoft.com/windows/terminal)
  ([Repositório: Contribua para a documentação](https://github.com/MicrosoftDocs/terminal))
* [Documentação da API do Console](https://github.com/MicrosoftDocs/Console-Docs)
* [Fonte Cascadia Code](https://github.com/Microsoft/Cascadia-Code)

## Instalando e executando o Windows Terminal

> [!NOTA]
> O Windows Terminal requer Windows 10 2004 (build 19041) ou posterior

### Microsoft Store [Recomendado]

Instale o [Windows Terminal pela Microsoft Store][store-install-link].
Isso permite que você esteja sempre na versão mais recente quando lançarmos novas versões
com upgrades automáticos.

Este é o nosso método preferido.

### Outros métodos de instalação

#### Via GitHub

Para usuários que não conseguem instalar o Windows Terminal pela Microsoft Store,
as versões lançadas podem ser baixadas manualmente na [página de Releases deste repositório](https://github.com/microsoft/terminal/releases).

Baixe o arquivo `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` da seção **Assets**. Para instalar o aplicativo, basta clicar duas vezes no arquivo `.msixbundle` e o instalador deve ser executado automaticamente. Se isso falhar por algum motivo, você pode tentar o seguinte comando em um prompt do PowerShell:

```powershell
# NOTA: Se você estiver usando PowerShell 7+, execute
# Import-Module Appx -UseWindowsPowerShell
# antes de usar Add-AppxPackage.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTA]
> Se você instalar o Terminal manualmente:
>
> * Pode ser necessário instalar o [Pacote de Framework VC++ v14 Desktop](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages).
>   Isso só deve ser necessário em versões antigas do Windows 10 e apenas se você receber um erro sobre pacotes de framework ausentes.
> * O Terminal não será atualizado automaticamente quando novas versões forem lançadas, então você precisará
>   instalar regularmente a versão mais recente do Terminal para receber todas as correções e melhorias!

#### Via Windows Package Manager CLI (também conhecido como winget)

Usuários do [winget](https://github.com/microsoft/winget-cli) podem baixar e instalar
a versão mais recente do Terminal instalando o pacote `Microsoft.WindowsTerminal`:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTA]
> O suporte a dependências está disponível na versão [1.6.2631 ou posterior](https://github.com/microsoft/winget-cli/releases) do WinGet. Para instalar o lançamento estável do Terminal 1.18 ou posterior, certifique-se de ter a versão atualizada do cliente WinGet.

#### Via Chocolatey (não oficial)

Usuários do [Chocolatey](https://chocolatey.org) podem baixar e instalar a versão
mais recente do Terminal instalando o pacote `microsoft-windows-terminal`:

```powershell
choco install microsoft-windows-terminal
```

Para atualizar o Windows Terminal usando o Chocolatey, execute o seguinte:

```powershell
choco upgrade microsoft-windows-terminal
```

Se você tiver algum problema ao instalar/atualizar o pacote, acesse a
[página do pacote do Windows Terminal](https://chocolatey.org/packages/microsoft-windows-terminal) e siga o
[processo de triagem do Chocolatey](https://chocolatey.org/docs/package-triage-process)

#### Via Scoop (não oficial)

Usuários do [Scoop](https://scoop.sh) podem baixar e instalar a versão mais recente do Terminal
instalando o pacote `windows-terminal`:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Para atualizar o Windows Terminal usando Scoop, execute o seguinte:

```powershell
scoop update windows-terminal
```

Se você tiver algum problema ao instalar/atualizar o pacote, pesquise ou relate na
[página de issues](https://github.com/lukesampson/scoop-extras/issues) do repositório Scoop Extras bucket.

---

## Instalando o Windows Terminal Canary
O Windows Terminal Canary é uma versão de build noturna do Windows Terminal. Esta versão contém o código mais recente do nosso branch `main`, dando a você a oportunidade de experimentar recursos antes que eles cheguem ao Windows Terminal Preview.

O Windows Terminal Canary é nossa oferta menos estável, então você pode encontrar bugs antes de termos a chance de encontrá-los.

O Windows Terminal Canary está disponível como distribuição App Installer e distribuição ZIP portátil.

A distribuição App Installer suporta atualizações automáticas. Devido a limitações da plataforma, este instalador só funciona no Windows 11.

A distribuição ZIP portátil é um aplicativo portátil. Ele não será atualizado automaticamente nem verificará atualizações automaticamente. Esta distribuição ZIP portátil funciona no Windows 10 (19041+) e Windows 11.

| Distribuição  | Arquitetura     | Link                                                 |
|---------------|:---------------:|------------------------------------------------------|
| App Installer | x64, arm64, x86 | [download](https://aka.ms/terminal-canary-installer) |
| Portable ZIP  | x64             | [download](https://aka.ms/terminal-canary-zip-x64)   |
| Portable ZIP  | ARM64           | [download](https://aka.ms/terminal-canary-zip-arm64) |
| Portable ZIP  | x86             | [download](https://aka.ms/terminal-canary-zip-x86)   |

_Saiba mais sobre os [tipos de distribuições do Windows Terminal](https://learn.microsoft.com/windows/terminal/distributions)._

---

## Roteiro do Windows Terminal

O plano para o Windows Terminal [está descrito aqui](/doc/roadmap-2023.md) e
será atualizado conforme o andamento do projeto.

## Visão geral do Terminal & Console

Reserve alguns minutos para revisar a visão geral abaixo antes de mergulhar no
código:

### Windows Terminal

O Windows Terminal é um novo aplicativo de terminal moderno, rico em recursos e produtivo
para usuários de linha de comando. Ele inclui muitos dos recursos mais frequentemente
solicitados pela comunidade de linha de comando do Windows, incluindo suporte a abas, texto rico,
globalização, configurabilidade, temas & estilos e muito mais.

O Terminal também precisa atender às nossas metas e métricas para garantir que permaneça
rápido e eficiente, e não consuma grandes quantidades de memória ou energia.

### O Host do Console do Windows

O host do Console do Windows, `conhost.exe`, é a experiência original de linha de comando do Windows. Ele também hospeda a infraestrutura de linha de comando do Windows e o servidor de API do Console do Windows, motor de entrada, motor de renderização, preferências do usuário, etc. O código do host do console neste repositório é o código-fonte real a partir do qual o `conhost.exe` do próprio Windows é compilado.

Desde que assumiu a linha de comando do Windows em 2014, a equipe adicionou
vários novos recursos ao Console, incluindo transparência de fundo,
seleção baseada em linhas, suporte a [sequências ANSI / Virtual Terminal](https://en.wikipedia.org/wiki/ANSI_escape_code), [cores 24-bit](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/),
um [Pseudoconsolo ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/),
e mais.

No entanto, porque o principal objetivo do Console do Windows é manter a compatibilidade
retroativa, não pudemos adicionar muitos dos recursos que a comunidade
(e a equipe) desejam nos últimos anos, incluindo abas,
texto unicode e emoji.

Essas limitações nos levaram a criar o novo Windows Terminal.

> Você pode ler mais sobre a evolução da linha de comando em geral, e da linha de comando do Windows especificamente, [nesta série de posts no blog](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
> no blog da equipe da Linha de Comando.

### Componentes Compartilhados

Ao reformular o Console do Windows, modernizamos bastante sua base de código,
separando logicamente entidades em módulos e classes, introduzindo pontos-chave de extensibilidade,
substituindo várias coleções e containers antigos e próprios por containers [STL](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) mais seguros e eficientes,
e tornando o código mais simples e seguro utilizando as [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil) da Microsoft.

Essa reformulação resultou em vários componentes-chave do Console disponíveis
para reutilização em qualquer implementação de terminal no Windows. Esses componentes incluem um novo motor de layout e renderização de texto baseado em DirectWrite, um buffer de texto capaz de armazenar tanto UTF-16 quanto UTF-8, um parser/emissor VT, e mais.

### Criando o novo Windows Terminal

Quando começamos a planejar o novo aplicativo Windows Terminal, exploramos e
avaliamos várias abordagens e stacks de tecnologia. Por fim, decidimos que
nossas metas seriam melhor atendidas continuando o investimento em nossa base de
código C++, o que nos permitiria reutilizar vários dos componentes modernizados
mencionados tanto no Console existente quanto no novo Terminal. Além disso,
percebemos que isso nos permitiria construir grande parte do núcleo do Terminal
como um controle de interface reutilizável que outros podem incorporar em seus
próprios aplicativos.

O resultado desse trabalho está contido neste repositório e entregue como o
aplicativo Windows Terminal que você pode baixar da Microsoft Store ou
[diretamente das releases deste repositório](https://github.com/microsoft/terminal/releases).

---

## Recursos

Para mais informações sobre o Windows Terminal, você pode achar alguns desses
recursos úteis e interessantes:

* [Blog da Linha de Comando](https://devblogs.microsoft.com/commandline)
* [Série de posts Command-Line Backgrounder](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Lançamento do Windows Terminal: [Vídeo "Sizzle" do Terminal](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Lançamento do Windows Terminal: [Sessão Build 2019](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal com Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [Episódio 54 - Kayla Cinnamon e Rich Turner sobre DevOps na equipe do Windows Terminal](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Sessão Microsoft Ignite 2019: [A Linha de Comando Moderna do Windows: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## FAQ

### Compilei e executei o novo Terminal, mas ele parece igual ao console antigo

Causa: Você está abrindo a solução incorreta no Visual Studio.

Solução: Certifique-se de estar compilando e implantando o projeto `CascadiaPackage` no Visual Studio.

> [!NOTA]
> `OpenConsole.exe` é apenas um `conhost.exe` compilado localmente, o clássico
> Console do Windows que hospeda a infraestrutura de linha de comando do Windows. O OpenConsole
> é usado pelo Windows Terminal para conectar-se e comunicar-se com aplicativos de linha de comando (via
> [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)).

---

## Documentação

Toda a documentação do projeto está localizada em [aka.ms/terminal-docs](https://aka.ms/terminal-docs). Se você quiser
contribuir para a documentação, envie um pull request no [repositório da Documentação do Windows Terminal](https://github.com/MicrosoftDocs/terminal).

---

## Contribuindo

Estamos animados para trabalhar junto com você, nossa incrível comunidade, para construir e
aprimorar o Windows Terminal\!

***ANTES de começar a trabalhar em um recurso/correção***, leia e siga nosso
[Guia do Contribuidor](./CONTRIBUTING.md)
para evitar esforços desperdiçados ou duplicados.

## Comunicando-se com a Equipe

A maneira mais fácil de se comunicar com a equipe é via issues do GitHub.

Por favor, envie novas issues, solicitações de recursos e sugestões, mas **FAÇA uma busca por
issues abertas/fechadas semelhantes já existentes antes de criar uma nova issue.**

Se você quiser fazer uma pergunta que não acha que justifica uma issue
(ainda), entre em contato conosco pelo Twitter:

* Christopher Nguyen, Gerente de Produto:
  [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, Líder de Engenharia: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, Desenvolvedor Sênior: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, Desenvolvedor: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, Desenvolvedor
* Leonard Hecker, Desenvolvedor: [@LeonardHecker](https://twitter.com/LeonardHecker)

## Orientação para Desenvolvedores

## Pré-requisitos

Você pode configurar seu ambiente para compilar o Terminal de duas formas:

### Usando o arquivo de configuração do WinGet

Depois de clonar o repositório, você pode usar um [arquivo de configuração WinGet](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine)
para preparar seu ambiente. O [arquivo de configuração padrão](.config/configuration.winget) instala o Visual Studio 2022 Community e o restante das ferramentas necessárias. Existem duas outras variantes do arquivo de configuração disponíveis no diretório [.config](.config) para as edições Enterprise & Professional do Visual Studio 2022. Para executar o arquivo de configuração padrão, você pode clicar duas vezes no arquivo pelo explorador ou executar o seguinte comando:

```powershell
winget configure .config\configuration.winget
```

### Configuração manual

* Você deve estar executando o Windows 10 2004 (build >= 10.0.19041.0) ou posterior para executar
  o Windows Terminal
* Você deve [habilitar o Modo de Desenvolvedor nas Configurações do Windows](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development)
  para instalar e executar o Windows Terminal localmente
* Você deve ter o [PowerShell 7 ou posterior](https://github.com/PowerShell/PowerShell/releases/latest) instalado
* Você deve ter o [SDK do Windows 11 (10.0.22621.0)](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/) instalado
* Você deve ter pelo menos o [VS 2022](https://visualstudio.microsoft.com/downloads/) instalado
* Você deve instalar as seguintes Workloads pelo Instalador do VS. Nota: Abrir
  a solução no VS 2022 irá [solicitar a instalação automática dos componentes faltantes](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/):
  * Desenvolvimento para Desktop com C++
  * Desenvolvimento para Plataforma Universal do Windows
  * **Os seguintes Componentes Individuais**
    * Ferramentas C++ (v143) para Plataforma Universal do Windows
* Você deve instalar o [Pacote de Destino do .NET Framework](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) para compilar projetos de teste

## Compilando o Código

OpenConsole.sln pode ser compilado a partir do Visual Studio ou da linha de comando
usando um conjunto de scripts e ferramentas de conveniência no diretório **/tools**:

### Compilando no PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Compilando no Cmd

```shell
.\tools\razzle.cmd
bcz
```

## Executando & Depurando

Para depurar o Windows Terminal no VS, clique com o botão direito em `CascadiaPackage` (no
Solution Explorer) e vá em propriedades. No menu Debug, altere "Application
process" e "Background task process" para "Native Only".

Você então poderá compilar e depurar o projeto Terminal pressionando
<kbd>F5</kbd>. Certifique-se de selecionar a plataforma "x64" ou "x86" - o
Terminal não compila para "Any Cpu" (porque o Terminal é um aplicativo C++, não
C#).

> 👉 Você _não_ conseguirá iniciar o Terminal diretamente executando o
> WindowsTerminal.exe. Para mais detalhes sobre o motivo, veja
> [#926](https://github.com/microsoft/terminal/issues/926),
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### Orientação de Codificação

Por favor, revise estes breves documentos abaixo sobre nossas práticas de codificação.

> 👉 Se você encontrar algo faltando nesses documentos, sinta-se à vontade para contribuir com
> qualquer um dos nossos arquivos de documentação em qualquer lugar do repositório (ou escreva novos!)

Este é um trabalho em andamento enquanto aprendemos o que precisamos fornecer às pessoas para serem contribuidores eficazes em nosso projeto.

* [Estilo de Codificação](./doc/STYLE.md)
* [Organização do Código](./doc/ORGANIZATION.md)
* [Exceções em nossa base de código legada](./doc/EXCEPTIONS.md)
* [Smart pointers e macros úteis para interface com o Windows no WIL](./doc/WIL.md)

---

## Código de Conduta

Este projeto adotou o [Microsoft Open Source Code of Conduct][conduct-code]. Para mais informações, consulte o [FAQ do Código de Conduta][conduct-FAQ] ou entre em contato com [opencode@microsoft.com][conduct-email] para quaisquer dúvidas ou comentários adicionais.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
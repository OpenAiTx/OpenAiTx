<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh é um framework de código aberto, mantido pela comunidade, para gerenciar sua configuração do [zsh](https://www.zsh.org/).

Parece entediante. Vamos tentar novamente.

**Oh My Zsh não vai te transformar em um desenvolvedor 10x... mas você pode se sentir como um.**

Uma vez instalado, seu terminal shell será o assunto da cidade _ou seu dinheiro de volta!_ A cada tecla pressionada no seu prompt de comando, você aproveitará centenas de plugins poderosos e temas belíssimos. Estranhos virão até você em cafés e perguntarão, _"isso é incrível! você é algum tipo de gênio?"_

Finalmente, você começará a receber o tipo de atenção que sempre sentiu que merecia. ...ou talvez use o tempo que está economizando para passar fio dental com mais frequência. 😬

Para saber mais, visite [ohmyz.sh](https://ohmyz.sh), siga [@ohmyzsh](https://x.com/ohmyzsh) no X (antigo Twitter), e junte-se a nós no [Discord](https://discord.gg/ohmyzsh).

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>Tabela de Conteúdos</summary>

- [Primeiros Passos](#getting-started)
  - [Compatibilidade com Sistemas Operacionais](#operating-system-compatibility)
  - [Pré-requisitos](#prerequisites)
  - [Instalação Básica](#basic-installation)
    - [Inspeção Manual](#manual-inspection)
- [Usando o Oh My Zsh](#using-oh-my-zsh)
  - [Plugins](#plugins)
    - [Habilitando Plugins](#enabling-plugins)
    - [Usando Plugins](#using-plugins)
  - [Temas](#themes)
    - [Selecionando um Tema](#selecting-a-theme)
  - [FAQ](#faq)
- [Tópicos Avançados](#advanced-topics)
  - [Instalação Avançada](#advanced-installation)
    - [Diretório Personalizado](#custom-directory)
    - [Instalação Não Interativa](#unattended-install)
    - [Instalando de um Repositório Forkado](#installing-from-a-forked-repository)
    - [Instalação Manual](#manual-installation)
  - [Problemas de Instalação](#installation-problems)
  - [Plugins e Temas Personalizados](#custom-plugins-and-themes)
  - [Habilitar GNU ls em sistemas macOS e freeBSD](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [Pular Aliases](#skip-aliases)
  - [Prompt git assíncrono](#async-git-prompt)
- [Recebendo Atualizações](#getting-updates)
  - [Verbosidade das Atualizações](#updates-verbosity)
  - [Atualizações Manuais](#manual-updates)
- [Desinstalando o Oh My Zsh](#uninstalling-oh-my-zsh)
- [Como Contribuir com o Oh My Zsh?](#how-do-i-contribute-to-oh-my-zsh)
  - [Não Nos Envie Temas](#do-not-send-us-themes)
- [Contribuidores](#contributors)
- [Siga-nos](#follow-us)
- [Produtos](#merchandise)
- [Licença](#license)
- [Sobre a Planet Argon](#about-planet-argon)

</details>

## Primeiros Passos

### Compatibilidade com Sistemas Operacionais

| SO             | Status |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### Pré-requisitos

- [Zsh](https://www.zsh.org) deve estar instalado (v4.3.9 ou mais recente está ok, mas preferimos 5.0.8 ou mais nova). Caso não esteja pré-instalado (rode `zsh --version` para confirmar), veja as instruções no wiki: [Installing ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- `curl` ou `wget` devem estar instalados
- `git` deve estar instalado (recomendado v2.4.11 ou superior)

### Instalação Básica

Oh My Zsh é instalado rodando um dos comandos abaixo em seu terminal. Você pode instalar via linha de comando usando `curl`, `wget` ou outra ferramenta similar.

| Método    | Comando                                                                                           |
| :-------- | :------------------------------------------------------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

Alternativamente, o instalador também está espelhado fora do GitHub. Pode ser necessário usar essa URL se você estiver em um país como China ou Índia (para alguns ISPs), que bloqueiam `raw.githubusercontent.com`:

| Método    | Comando                                           |
| :-------- | :------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_Observe que qualquer `.zshrc` anterior será renomeado para `.zshrc.pre-oh-my-zsh`. Após a instalação, você pode mover as configurações que deseja preservar para o novo `.zshrc`._

#### Inspeção Manual

É uma boa ideia inspecionar o script de instalação de projetos que você ainda não conhece. Você pode fazer isso baixando o script antes, revisando-o para garantir que está tudo certo, e então rodando:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

Se a URL acima expirar ou falhar, talvez seja necessário substituir pela URL `https://install.ohmyz.sh` para obter o script.

## Usando o Oh My Zsh

### Plugins

Oh My Zsh vem com uma tonelada de plugins para você aproveitar. Você pode conferir o diretório de [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) e/ou o [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) para ver o que está disponível.

#### Habilitando Plugins

Assim que você encontrar um plugin (ou vários) que gostaria de usar com o Oh My Zsh, será necessário habilitá-los no arquivo `.zshrc`. Você encontrará o zshrc no seu diretório `$HOME`. Abra-o com seu editor de texto favorito e verá um local para listar todos os plugins que deseja carregar.

```sh
vi ~/.zshrc
```

Por exemplo, pode ficar assim:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_Observe que os plugins são separados por espaços em branco (espaços, tabulações, quebras de linha...). **Não** use vírgulas entre eles, pois isso pode causar erros._

#### Usando Plugins

Cada plugin embutido inclui um **README**, documentando-o. Este README deve mostrar os aliases (se o plugin adicionar algum) e outros recursos incluídos naquele plugin específico.

### Temas

Vamos admitir. No início do Oh My Zsh, talvez tenhamos ficado um pouco entusiasmados demais com temas. Agora temos mais de cento e cinquenta temas incluídos. A maioria possui [screenshots](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) no wiki (Estamos trabalhando para atualizar isso!). Confira!

#### Selecionando um Tema

_O tema do Robby é o padrão. Não é o mais chique. Não é o mais simples. É apenas o ideal (para ele)._

Quando encontrar um tema que queira usar, será necessário editar o arquivo `~/.zshrc`. Você verá uma variável de ambiente (toda em maiúsculas) parecida com:

```sh
ZSH_THEME="robbyrussell"
```

Para usar outro tema, basta alterar o valor para o nome do tema desejado. Por exemplo:

```sh
ZSH_THEME="agnoster" # (este é um dos mais sofisticados)
# veja https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!NOTA]
> Muitas vezes você verá screenshots de um tema zsh, vai testar, e verá que não ficou igual para você.
>
> Isso ocorre porque muitos temas exigem a instalação de uma [Fonte Powerline](https://github.com/powerline/fonts) ou uma [Nerd Font](https://github.com/ryanoasis/nerd-fonts) para serem exibidos corretamente. Sem elas, esses temas mostrarão símbolos estranhos no prompt. Confira a [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt) para mais informações.
>
> Também, lembre-se que temas controlam apenas a aparência do seu prompt. Ou seja, o texto que você vê antes ou depois do cursor, onde você digita seus comandos. Temas não controlam coisas como as cores da janela do terminal (_esquema de cores_) ou a fonte do terminal. Essas são configurações do seu emulador de terminal. Para mais informações, veja [o que é um tema zsh](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme).
<!-- prettier-ignore-end -->

Abra uma nova janela do terminal e seu prompt deve ficar mais ou menos assim:

![Tema Agnoster](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

Caso não encontre um tema adequado para suas necessidades, confira o wiki para [mais opções](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

Se estiver se sentindo aventureiro, pode deixar o computador escolher um aleatoriamente cada vez que abrir uma nova janela do terminal.

```sh
ZSH_THEME="random" # (...por favor, que seja pie... por favor, que seja algum pie..)
```

E se quiser escolher aleatoriamente entre seus temas favoritos:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

Se você só sabe quais temas não gosta, pode adicioná-los a uma lista de ignorados da mesma forma:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### FAQ

Se tiver mais dúvidas ou problemas, talvez encontre uma solução em nossa [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ).

## Tópicos Avançados

Se você é do tipo que gosta de colocar a mão na massa, estas seções podem ser do seu interesse.

### Instalação Avançada

Alguns usuários podem querer instalar o Oh My Zsh manualmente, ou mudar o caminho padrão ou outras configurações aceitas pelo instalador (essas configurações também estão documentadas no início do script de instalação).

#### Diretório Personalizado

A localização padrão é `~/.oh-my-zsh` (oculto no seu diretório home, você pode acessar com `cd ~/.oh-my-zsh`)

Se quiser mudar o diretório de instalação usando a variável de ambiente `ZSH`, execute `export ZSH=/seu/caminho` antes de instalar, ou defina-a antes do final do pipeline de instalação, assim:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### Instalação Não Interativa

Se você estiver rodando o script de instalação do Oh My Zsh como parte de uma instalação automatizada, pode passar o parâmetro `--unattended` para o script `install.sh`. Isso fará com que ele não tente mudar o shell padrão, e também não rodará o `zsh` ao finalizar a instalação.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

Se estiver na China, Índia ou outro país que bloqueia `raw.githubusercontent.com`, pode ser necessário substituir pela URL `https://install.ohmyz.sh` para instalar.

#### Instalando de um Repositório Forkado

O script de instalação também aceita estas variáveis para permitir a instalação de outro repositório:

- `REPO` (padrão: `ohmyzsh/ohmyzsh`): use no formato `dono/repositorio`. Se você definir esta variável, o instalador buscará um repositório em `https://github.com/{dono}/{repositorio}`.

- `REMOTE` (padrão: `https://github.com/${REPO}.git`): esta é a URL completa do clone do repositório git. Use se quiser instalar de um fork que não esteja no GitHub (GitLab, Bitbucket...) ou se quiser clonar via SSH em vez de HTTPS (`git@github.com:user/project.git`).

  _NOTA: é incompatível com a definição da variável `REPO`. Esta configuração terá precedência._

- `BRANCH` (padrão: `master`): use esta configuração se quiser mudar o branch padrão a ser utilizado no clone do repositório. Pode ser útil para testar um Pull Request, ou se quiser usar outro branch que não o `master`.

Por exemplo:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### Instalação Manual

##### 1. Clone o Repositório <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _Opcionalmente_, faça backup do seu arquivo `~/.zshrc` atual <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. Crie um novo arquivo de configuração do Zsh <!-- omit in toc -->

Você pode criar um novo arquivo de configuração do zsh copiando o template que incluímos para você.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. Altere seu shell padrão <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

Você deve sair da sessão do usuário e entrar novamente para ver a mudança.

##### 5. Inicialize sua nova configuração do Zsh <!-- omit in toc -->

Ao abrir uma nova janela do terminal, o zsh deve ser carregado com a configuração do Oh My Zsh.

### Problemas de Instalação

Se tiver problemas na instalação, aqui estão algumas correções comuns.

- Você _talvez_ precise modificar seu `PATH` em `~/.zshrc` se não conseguir encontrar alguns comandos após mudar para o `oh-my-zsh`.
- Se instalou manualmente ou mudou o local da instalação, verifique a variável de ambiente `ZSH` em `~/.zshrc`.

### Plugins e Temas Personalizados

Se quiser sobrescrever qualquer comportamento padrão, basta adicionar um novo arquivo (terminando com `.zsh`) no diretório `custom/`.

Se você tem várias funções que combinam entre si, pode agrupá-las em um arquivo `XYZ.plugin.zsh` no diretório `custom/plugins/` e então habilitar este plugin.

Se quiser sobrescrever a funcionalidade de um plugin distribuído com o Oh My Zsh, crie um plugin com o mesmo nome em `custom/plugins/` e ele será carregado em vez do original em `plugins/`.

### Habilitar GNU ls em sistemas macOS e freeBSD

<a name="enable-gnu-ls"></a>

O comportamento padrão do Oh My Zsh é usar o `ls` BSD em sistemas macOS e FreeBSD. Se o GNU `ls` estiver instalado (como comando `gls`), você pode optar por usá-lo. Para isso, use esta configuração baseada em zstyle antes de carregar o `oh-my-zsh.sh`:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_Nota: isso não é compatível com `DISABLE_LS_COLORS=true`_

### Pular Aliases

<a name="remove-directories-aliases"></a>

Se quiser pular os aliases padrão do Oh My Zsh (definidos nos arquivos `lib/*`) ou de plugins, use as configurações abaixo no seu arquivo `~/.zshrc`, **antes do Oh My Zsh ser carregado**. Existem diferentes formas de pular aliases, dependendo da sua necessidade.

```sh
# Pular todos os aliases, em arquivos lib e plugins habilitados
zstyle ':omz:*' aliases no

# Pular todos os aliases em arquivos lib
zstyle ':omz:lib:*' aliases no
# Pular apenas aliases definidos no arquivo directories.zsh da lib
zstyle ':omz:lib:directories' aliases no

# Pular todos os aliases de plugins
zstyle ':omz:plugins:*' aliases no
# Pular apenas os aliases do plugin git
zstyle ':omz:plugins:git' aliases no
```

Você pode combinar estas opções, levando em conta que escopos mais específicos têm precedência:

```sh
# Pular todos os aliases de plugins, exceto do plugin git
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

Uma versão anterior deste recurso usava a configuração abaixo, que foi removida:

```sh
zstyle ':omz:directories' aliases no
```

Agora, use o seguinte:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### Aviso <!-- omit in toc -->

> Este recurso está atualmente em fase de testes e pode ser alterado no futuro. Também não é compatível com gerenciadores de plugins como zpm ou zinit, que não carregam o script de inicialização (`oh-my-zsh.sh`) onde este recurso está implementado.

> Também não detecta "aliases" definidos como funções. Exemplos disso são as funções `gccd`, `ggf` ou `ggl` do plugin git.

### Prompt git assíncrono

Funções de prompt assíncronas são um recurso experimental (incluído em 03 de abril de 2024) que permite ao Oh My Zsh renderizar informações do prompt de forma assíncrona. Isso pode melhorar a performance do prompt, mas pode não funcionar bem em alguns ambientes. Esperamos que não seja um problema, mas se você encontrar problemas com esse novo recurso, pode desativá-lo adicionando o seguinte no seu arquivo .zshrc, antes de carregar o Oh My Zsh:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

Se seu problema for que o prompt do git simplesmente deixou de aparecer, tente forçar com a configuração abaixo antes de carregar o `oh-my-zsh.sh`. Se ainda assim não funcionar, por favor abra uma issue relatando seu caso.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## Recebendo Atualizações

Por padrão, você será solicitado a verificar atualizações a cada 2 semanas. Você pode escolher outros modos de atualização adicionando uma linha ao seu arquivo `~/.zshrc`, **antes do Oh My Zsh ser carregado**:

1. Atualização automática sem pedir confirmação:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. Apenas lembrar a cada alguns dias, se houver atualizações disponíveis:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. Para desabilitar atualizações automáticas completamente:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

NOTA: você pode controlar com que frequência o Oh My Zsh verifica atualizações com a seguinte configuração:

```sh
# Verifica atualizações a cada 7 dias
zstyle ':omz:update' frequency 7
# Verifica atualizações toda vez que abrir o terminal (não recomendado)
zstyle ':omz:update' frequency 0
```

### Verbosidade das Atualizações

Você também pode limitar a verbosidade das atualizações com as configurações abaixo:

```sh
zstyle ':omz:update' verbose default # prompt padrão de atualização

zstyle ':omz:update' verbose minimal # apenas algumas linhas

zstyle ':omz:update' verbose silent # apenas erros
```

### Atualizações Manuais

Se quiser atualizar a qualquer momento (talvez alguém tenha lançado um novo plugin e você não quer esperar uma semana?) basta rodar:

```sh
omz update
```

> [!NOTA]
> Se quiser automatizar esse processo em um script, chame diretamente o script `upgrade`, assim:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> Veja mais opções na [FAQ: Como atualizo o Oh My Zsh?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh).
>
> **O USO DE `omz update --unattended` FOI REMOVIDO, POIS CAUSAVA EFEITOS COLATERAIS**.

Mágico! 🎉

## Desinstalando o Oh My Zsh

Oh My Zsh não é para todos. Sentiremos sua falta, mas queremos tornar essa despedida fácil.

Se quiser desinstalar o `oh-my-zsh`, basta rodar `uninstall_oh_my_zsh` na linha de comando. Ele irá se remover e restaurar sua configuração anterior de `bash` ou `zsh`.

## Como Contribuir com o Oh My Zsh?

Antes de participar de nossa adorável comunidade, por favor leia o [código de conduta](CODE_OF_CONDUCT.md).

Estou longe de ser um especialista em [Zsh](https://www.zsh.org/) e suspeito que há muitas formas de melhorar – se você tem ideias para facilitar a manutenção (e torná-la mais rápida), não hesite em fazer um fork e enviar pull requests!

Também precisamos de pessoas para testar pull requests. Então dê uma olhada nas [issues abertas](https://github.com/ohmyzsh/ohmyzsh/issues) e ajude como puder.

Veja mais detalhes em [Contributing](CONTRIBUTING.md).

### Não Nos Envie Temas

Temos (mais que) temas suficientes por enquanto. Por favor, adicione seu tema à página de [temas externos](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) no wiki.

## Contribuidores

Oh My Zsh possui uma comunidade vibrante de usuários felizes e colaboradores incríveis. Sem todo o tempo e ajuda deles, não seria tão incrível.

Muito obrigado!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## Siga-nos

Estamos nas redes sociais:

- [@ohmyzsh](https://x.com/ohmyzsh) no X (antigo Twitter). Siga-nos!
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) dê um alô.
- [Instagram](https://www.instagram.com/_ohmyzsh/) marque a gente no seu post mostrando o Oh My Zsh!
- [Discord](https://discord.gg/ohmyzsh) para conversar conosco!

## Produtos

Temos [adesivos, camisetas e canecas disponíveis](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github) para você mostrar seu amor pelo Oh My Zsh. Mais uma vez, você será o assunto da cidade!

## Licença

Oh My Zsh é distribuído sob a [licença MIT](LICENSE.txt).

## Sobre a Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh foi iniciado pela equipe da [Planet Argon](https://www.planetargon.com/?utm_source=github), uma [agência de desenvolvimento Ruby on Rails](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github). Confira nossos [outros projetos open source](https://www.planetargon.com/open-source?utm_source=github).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">Seu Site de Jogos Amigável do Bairro.</p>
<br>

Bem-vindo ao MonkeyGG2, um site de jogos repleto de recursos criado para você! Com mais de 150 jogos para escolher, o MonkeyGG2 oferece uma experiência de jogo única e personalizável. Seja você um gamer, um desenvolvedor ou apenas alguém comum, o MonkeyGG2 proporciona um ambiente de jogos contínuo e agradável.

> Considere nos dar uma estrela! Especialmente se você fez um fork deste repositório ou encontrou algum outro uso para ele.

## Funcionalidades

-   Mais de 150 jogos
-   Fácil de usar
-   Fácil de implantar
-   Personalizável
-   Proxy
-   E muito mais...

## Personalização

### Configurações

#### Camuflagem

Camuflagem refere-se a abrir a página em uma aba `about:blank`. Esse comportamento é forçado por padrão, embora possa ser desabilitado. Predefinições estão disponíveis para o link de redirecionamento, mas também podem ser configuradas manualmente.

#### Mascaramento

Mascaramento refere-se a alterar o ícone e o título da aba about:blank. Predefinições estão disponíveis para o ícone e o título da aba, mas também podem ser configuradas manualmente.

#### Atalhos

Atalhos personalizados de teclado podem ser criados para realizar uma variedade de tarefas. Por exemplo, sair do jogo, mascarar a aba e executar JavaScript personalizado, todos são suportados.
> Nota: se você quiser executar JavaScript personalizado, certifique-se de saber o que está fazendo. Se algo der errado, recarregar a página sempre resolve.

#### Tema

As seguintes personalizações de tema são suportadas atualmente:
- Alternar Animação de Fundo (se você estiver preocupado com desempenho durante o jogo, não se preocupe, é desabilitado automaticamente sempre que você estiver jogando)
- Cor de Fundo
- Cor dos Blocos
- Cor dos Botões
- Cor dos Jogos
- Cor de Hover
- Cor da Barra de Rolagem
- Cor da Trilha de Rolagem
- Cor da Fonte

> Nota: se você acidentalmente mudar as cores de forma que o site fique inutilizável, você terá que limpar seus cookies e o armazenamento local.

### Personalização Avançada

> Aviso: As seguintes personalizações estão disponíveis apenas para proprietários do repositório ou de qualquer fork deste repositório.

O arquivo `config.jsonc` é formatado para incluir a configuração de todo o site. Atualmente, os seguintes itens são suportados:
- Jogos
- Temas (em breve)
- Configuração de Proxy

#### Jogos

Cada entrada de jogo tem uma chave representando o nome de exibição do jogo, e o valor deve ser um objeto com três pares chave-valor:
- `"path"`: Caminho para o jogo a partir do diretório `./games`
- `"aliases"`: Lista de nomes alternativos para o jogo usados para melhorar a busca
- `"categories"`: Lista de categorias às quais o jogo pertence (suporte para adicionar ícones em breve)

Adicionar uma entrada manualmente é possível, mas tedioso, especialmente se você quiser ordenar a lista alfanumericamente (não é obrigatório para a configuração funcionar!).
Por isso o script `add-game-entry.js` foi criado, uma maneira fácil de adicionar um novo jogo na configuração sem precisar editar o arquivo manualmente.

```bash
# Você pode usar qualquer runtime js como node.js, bun ou deno
# Para esta demonstração, será usado o bun, pois as dependências são instaladas automaticamente
bun add-game-script.js
# Responda os prompts que seguirem e a configuração será atualizada
```

#### Temas

Padrão de tema ainda não implementado (TODO)

#### Proxy

As opções de configuração de proxy estão sob a chave **"config"**. 
O valor para a chave `"proxy"` é um valor booleano que ativa ou desativa a função proxy. Se `"proxy"` estiver como falso, o usuário verá um diálogo de erro ao tentar acessar o proxy.
O valor para a chave `"proxyPath"` é o caminho para o proxy. Pode ser um caminho absoluto ou relativo, mas o proxy deve suportar **CORS**, pois a página do proxy será exibida como um iframe no site.

## Implantação

### Sem Proxy

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

Alternativamente, você pode simplesmente fazer um fork deste repositório no [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) ou [Codeberg](https://codeberg.org/MonkeyGG2/pages) e implantar no GitHub Pages ou Codeberg Pages, respectivamente.

### Com Proxy

Visite a página do [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) para saber mais sobre como hospedar o MonkeyGG2 com um proxy.

### Executando Localmente

```bash
# AVISO: se você tiver uma pasta chamada "monkeygg2", este comando removerá todos os arquivos dentro dessa pasta
# por favor, altere o nome do diretório nos dois comandos a seguir
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# a partir daqui, você pode usar qualquer ferramenta para rodar um servidor estático, será usado o "live-server" do npm neste exemplo
npm install -g live-server # apenas se você ainda não tiver instalado
npx live-server
```

## Licença

Distribuído sob a Licença WTFPL. Veja [aqui](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE) para mais detalhes.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---

# mcp-chat

<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

Cliente MCP Genérico de Código Aberto para testar e avaliar servidores e agentes MCP

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## Guia Rápido

Certifique-se de que você exportou `ANTHROPIC_API_KEY` em seu ambiente ou em um arquivo .env na raiz do projeto. Você pode obter uma chave de API registrando-se na [página de chaves do Console Anthropic](https://console.anthropic.com/settings/keys).

Caso de uso simples que inicia um prompt de chat interativo com o servidor MCP do sistema de arquivos via CLI:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

Isso abrirá um prompt de chat que você pode usar para interagir com os servidores e conversar com um LLM.

## Configuração

Você também pode simplesmente especificar seu claude_desktop_config.json (Mac):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

Ou (Windows):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

No modo web, você pode iniciar novos chats, enviar mensagens para o modelo e configurar dinamicamente os servidores mcp via interface gráfica - sem necessidade de especificar na linha de comando. Além disso, os chats criados pela Web UI são salvos em ~/.mcpchats/chats assim como os chats criados via CLI.

## Funcionalidades

- [x] Execute via CLI em modo interativo ou envie prompts diretamente com `-p`
- [x] Modo web para conversar com modelos via interface web `--web`
- [x] Conecte-se a qualquer servidor MCP (JS, Python, Docker) em produção ou durante o desenvolvimento
- [x] Escolha entre modelos com `-m`
- [x] Personalize o prompt do sistema com `--system`
- [x] Salva o histórico de chats com configurações em `~/.mcpchat/chats`, incluindo chats web
- [x] Salve e restaure comandos em `~/.mcpchat/history`
- [x] Veja a saída e os argumentos das ferramentas diretamente no chat para ajudar a depurar servidores mcp

## Uso via CLI

Execute prompts via CLI com a flag `-p`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Isso executa o prompt com o mcp-server do kubernetes e encerra após a resposta ser recebida no stdout.

Escolha um modelo para conversar via CLI usando a opção `-m`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

Utiliza o modelo `claude-3.5` para conversar. Observe que atualmente apenas modelos da Anthropic são suportados.

Prompt de sistema personalizado:

O parâmetro `--system` pode ser usado para especificar um prompt de sistema:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## Variáveis de ambiente (ENV vars)

O Mcp-chat suporta o repasse de variáveis de ambiente para servidores MCP. No entanto, isso não é padronizado na especificação MCP e outros clientes podem não utilizar valores dinâmicos de variáveis de ambiente — leia mais [aqui](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) sobre clientes MCP padrão stdio.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## Para desenvolvedores de mcp-servers

Você pode fornecer uma versão local de um servidor mcp em Python ou Node para testá-lo com o mcp-chat:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

Python:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## Desenvolvimento

Instale as dependências e execute o CLI:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
Para desenvolver mcp-chat enquanto se conecta a um mcp-server, faça uma build e execute o CLI com a flag de servidor:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Teste:

```shell
bun run test
```

Construção:

```shell
bun run build
```

Publicação:

```shell
bun run publish
```

Publicando Docker:

```shell
bun run dockerbuild
```

### Estrutura do Projeto

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## Publicando nova versão

Vá para a página de [releases](https://github.com/Flux159/mcp-chat/releases), clique em "Draft New Release", clique em "Choose a tag" e crie uma nova tag digitando um novo número de versão usando o formato semver "v{major}.{minor}.{patch}". Em seguida, escreva um título para o release "Release v{major}.{minor}.{patch}" e uma descrição / changelog se necessário e clique em "Publish Release".

Isso criará uma nova tag que irá acionar uma nova build de release via o workflow cd.yml. Após ser bem-sucedido, o novo release será publicado no npm. Note que não é necessário atualizar manualmente a versão do package.json, pois o workflow irá atualizar automaticamente o número da versão no arquivo package.json e enviar um commit para main.

## Licença

[Licença MIT](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---

# mcp-chat

<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

Client MCP generico Open Source per il testing e la valutazione di server e agenti MCP

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## Avvio rapido

Assicurati di aver esportato `ANTHROPIC_API_KEY` nel tuo ambiente o in un file .env nella radice del progetto. Puoi ottenere una chiave API registrandoti alla [pagina chiavi della Anthropic Console](https://console.anthropic.com/settings/keys).

Caso d'uso semplice che avvia un prompt di chat interattivo con il server MCP del filesystem dalla CLI:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

Questo aprirà una finestra di chat che puoi utilizzare per interagire con i server e chattare con un LLM.

## Configurazione

Puoi anche semplicemente specificare il tuo claude_desktop_config.json (Mac):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

Oppure (Windows):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

In modalità web, puoi avviare nuove chat, inviare messaggi al modello e configurare dinamicamente i server mcp tramite l'interfaccia utente - non è necessario specificare nulla da linea di comando. Inoltre, le chat create tramite Web UI vengono salvate in ~/.mcpchats/chats proprio come quelle create tramite CLI.

## Funzionalità

- [x] Esecuzione tramite CLI in modalità interattiva o passaggio diretto di prompt con `-p`
- [x] Modalità web per chattare con i modelli tramite interfaccia web `--web`
- [x] Connessione a qualsiasi server MCP (JS, Python, Docker) in produzione o durante lo sviluppo
- [x] Scelta tra i modelli con `-m`
- [x] Personalizzazione del prompt di sistema con `--system`
- [x] Salva la cronologia delle chat con impostazioni in `~/.mcpchat/chats`, incluse le chat web
- [x] Salva e ripristina i comandi in `~/.mcpchat/history`
- [x] Visualizza output e argomenti delle chiamate agli strumenti direttamente in chat per aiutare a fare debug dei server mcp

## Utilizzo CLI

Esegui prompt tramite CLI con il flag `-p`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Questo esegue il prompt con il mcp-server di kubernetes ed esce dopo che la risposta è stata ricevuta su stdout.

Scegli un modello con cui chattare tramite CLI utilizzando il flag `-m`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

Utilizza il modello `claude-3.5` per la conversazione. Nota che attualmente sono supportati solo i modelli Anthropic.

Prompt di sistema personalizzato:

Il flag `--system` può essere utilizzato per specificare un prompt di sistema:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## Variabili ENV

Mcp-chat supporta il passaggio di variabili d'ambiente ai server mcp. Tuttavia, questo non è standardizzato nelle specifiche mcp e altri client potrebbero non farlo con valori dinamici delle variabili d'ambiente - leggi di più [qui](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) sui client mcp stdio standard.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## Per gli sviluppatori di mcp-server

È possibile utilizzare una build locale di un mcp-server Python o Node per testarlo con mcp-chat:

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

## Sviluppo

Installa le dipendenze ed esegui la CLI:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```

Per sviluppare mcp-chat mentre si è connessi a un mcp-server, crea una build ed esegui la CLI con il flag server:

```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Test:

```shell
bun run test
```

Edificio:

```shell
bun run build
```

Pubblicazione:

```shell
bun run publish
```

Pubblicazione di Docker:

```shell
bun run dockerbuild
```

### Struttura del Progetto

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## Pubblicazione di una nuova release

Vai alla pagina delle [release](https://github.com/Flux159/mcp-chat/releases), clicca su "Draft New Release", clicca su "Choose a tag" e crea un nuovo tag digitando un nuovo numero di versione utilizzando il formato semver "v{major}.{minor}.{patch}". Quindi, scrivi un titolo per la release "Release v{major}.{minor}.{patch}" e aggiungi una descrizione / changelog se necessario, poi clicca su "Publish Release".

Questo creerà un nuovo tag che attiverà una nuova build della release tramite il workflow cd.yml. Una volta completata con successo, la nuova release verrà pubblicata su npm. Nota che non è necessario aggiornare manualmente la versione in package.json, poiché il workflow aggiornerà automaticamente il numero di versione nel file package.json e invierà una commit su main.

## Licenza

[Licenza MIT](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---
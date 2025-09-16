
# mcp-chat

<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

Open Source Generieke MCP Client voor het testen & evalueren van mcp-servers en agents

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## Snelle start

Zorg ervoor dat je `ANTHROPIC_API_KEY` hebt geëxporteerd in je omgeving of in een .env-bestand in de hoofdmap van het project. Je kunt een API-sleutel krijgen door je aan te melden op de [Anthropic Console sleutelpagina](https://console.anthropic.com/settings/keys).

Eenvoudig gebruiksvoorbeeld dat een interactieve chatprompt start met de bestandssysteem MCP-server via de CLI:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

Dit opent een chatprompt die je kunt gebruiken om te communiceren met de servers en te chatten met een LLM.

## Configuratie

Je kunt ook gewoon je claude_desktop_config.json specificeren (Mac):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

Of (Windows):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

In webmodus kun je nieuwe chats starten, berichten naar het model sturen en de mcp-servers dynamisch configureren via de UI – je hoeft dit niet op de opdrachtregel te specificeren. Bovendien worden chats die via de Web UI zijn aangemaakt opgeslagen in ~/.mcpchats/chats, net als chats die via de CLI zijn aangemaakt.

## Functies

- [x] Uitvoeren via CLI in interactieve modus of direct prompts doorgeven met `-p`
- [x] Webmodus om te chatten met modellen via een webinterface `--web`
- [x] Verbinden met elke MCP-server (JS, Python, Docker) in productie of tijdens ontwikkeling
- [x] Kies tussen modellen met `-m`
- [x] Systeemprompt aanpassen met `--system`
- [x] Slaat chatgeschiedenis met instellingen op in `~/.mcpchat/chats`, inclusief webchats
- [x] Opslaan en herstellen van commando's in `~/.mcpchat/history`
- [x] Bekijk uitvoer van toolaanroepen en argumenten direct in de chat om mcp-servers te debuggen

## CLI-gebruik

Voer prompts uit via CLI met de `-p` vlag:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Dit voert de prompt uit met de kubernetes mcp-server en sluit af nadat de reactie op stdout is ontvangen.

Kies een model om mee te chatten via de CLI met de `-m` vlag:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

Gebruikt het model `claude-3.5` om mee te chatten. Let op: momenteel worden alleen Anthropic-modellen ondersteund.

Aangepaste systeemprompt:

Met de vlag `--system` kan een systeemprompt worden opgegeven:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## Omgevingsvariabelen

Mcp-chat ondersteunt het doorgeven van omgevingsvariabelen aan mcp-servers. Dit is echter niet gestandaardiseerd in de mcp-specificatie en andere clients doen dit mogelijk niet met dynamische waarden van omgevingsvariabelen - lees meer [hier](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) over standaard stdio mcp-clients.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## Voor ontwikkelaars van mcp-servers

Je kunt een lokale build van een Python- of Node mcp-server doorgeven om deze te testen met mcp-chat:

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

## Ontwikkeling

Installeer afhankelijkheden en voer de CLI uit:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
Om mcp-chat te ontwikkelen terwijl je verbinding maakt met een mcp-server, maak een build en voer de CLI uit met de servervlag:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Testen:

```shell
bun run test
```

Gebouw:

```shell
bun run build
```
Publiceren:


```shell
bun run publish
```

Docker publiceren:

```shell
bun run dockerbuild
```

### Projectstructuur

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## Nieuwe release publiceren

Ga naar de [releases](https://github.com/Flux159/mcp-chat/releases) pagina, klik op "Draft New Release", klik op "Choose a tag" en maak een nieuwe tag aan door een nieuw versienummer te typen in het "v{major}.{minor}.{patch}" semver formaat. Schrijf vervolgens een titel voor de release "Release v{major}.{minor}.{patch}" en een beschrijving / changelog indien nodig en klik op "Publish Release".

Dit zal een nieuwe tag aanmaken die een nieuwe release-build zal triggeren via de cd.yml workflow. Zodra dit is gelukt, wordt de nieuwe release gepubliceerd naar npm. Let op dat je het versienummer in package.json niet handmatig hoeft bij te werken, aangezien de workflow automatisch het versienummer in het package.json-bestand zal bijwerken en een commit naar main zal pushen.

## Licentie

[MIT Licentie](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---
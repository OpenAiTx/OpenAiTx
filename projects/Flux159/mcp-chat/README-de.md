
# mcp-chat

<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

Open Source generischer MCP-Client zum Testen & Bewerten von MCP-Servern und Agenten

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## Schnellstart

Stellen Sie sicher, dass Sie `ANTHROPIC_API_KEY` in Ihrer Umgebung oder in einer .env-Datei im Stammverzeichnis des Projekts exportiert haben. Einen API-Schlüssel erhalten Sie, indem Sie sich auf der [Anthropic Console Schlüssel-Seite](https://console.anthropic.com/settings/keys) registrieren.

Ein einfacher Anwendungsfall, der über die CLI eine interaktive Chat-Eingabeaufforderung mit dem MCP-Dateisystemserver startet:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

Dadurch wird ein Chat-Prompt geöffnet, mit dem Sie mit den Servern interagieren und mit einem LLM chatten können.

## Konfiguration

Sie können auch einfach Ihre claude_desktop_config.json angeben (Mac):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

Oder (Windows):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

Im Web-Modus können Sie neue Chats starten, Nachrichten an das Modell senden und die MCP-Server dynamisch über die Benutzeroberfläche konfigurieren – eine Angabe über die Kommandozeile ist nicht erforderlich. Zusätzlich werden Chats, die über die Web-Oberfläche erstellt werden, genauso wie über die CLI erstellte Chats unter ~/.mcpchats/chats gespeichert.

## Funktionen

- [x] Ausführen über CLI im interaktiven Modus oder direkte Übergabe von Prompts mit `-p`
- [x] Web-Modus zum Chatten mit Modellen über eine Web-Oberfläche `--web`
- [x] Verbindung zu jedem MCP-Server (JS, Python, Docker) in Produktion oder während der Entwicklung
- [x] Auswahl zwischen Modellen mit `-m`
- [x] Anpassung des System-Prompts mit `--system`
- [x] Speichert Chatverläufe mit Einstellungen in `~/.mcpchat/chats`, einschließlich Web-Chats
- [x] Befehle speichern und wiederherstellen in `~/.mcpchat/history`
- [x] Anzeige der Tool-Call-Ausgaben und Argumente direkt im Chat zur Unterstützung beim Debuggen von MCP-Servern

## CLI Verwendung

Führen Sie Prompts über die CLI mit dem `-p`-Flag aus:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Dies führt den Prompt mit dem Kubernetes mcp-server aus und beendet sich, nachdem die Antwort auf stdout empfangen wurde.

Wählen Sie ein Modell für den Chat über die CLI mit dem Flag `-m` aus:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

Verwendet das Modell `claude-3.5` für den Chat. Beachten Sie, dass derzeit nur Anthropic-Modelle unterstützt werden.

Benutzerdefinierte System-Aufforderung:

Das Flag `--system` kann verwendet werden, um eine System-Aufforderung anzugeben:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## ENV-Variablen

Mcp-chat unterstützt das Durchreichen von ENV-Variablen an mcp-Server. Dies ist jedoch nicht im mcp-Standard spezifiziert und andere Clients verarbeiten möglicherweise keine dynamischen ENV-Variablenwerte – lesen Sie mehr [hier](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) über standardmäßige stdio-mcp-Clients.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## Für Entwickler von mcp-Servern

Sie können eine lokale Version eines Python- oder Node-mcp-Servers übergeben, um ihn mit mcp-chat zu testen:

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

## Entwicklung

Installieren Sie die Abhängigkeiten und führen Sie die CLI aus:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
Um mcp-chat zu entwickeln und gleichzeitig eine Verbindung zu einem mcp-server herzustellen, erstellen Sie ein Build und führen Sie das CLI mit dem Server-Flag aus:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Testen:

```shell
bun run test
```

Gebäude:

```shell
bun run build
```

Veröffentlichung:

```shell
bun run publish
```

Veröffentlichung von Docker:

```shell
bun run dockerbuild
```

### Projektstruktur

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## Veröffentlichung einer neuen Version

Gehen Sie zur [Releases](https://github.com/Flux159/mcp-chat/releases)-Seite, klicken Sie auf "Draft New Release", klicken Sie auf "Choose a tag" und erstellen Sie einen neuen Tag, indem Sie eine neue Versionsnummer im Format "v{major}.{minor}.{patch}" gemäß Semver eingeben. Schreiben Sie dann einen Veröffentlichungstitel "Release v{major}.{minor}.{patch}" und eine Beschreibung/Changelog falls nötig und klicken Sie auf "Publish Release".

Dadurch wird ein neuer Tag erstellt, der einen neuen Release-Build über den cd.yml-Workflow auslöst. Nach erfolgreichem Abschluss wird die neue Version auf npm veröffentlicht. Beachten Sie, dass ein manuelles Aktualisieren der package.json-Version nicht notwendig ist, da der Workflow die Versionsnummer in der package.json automatisch aktualisiert und einen Commit auf main pusht.

## Lizenz

[MIT-Lizenz](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---
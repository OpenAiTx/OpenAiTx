
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Claude Code neu geschrieben als Bash-Skript. ~1.500 Zeilen. Keine npm-Pakete.

## Warum

Der ursprüngliche Claude Code besteht aus ca. 380.000 Zeilen TypeScript mit 266 npm-Abhängigkeiten. Dies erledigt den gleichen Kernjob in Bash mit nur `curl` und `jq`.

## Funktionen

- **Echtzeit-Streaming** über FIFO-Pipe — Text erscheint, während Claude ihn generiert
- **6 Tools**: Bash, Read, Edit, Write, Glob, Grep
- **Tool-Chaining** — bis zu 25 Tool-Aufrufe pro Runde
- **Berechtigungsabfrage** — fragt vor dem Ausführen unsicherer Befehle (`y/n/a`)
- **CLAUDE.md Laden** — liest Projektanweisungen aus CLAUDE.md-Dateien im Verzeichnisbaum
- **Git-sensitiver Kontext** — Branch, Status und letzte Commits im System-Prompt
- **Sitzung speichern/fortsetzen** — speichert automatisch beim Beenden, fortsetzen mit `--resume <id>`
- **Wiederholen mit Backoff** — exponentielles Wiederholen bei 429/529 Rate-Limits
- **Kostenverfolgung** — Pro Runde und Sitzung Gesamtsummen
- **Spinner** — mit den ursprünglichen Spinner-Verben (Clauding, Flibbertigibbeting, usw.)
- **Slash-Befehle** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **Pipe-Modus** — `echo "erkläre dies" | ./claude.sh`

## Installation

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## Abhängigkeiten

- `curl`
- `jq`
- Optional: `rg` (ripgrep) für bessere Suche
- Optional: `python3` für das Editierwerkzeug

Laufzeitversionen sind in `.tool-versions` festgelegt. Installiere sie mit [mise](https://mise.jdx.dev/):

```bash
mise install
```

## Verwendung

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### Umgebungsvariablen

| Variable | Standardwert | Beschreibung |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (erforderlich) | Ihr Anthropic API-Schlüssel |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | Zu verwendendes Modell |
| `CLAUDE_MAX_TOKENS` | `8192` | Maximale Ausgabetoken |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | Basis-URL der API |
| `CLAUDE_SH_PERMISSIONS` | `ask` | Berechtigungsmodus: `ask`, `allow` oder `deny` |

### Befehle

```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### Eine Sitzung fortsetzen

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## Architektur

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## Wie es funktioniert

1. Benutzereingabe lesen
2. JSON-Anfrage mit `jq` erstellen (Nachrichten, Tools, System-Prompt)
3. Antwort per `curl` über eine FIFO-Pipe streamen
4. SSE-Ereignisse zeilenweise parsen, Text-Deltas in Echtzeit ausgeben
5. Wenn tool_use-Blöcke eintreffen, Tools ausführen
6. Tool-Ergebnisse als Nachrichten zurückgeben
7. Schleife, bis Claude aufhört, Tools aufzurufen

## Vergleich

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| Codezeilen | ~1.500 | ~380.000 |
| Abhängigkeiten | curl, jq | 266 npm-Pakete |
| Binärgröße | 0 (Skript) | ~200MB node_modules |
| Startzeit | Sofort | ~500ms |

### Testen

Tests verwenden [bats](https://github.com/bats-core/bats-core) (Bash Automated Testing System):

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---
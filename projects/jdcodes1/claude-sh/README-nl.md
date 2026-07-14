
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Claude Code herschreven als een bash-script. ~1.500 regels. Geen npm-pakketten.

## Waarom

De originele Claude Code is ~380.000 regels TypeScript met 266 npm-afhankelijkheden. Dit doet hetzelfde kernwerk in bash met alleen `curl` en `jq`.

## Functies

- **Realtime streaming** via FIFO-pijp — tekst verschijnt terwijl Claude deze genereert
- **6 tools**: Bash, Read, Edit, Write, Glob, Grep
- **Tool chaining** — tot 25 tool-aanroepen per beurt
- **Toestemmingsprompt** — vraagt toestemming voor het uitvoeren van niet-veilige commando’s (`y/n/a`)
- **CLAUDE.md laden** — leest projectinstructies uit CLAUDE.md-bestanden omhoog in de mapstructuur
- **Git-bewuste context** — branch, status en recente commits in systeemprompt
- **Sessie opslaan/hervatten** — slaat automatisch op bij afsluiten, hervatten met `--resume <id>`
- **Opnieuw proberen met backoff** — exponentieel opnieuw proberen bij 429/529 rate limits
- **Kosten bijhouden** — totaal per beurt en per sessie
- **Spinner** — met de originele spinner-werkwoorden (Clauding, Flibbertigibbeting, enz.)
- **Slashcommando’s** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **Pijpmodus** — `echo "explain this" | ./claude.sh`

## Installeren

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## Afhankelijkheden

- `curl`
- `jq`
- Optioneel: `rg` (ripgrep) voor betere zoekfunctionaliteit
- Optioneel: `python3` voor het bewerkingstool

Runtime-versies zijn vastgezet in `.tool-versions`. Installeer ze met [mise](https://mise.jdx.dev/):

```bash
mise install
```

## Gebruik

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### Omgevingsvariabelen

| Variabele | Standaard | Beschrijving |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (vereist) | Uw Anthropic API-sleutel |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | Te gebruiken model |
| `CLAUDE_MAX_TOKENS` | `8192` | Maximum aantal output tokens |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | API basis-URL |
| `CLAUDE_SH_PERMISSIONS` | `ask` | Permissiemodus: `ask`, `allow`, of `deny` |

### Commando's

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

### Een sessie hervatten

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## Architectuur

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## Hoe het werkt

1. Lees gebruikersinvoer
2. Bouw JSON-verzoek met `jq` (berichten, tools, systeem prompt)
3. Stream respons via `curl` door een FIFO-pijp
4. Parseer SSE-evenementen regel voor regel, toon tekstdelta’s in realtime
5. Wanneer tool_use-blokken arriveren, voer de tools uit
6. Geef toolresultaten terug als berichten
7. Herhaal tot Claude stopt met het aanroepen van tools

## Vergelijking

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| Regels code | ~1.500 | ~380.000 |
| Afhankelijkheden | curl, jq | 266 npm-pakketten |
| Binaire grootte | 0 (script) | ~200MB node_modules |
| Opstarttijd | Direct | ~500ms |

### Testen

Tests gebruiken [bats](https://github.com/bats-core/bats-core) (Bash Automated Testing System):

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---
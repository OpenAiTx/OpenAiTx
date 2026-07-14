
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Claude Code riscritto come uno script bash. Circa 1.500 righe. Zero pacchetti npm.

## Perché

Il Claude Code originale conta circa 380.000 righe di TypeScript con 266 dipendenze npm. Questo svolge lo stesso compito principale in bash usando solo `curl` e `jq`.

## Funzionalità

- **Streaming in tempo reale** tramite pipe FIFO — il testo appare mentre Claude lo genera
- **6 strumenti**: Bash, Leggi, Modifica, Scrivi, Glob, Grep
- **Catena di strumenti** — fino a 25 chiamate di strumenti per turno
- **Richiesta di permessi** — chiede prima di eseguire comandi non sicuri (`y/n/a`)
- **Caricamento CLAUDE.md** — legge le istruzioni del progetto dai file CLAUDE.md nella struttura delle directory
- **Contesto Git-aware** — ramo, stato e commit recenti nel prompt di sistema
- **Salvataggio/Ripresa sessione** — salvataggio automatico all’uscita, ripresa con `--resume <id>`
- **Riprova con backoff** — ripetizione esponenziale su limiti di rate 429/529
- **Tracciamento costi** — totale per turno e per sessione
- **Spinner** — con i verbi originali dello spinner (Clauding, Flibbertigibbeting, ecc.)
- **Comandi Slash** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **Modalità pipe** — `echo "spiega questo" | ./claude.sh`

## Installazione

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## Dipendenze

- `curl`
- `jq`
- Opzionale: `rg` (ripgrep) per una ricerca migliore
- Opzionale: `python3` per lo strumento di modifica

Le versioni di runtime sono bloccate in `.tool-versions`. Installale con [mise](https://mise.jdx.dev/):

```bash
mise install
```

## Utilizzo

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### Variabili d'Ambiente

| Variabile | Predefinito | Descrizione |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (obbligatorio) | La tua chiave API Anthropic |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | Modello da utilizzare |
| `CLAUDE_MAX_TOKENS` | `8192` | Numero massimo di token in output |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | URL base dell'API |
| `CLAUDE_SH_PERMISSIONS` | `ask` | Modalità permessi: `ask`, `allow` o `deny` |

### Comandi

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

### Riprendi una Sessione

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## Architettura

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## Come Funziona

1. Leggi l'input dell'utente
2. Costruisci la richiesta JSON con `jq` (messaggi, strumenti, prompt di sistema)
3. Trasmetti la risposta tramite `curl` attraverso una pipe FIFO
4. Analizza gli eventi SSE riga per riga, stampa i delta di testo in tempo reale
5. Quando arrivano i blocchi tool_use, esegui gli strumenti
6. Invia i risultati degli strumenti come messaggi
7. Ripeti fino a quando Claude smette di chiamare gli strumenti

## Confronto

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| Linee di codice | ~1.500 | ~380.000 |
| Dipendenze | curl, jq | 266 pacchetti npm |
| Dimensione binaria | 0 (script) | ~200MB node_modules |
| Tempo di avvio | Istantaneo | ~500ms |

### Test

I test utilizzano [bats](https://github.com/bats-core/bats-core) (Bash Automated Testing System):

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---
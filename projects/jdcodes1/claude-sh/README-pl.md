
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

Claude Code przepisany jako skrypt bash. ~1 500 linii. Zero pakietów npm.

## Dlaczego

Oryginalny Claude Code to około 380 000 linii TypeScript z 266 zależnościami npm. Ten skrypt wykonuje tę samą główną funkcję w bashu używając tylko `curl` i `jq`.

## Funkcje

- **Strumieniowanie w czasie rzeczywistym** przez FIFO — tekst pojawia się podczas generowania przez Claude'a
- **6 narzędzi**: Bash, Read, Edit, Write, Glob, Grep
- **Łączenie narzędzi** — do 25 wywołań narzędzi na turę
- **Potwierdzanie uprawnień** — pyta przed uruchomieniem niebezpiecznych poleceń (`y/n/a`)
- **Ładowanie CLAUDE.md** — czyta instrukcje projektu z plików CLAUDE.md w drzewie katalogów
- **Kontekst Git** — gałąź, status i ostatnie commity w systemowym promptcie
- **Zapisywanie/wznawianie sesji** — automatyczne zapisywanie przy wyjściu, wznowienie przez `--resume <id>`
- **Ponawianie z backoffem** — wykładnicze ponawianie przy limitach 429/529
- **Śledzenie kosztów** — sumy per tura i dla całej sesji
- **Spinner** — z oryginalnymi czasownikami spinnera (Clauding, Flibbertigibbeting, itd.)
- **Komendy slash** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **Tryb pipe** — `echo "wyjaśnij to" | ./claude.sh`

## Instalacja

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## Zależności

- `curl`
- `jq`
- Opcjonalnie: `rg` (ripgrep) dla lepszego wyszukiwania
- Opcjonalnie: `python3` do narzędzia edycji

Wersje środowiskowe są przypięte w `.tool-versions`. Zainstaluj je za pomocą [mise](https://mise.jdx.dev/):

```bash
mise install
```

## Użycie

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### Zmienne środowiskowe

| Zmienna | Domyślna | Opis |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (wymagane) | Twój klucz API Anthropic |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | Model do użycia |
| `CLAUDE_MAX_TOKENS` | `8192` | Maksymalna liczba tokenów wyjściowych |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | Podstawowy URL API |
| `CLAUDE_SH_PERMISSIONS` | `ask` | Tryb uprawnień: `ask`, `allow` lub `deny` |

### Polecenia

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

### Wznów sesję

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## Architektura

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## Jak to działa

1. Odczytaj dane wejściowe użytkownika
2. Zbuduj żądanie JSON za pomocą `jq` (wiadomości, narzędzia, prompt systemowy)
3. Przesyłaj odpowiedź strumieniowo przez `curl` przez potok FIFO
4. Parsuj zdarzenia SSE linia po linii, drukuj zmiany tekstu w czasie rzeczywistym
5. Gdy pojawią się bloki tool_use, wykonaj narzędzia
6. Przekaż wyniki narzędzi z powrotem jako wiadomości
7. Powtarzaj, aż Claude przestanie wywoływać narzędzia

## Porównanie

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| Liczba linii kodu | ~1 500 | ~380 000 |
| Zależności | curl, jq | 266 paczek npm |
| Rozmiar binarny | 0 (skrypt) | ~200MB node_modules |
| Czas uruchamiania | Natychmiastowy | ~500ms |

### Testowanie

Testy wykorzystują [bats](https://github.com/bats-core/bats-core) (Bash Automated Testing System):

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---
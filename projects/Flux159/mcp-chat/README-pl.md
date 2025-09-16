
# mcp-chat

<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

Otwarty uniwersalny klient MCP do testowania i oceny serwerów oraz agentów MCP

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## Szybki start

Upewnij się, że masz wyeksportowany `ANTHROPIC_API_KEY` w swoim środowisku lub w pliku .env w katalogu głównym projektu. Klucz API możesz uzyskać, rejestrując się na [stronie kluczy Anthropic Console](https://console.anthropic.com/settings/keys).

Prosty przypadek użycia uruchamiający interaktywny prompt czatu z serwerem MCP systemu plików z poziomu CLI:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

To spowoduje otwarcie okna czatu, którego możesz użyć do interakcji z serwerami i rozmowy z LLM.

## Konfiguracja

Możesz także po prostu wskazać swój plik claude_desktop_config.json (Mac):

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

Lub (Windows):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

W trybie webowym możesz rozpoczynać nowe czaty, wysyłać wiadomości do modelu oraz dynamicznie konfigurować serwery mcp przez interfejs użytkownika – nie musisz podawać ich w linii poleceń. Dodatkowo, czaty utworzone przez Web UI są zapisywane w ~/.mcpchats/chats, tak samo jak czaty utworzone przez CLI.

## Funkcje

- [x] Uruchamianie przez CLI w trybie interaktywnym lub bezpośrednie podanie promptów z `-p`
- [x] Tryb webowy do rozmów z modelami przez interfejs webowy `--web`
- [x] Połączenie z dowolnym serwerem MCP (JS, Python, Docker) w produkcji lub podczas rozwoju
- [x] Wybór między modelami za pomocą `-m`
- [x] Dostosowanie promptu systemowego za pomocą `--system`
- [x] Zapisywanie historii czatu z ustawieniami w `~/.mcpchat/chats`, także czaty webowe
- [x] Zapis i przywracanie poleceń w `~/.mcpchat/history`
- [x] Podgląd wyników wywołań narzędzi i argumentów bezpośrednio w czacie, aby ułatwić debugowanie serwerów mcp

## Użycie CLI

Uruchamiaj prompt przez CLI z flagą `-p`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

To polecenie uruchamia prompt z serwerem mcp na kubernetes i kończy działanie po otrzymaniu odpowiedzi na stdout.

Wybierz model do rozmowy przez CLI za pomocą flagi `-m`:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

Używa modelu `claude-3.5` do prowadzenia rozmów. Zwróć uwagę, że obecnie obsługiwane są tylko modele Anthropic.

Własny prompt systemowy:

Flaga `--system` może być użyta do określenia promptu systemowego:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## Zmienne środowiskowe (ENV vars)

Mcp-chat umożliwia przekazywanie zmiennych środowiskowych do serwerów mcp. Nie jest to jednak ustandaryzowane w specyfikacji mcp i inni klienci mogą nie obsługiwać dynamicznych wartości zmiennych środowiskowych — przeczytaj więcej [tutaj](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) o standardowych klientach mcp stdio.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## Dla deweloperów mcp-serwerów

Możesz przekazać lokalną kompilację pythonowego lub node'owego mcp-serwera, aby przetestować go z mcp-chat:

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

## Rozwój

Zainstaluj zależności i uruchom CLI:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
Aby rozwijać mcp-chat podczas łączenia się z mcp-server, wykonaj kompilację i uruchom CLI z flagą serwera:


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Testowanie:

```shell
bun run test
```

Budowa:

```shell
bun run build
```

Publikowanie:

```shell
bun run publish
```

Publikowanie Dockera:

```shell
bun run dockerbuild
```

### Struktura projektu

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## Publikowanie nowego wydania

Przejdź do strony [releases](https://github.com/Flux159/mcp-chat/releases), kliknij "Draft New Release", kliknij "Choose a tag" i utwórz nowy tag, wpisując nowy numer wersji w formacie semver "v{major}.{minor}.{patch}". Następnie wpisz tytuł wydania "Release v{major}.{minor}.{patch}" oraz opis / changelog, jeśli to konieczne, i kliknij "Publish Release".

Spowoduje to utworzenie nowego tagu, który uruchomi nową kompilację wydania przez workflow cd.yml. Po pomyślnym zakończeniu, nowe wydanie zostanie opublikowane na npm. Zwróć uwagę, że nie ma potrzeby ręcznej aktualizacji wersji w package.json, ponieważ workflow automatycznie zaktualizuje numer wersji w pliku package.json i wypchnie commit do main.

## Licencja

[Licencja MIT](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---
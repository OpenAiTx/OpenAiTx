# Specyfikacja Universal Tool Calling Protocol (UTCP)

To repozytorium zawiera oficjalną dokumentację specyfikacji Universal Tool Calling Protocol (UTCP). UTCP to nowoczesny, elastyczny i skalowalny standard do definiowania i obsługi narzędzi w różnych protokołach komunikacyjnych.

## Czym jest UTCP?

UTCP zapewnia standaryzowany sposób dla systemów AI i innych klientów na odkrywanie i wywoływanie narzędzi od różnych dostawców, niezależnie od używanego protokołu (HTTP, WebSocket, CLI, itd.). Ta specyfikacja definiuje:

- Mechanizmy odkrywania narzędzi
- Format wywołań narzędzi
- Konfigurację dostawcy
- Metody uwierzytelniania
- Obsługę odpowiedzi

## Wkład w specyfikację

Zachęcamy do współtworzenia specyfikacji UTCP! Oto jak możesz się zaangażować:

1. **Fork repozytorium**: Utwórz własny fork repozytorium specyfikacji
2. **Wprowadź zmiany**: Zaktualizuj lub dodaj dokumentację według potrzeb
3. **Wyślij pull request**: Otwórz PR ze swoimi zmianami do przeglądu
4. **Uczestnicz w dyskusjach**: Dołącz do rozmów o proponowanych zmianach

Podczas współtworzenia prosimy o przestrzeganie tych wytycznych:

- Upewnij się, że zmiany są zgodne z wizją i celami UTCP
- Przestrzegaj ustalonej struktury dokumentacji i formatowania
- Dodawaj przykłady przy wprowadzaniu nowych funkcji lub koncepcji
- Aktualizuj odpowiednie sekcje, aby zachować spójność dokumentacji

## Budowanie dokumentacji lokalnie

### Wymagania wstępne

Aby zbudować i podejrzeć stronę dokumentacji lokalnie, potrzebujesz:

- Ruby w wersji 2.5.0 lub wyższej
- RubyGems
- Bundler

### Konfiguracja

1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. Zainstaluj zależności:

   ```bash
   bundle install
   ```
### Uruchamianie strony dokumentacji

Aby zbudować i uruchomić stronę lokalnie:


```bash
bundle exec jekyll serve
```
To uruchomi lokalny serwer WWW pod adresem `http://localhost:4000`, gdzie możesz podejrzeć dokumentację.

## Struktura dokumentacji

Dokumentacja UTCP jest zorganizowana w następujący sposób:

- `index.md`: Strona główna i wprowadzenie do UTCP
- `docs/`
  - `introduction.md`: Szczegółowe wprowadzenie i podstawowe pojęcia
  - `for-tool-providers.md`: Przewodnik dla implementujących dostawców narzędzi
  - `for-tool-callers.md`: Przewodnik dla implementujących wywołujących narzędzia
  - `providers/`: Dokumentacja dla każdego typu dostawcy
    - `http.md`: Dostawca HTTP
    - `websocket.md`: Dostawca WebSocket
    - `cli.md`: Dostawca CLI
    - `sse.md`: Dostawca Server-Sent Events
    - itd.
  - `implementation.md`: Wytyczne dotyczące implementacji i najlepsze praktyki

## Praca ze specyfikacją

### Modyfikowanie dokumentacji

Dokumentacja jest napisana w formacie Markdown z nagłówkiem Jekyll. Wprowadzając zmiany:

1. Upewnij się, że Twój Markdown zachowuje ustalony styl
2. Przeglądaj zmiany lokalnie przed zgłoszeniem PR-ów
3. Utrzymuj przykłady zgodne z najnowszą specyfikacją
4. Aktualizuj pozycje nawigacyjne w `_config.yml`, jeśli dodajesz nowe strony

### Organizacja plików

Dodając nową dokumentację:

- Umieszczaj dokumentację dotyczącą konkretnego dostawcy w `docs/providers/`
- Używaj spójnego nagłówka z odpowiednim porządkiem nawigacyjnym
- Dodawaj tagi dla lepszej wyszukiwalności na GitHub Pages

## Kontrola wersji

Specyfikacja UTCP podąża za semantycznym wersjonowaniem:

- Wersje główne (1.0, 2.0): Zmiany niezgodne wstecznie w protokole
- Wersje poboczne (1.1, 1.2): Nowe funkcje dodawane w sposób zgodny wstecznie
- Wersje poprawek (1.0.1, 1.0.2): Poprawki błędów i doprecyzowania zgodne wstecznie

## Licencja

Ta specyfikacja jest rozpowszechniana na licencji Mozilla Public License 2.0 (MPL-2.0).

## Dodatkowe zasoby

- [Organizacja UTCP na GitHub](https://github.com/universal-tool-calling-protocol)
- [Strona internetowa UTCP](https://utcp.io)
- [Implementacje referencyjne](https://github.com/universal-tool-calling-protocol/python-utcp)
- [Dyskusje społeczności](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---
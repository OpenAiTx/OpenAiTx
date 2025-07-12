#寸止 🛑

> **AI Rozmowa „przedwczesnego zakończenia” pogromca – niech rozmowa trwa do końca**

Czy dalej frustruje Cię, że Twój asystent AI zawsze przedwcześnie kończy rozmowę? Gdy masz jeszcze wiele do omówienia, a on pyta: „Czy mogę jeszcze w czymś pomóc?” **寸止** rozwiązuje ten problem!

Gdy AI próbuje „zakończyć na szybko”,寸止 natychmiast wyświetli okno dialogowe, umożliwiając dalszą, pogłębioną rozmowę – aż do pełnego rozwiązania problemu.

## 🌟 Kluczowe funkcje

- 🛑 **Inteligentna blokada**: Automatyczne wyświetlanie opcji kontynuacji, gdy AI chce zakończyć rozmowę
- 🧠 **Zarządzanie pamięcią**: Przechowywanie standardów i preferencji projektowych według projektu
- 🎨 **Elegancka interakcja**: Obsługa Markdown, różne metody wprowadzania danych
- ⚡ **Gotowe do użycia**: Instalacja w 3 sekundy, wsparcie wielu platform

## 📸 Zobacz efekty

### 🛑 Inteligentne okno blokujące
![寸止弹窗演示](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*Gdy AI chce zakończyć rozmowę,寸止 natychmiast wyświetla inteligentne okno z predefiniowanymi opcjami, umożliwiając szybki wybór i dalsze, pogłębione rozmowy*
### ⚙️ Interfejs zarządzania ustawieniami
![寸止设置界面](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*Elegancki interfejs ustawień, obsługuje zarządzanie pamięcią, przełączniki funkcji, zmianę motywu oraz inteligentne generowanie podpowiedzi*

## 🚀 Rozpocznij korzystanie

### Metoda 1: Szybka instalacja (zalecana)

**Użytkownicy macOS:**
```bash
# Instalacja w 3 sekundy, bez oczekiwania na kompilację
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **Rozwiązywanie problemów**: Jeśli napotkasz błąd pobierania 404, wykonaj następujące kroki:
>
> ```bash
> # Wyczyść stary cache tap
> brew untap imhuso/cunzhi
> # Zainstaluj ponownie
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **Przykładowy błąd:**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> Zazwyczaj wynika to z problemów z cache poprzedniej wersji, powodujących niezgodność numeru wersji. Wyczyść tap i zainstaluj ponownie, aby rozwiązać problem.

**Użytkownicy Windows/Linux:**
Zalecamy ręczne pobranie według metody drugiej – proste i szybkie!
### 方式 druga: ręczne pobieranie

1. Odwiedź [stronę Releases](https://github.com/imhuso/cunzhi/releases)
2. Pobierz wersję odpowiednią dla Twojego systemu:
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. Po rozpakowaniu dodaj `寸止` oraz `等一下` do zmiennej PATH systemu

## ⚡ Szybki start

### Krok pierwszy: Konfiguracja klienta MCP

Dodaj do pliku konfiguracyjnego swojego klienta MCP (np. Claude Desktop):

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### Krok drugi: Otwórz interfejs ustawień

```bash
# Uruchom polecenie ustawień
Poczekaj chwilę
```

### Krok trzeci: Skonfiguruj prompt

W zakładce "Referencyjne prompt'y" w interfejsie ustawień:
1. Sprawdź automatycznie wygenerowane prompt'y
2. Kliknij przycisk kopiowania
3. Dodaj prompt'y do swojego asystenta AI

### Krok czwarty: Zacznij używać

Twój asystent AI posiada teraz funkcje inteligentnej blokady, zarządzania pamięcią oraz interakcji w oknach dialogowych!

> 💡 **Wskazówka**: Możesz edytować wygenerowane prompt'y według własnych potrzeb, aby stworzyć spersonalizowane doświadczenie interakcji z AI.
## 🤝 Udział i wkład

Cunzhi to projekt open source i zachęcamy do wszelkich form wkładu!

### 🐛 Znalazłeś problem?
- [Zgłoś Issue](https://github.com/imhuso/cunzhi/issues) i opisz problem
- Podaj kroki odtworzenia oraz informacje o środowisku

### 💡 Masz dobry pomysł?
- [Rozpocznij dyskusję](https://github.com/imhuso/cunzhi/discussions) i podziel się swoim pomysłem
- Prześlij Pull Request z nową funkcjonalnością

### 🛠️ Rozwój lokalny
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 Kontakt

- 🐛 **Zgłaszanie problemów**: [GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **Dyskusje o funkcjach**: [GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **Lubisz projekt**: Daj nam gwiazdkę jako wsparcie!

## 📄 Licencja open source

MIT License - Dowolne użycie, zapraszamy do współtworzenia!

---

<div align="center">

**Pożegnaj się z "przedwczesnym" końcem dialogów AI | Niech każda rozmowa trwa do końca**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 Zgłoś błąd](https://github.com/imhuso/cunzhi/issues) · [💡 Zgłoś propozycję funkcji](https://github.com/imhuso/cunzhi/discussions)

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---
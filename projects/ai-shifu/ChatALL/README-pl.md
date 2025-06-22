<div align="center">
  <img src="https://raw.githubusercontent.com/ai-shifu/ChatALL/main/src/assets/logo-cover.png" width=256></img>
  <p><strong>Rozmawiaj jednocześnie ze wszystkimi botami AI, odkrywaj najlepsze rozwiązania</strong></p>

[Deutsch](README_DE-DE.md) | English | [Español](README_ES-ES.md) | [Français](README_FR-FR.md) | [Italian](README_IT-IT.md) | [日本語](README_JA-JP.md) | [한국어](README_KO-KR.md) | [Русский](README_RU-RU.md) | [Tiếng Việt](README_VI-VN.md) | [简体中文](README_ZH-CN.md)

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/ai-shifu/ChatALL)

</div>

## Zrzuty ekranu

![Screenshot](https://raw.githubusercontent.com/ai-shifu/ChatALL/main/screenshots/screenshot-1.png?raw=true)

## Funkcje

Boty AI oparte na dużych modelach językowych (LLM) są niesamowite. Jednak ich zachowanie bywa losowe, a różne boty sprawdzają się lepiej w różnych zadaniach. Jeśli chcesz uzyskać najlepsze rezultaty, nie próbuj każdego z osobna. ChatALL (chińska nazwa: 齐叨) może wysyłać zapytania do kilku botów AI jednocześnie, pomagając znaleźć najlepsze odpowiedzi. Wystarczy [pobrać, zainstalować](https://github.com/ai-shifu/ChatALL/releases) i zapytać.

### Czy to Ty?

Typowi użytkownicy ChatALL to:

- 🤠**Eksperci od LLM**, którzy chcą znaleźć najlepsze odpowiedzi lub twórczości z LLM.
- 🤓**Badacze LLM**, którzy chcą intuicyjnie porównać mocne i słabe strony różnych LLM w różnych dziedzinach.
- 😎**Deweloperzy aplikacji LLM**, którzy chcą szybko debugować prompty i znaleźć najlepiej działające modele bazowe.

### Obsługiwane boty

| Boty AI                                                                         | Dostęp przez WWW | API         | Uwagi                                         |
| -------------------------------------------------------------------------------- | --------------- | ----------- | --------------------------------------------- |
| [360 AI Brain](https://ai.360.cn/)                                               | Tak             | Brak API    |                                               |
| [Baidu ERNIE](https://yiyan.baidu.com/)                                          | Nie             | Tak         |                                               |
| [Character.AI](https://character.ai/)                                            | Tak             | Brak API    |                                               |
| [ChatGLM2 6B & 130B](https://chatglm.cn/)                                        | Tak             | Brak API    | Nie wymaga logowania                          |
| [ChatGPT](https://chatgpt.com)                                                   | Tak             | Tak         | Przeglądanie WWW, obsługa Azure OpenAI         |
| [Claude](https://www.anthropic.com/claude)                                       | Tak             | Tak         |                                               |
| [Code Llama](https://ai.meta.com/blog/code-llama-large-language-model-coding/)   | Tak             | Brak API    |                                               |
| [Cohere Aya 23](https://cohere.com/blog/aya23)                                   | Nie             | Tak         |                                               |
| [Cohere Command R Models](https://cohere.com/command)                            | Nie             | Tak         |                                               |
| [Copilot](https://copilot.microsoft.com/)                                        | Tak             | Brak API    |                                               |
| [Dedao Learning Assistant](https://ai.dedao.cn/)                                 | Wkrótce         | Brak API    |                                               |
| [Falcon 180B](https://huggingface.co/tiiuae/falcon-180B-chat)                    | Tak             | Brak API    |                                               |
| [Gemini](https://gemini.google.com/)                                             | Tak             | Tak         |                                               |
| [Gemma 2B & 7B](https://blog.google/technology/developers/gemma-open-models/)    | Tak             | Brak API    |                                               |
| [Gradio](https://gradio.app/)                                                    | Tak             | Brak API    | Dla modeli Hugging Face/self-hostowanych       |
| [Groq Cloud](https://console.groq.com/docs/models)                               | Nie             | Tak         |                                               |
| [HuggingChat](https://huggingface.co/chat/)                                      | Tak             | Brak API    |                                               |
| [iFLYTEK SPARK](http://xinghuo.xfyun.cn/)                                       | Tak             | Wkrótce     |                                               |
| [Kimi](https://kimi.moonshot.cn/               )                                 | Tak             | Brak API    |                                               |
| [Llama 2 13B & 70B](https://ai.meta.com/llama/)                                  | Tak             | Brak API    |                                               |
| [MOSS](https://moss.fastnlp.top/)                                                | Tak             | Brak API    |                                               |
| [Perplexity](https://www.perplexity.ai/)                                         | Tak             | Brak API    |                                               |
| [Phind](https://www.phind.com/)                                                  | Tak             | Brak API    |                                               |
| [Pi](https://pi.ai)                                                              | Tak             | Brak API    |                                               |
| [Poe](https://poe.com/)                                                          | Tak             | Wkrótce     |                                               |
| [SkyWork](https://neice.tiangong.cn/)                                            | Tak             | Wkrótce     |                                               |
| [Tongyi Qianwen](http://tongyi.aliyun.com/)                                      | Tak             | Wkrótce     |                                               |
| [Vicuna 13B & 33B](https://lmsys.org/blog/2023-03-30-vicuna/)                    | Tak             | Brak API    | Nie wymaga logowania                          |
| [WizardLM 70B](https://github.com/nlpxucan/WizardLM)                             | Tak             | Brak API    |                                               |
| [xAI Grok](https://x.ai)                                                         | Nie             | Tak         |                                               |
| [YouChat](https://you.com/)                                                      | Tak             | Brak API    |                                               |
| [You](https://you.com/)                                                          | Tak             | Brak API    |                                               |
| [Zephyr](https://huggingface.co/spaces/HuggingFaceH4/zephyr-chat)                | Tak             | Brak API    |                                               |

Więcej w drodze. Zagłosuj na swoje ulubione boty w [tych zgłoszeniach](https://github.com/ai-shifu/ChatALL/labels/more%20LLMs).

### Uwaga dotycząca niezawodności botów webowych

Boty AI połączone z siecią (oznaczone jako "Dostęp przez WWW") są z natury mniej niezawodne i często napotykają na problemy ze stabilnością, ponieważ dostawcy usług regularnie aktualizują swoje interfejsy i zabezpieczenia. Te połączenia webowe opierają się na inżynierii wstecznej i są trudne w utrzymaniu, często przestają działać niespodziewanie. Dla niezawodności zalecamy używanie botów oferujących dostęp przez API, jeśli to możliwe.

### Inne funkcje

- Tryb szybkiego promptowania: wyślij kolejne zapytanie bez czekania na zakończenie poprzedniego
- Zapis historii rozmów lokalnie, ochrona prywatności
- Wyróżnianie ulubionych odpowiedzi, usuwanie niechcianych
- Możliwość włączania/wyłączania dowolnych botów w dowolnym momencie
- Widok jedno-, dwu- lub trójkolumnowy
- Automatyczna aktualizacja do najnowszej wersji
- Tryb ciemny (wkład @tanchekwei)
- Skróty klawiaturowe. Wciśnij <kbd>Ctrl</kbd> + <kbd>/</kbd>, aby zobaczyć wszystkie (wkład @tanchekwei)
- Wiele czatów (wkład @tanchekwei)
- Ustawienia proxy (wkład @msaong)
- Zarządzanie promptami (wkład @tanchekwei)
- Wsparcie dla wielu języków (chiński, angielski, niemiecki, francuski, rosyjski, wietnamski, koreański, japoński, hiszpański, włoski)
- Obsługa Windows, macOS i Linux

Plany rozwoju:

Zapraszamy do współpracy przy tych funkcjach.

- [ ] Wdrożenie front-endu na GitHub Pages

## Prywatność

Cała historia rozmów, ustawienia i dane logowania są zapisywane lokalnie na Twoim komputerze.

ChatALL zbiera anonimowe dane dotyczące użytkowania w celu ulepszania produktu. Obejmuje to:

- Które boty AI są wywoływane i jak długi jest prompt. Nie obejmuje treści promptu.
- Jak długa jest odpowiedź oraz które odpowiedzi są usuwane/wyróżniane. Nie obejmuje treści odpowiedzi.

## Wymagania wstępne

ChatALL to klient, nie proxy. Dlatego musisz:

1. Posiadać działające konta i/lub tokeny API do botów.
2. Mieć niezawodne połączenie sieciowe z botami.

## Pobieranie / Instalacja

Pobierz z https://github.com/ai-shifu/ChatALL/releases

### Na Windows

Pobierz plik \*-win.exe i rozpocznij instalację.

### Na macOS

Dla Maców z Apple Silicon (CPU M1, M2) pobierz plik \*-mac-arm64.dmg.

Dla pozostałych Maców pobierz plik \*-mac-x64.dmg.

Jeśli korzystasz z [Homebrew](https://brew.sh/), możesz zainstalować za pomocą:

```bash
brew install --cask chatall
```

### Na Linux

Dystrybucje oparte na Debianie: Pobierz plik .deb, kliknij dwukrotnie i zainstaluj program.
Dystrybucje oparte na Arch: Możesz sklonować ChatALL z AUR [tutaj](https://aur.archlinux.org/packages/chatall-bin). Zainstaluj ręcznie lub za pomocą pomocnika AUR, np. yay lub paru.
Pozostałe dystrybucje: Pobierz plik .AppImage, nadaj mu uprawnienia do wykonania i uruchom jednym kliknięciem. Możesz też użyć [AppimageLauncher](https://github.com/TheAssassin/AppImageLauncher).

## Rozwiązywanie problemów

W przypadku problemów z ChatALL możesz spróbować:

1. **Odśwież** - wciśnij <kbd>Ctrl</kbd> + <kbd>R</kbd> lub <kbd>⌘</kbd> + <kbd>R</kbd>.
2. **Restartuj** - zamknij ChatALL i uruchom ponownie.
3. **Zaloguj ponownie** - kliknij przycisk ustawień w prawym górnym rogu, następnie odpowiedni link logowania/wylogowania.
4. **Utwórz nowy czat** - kliknij przycisk `New Chat` i wyślij prompt ponownie.

Jeśli powyższe metody nie pomogą, możesz spróbować **zresetować ChatALL**. Uwaga: spowoduje to usunięcie wszystkich ustawień i historii wiadomości.

Możesz zresetować ChatALL usuwając następujące katalogi:

- Windows: `C:\Users\<user>\AppData\Roaming\chatall\`
- Linux: `/home/<user>/.config/chatall/`
- macOS: `/Users/<user>/Library/Application Support/chatall/`

Jeśli problem nadal występuje, [zgłoś problem](https://github.com/ai-shifu/ChatALL/issues).

## Dla deweloperów

### Dodaj własnego bota

[Poradnik](https://github.com/ai-shifu/ChatALL/wiki/%E5%A6%82%E4%BD%95%E6%B7%BB%E5%8A%A0%E4%B8%80%E4%B8%AA%E6%96%B0%E7%9A%84-AI-%E5%AF%B9%E8%AF%9D%E6%9C%BA%E5%99%A8%E4%BA%BA) może być pomocny.

### Uruchamianie

```bash
npm install
npm run electron:serve
```

### Budowanie

Buduj dla obecnej platformy:

```bash
npm run electron:build
```

Buduj dla wszystkich platform:

```bash
npm run electron:build -- -wml --x64 --arm64
```

## Podziękowania

### Współtwórcy

<a href="https://github.com/ai-shifu/ChatALL/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ai-shifu/ChatALL" />
</a>

### Inne

- GPT-4 znacząco przyczynił się do kodu
- ChatGPT, Copilot i Google dostarczyły wiele rozwiązań (kolejność według ważności)
- Inspiracja: [ChatHub](https://github.com/chathub-dev/chathub). Szacunek!

## Sponsor

Jeśli podoba Ci się ten projekt, rozważ wsparcie:

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F1F8KZJGJ)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-22

---
# AutoGPT: Buduj, Wdrażaj i Uruchamiaj Agentów AI

[![Discord Follow](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Follow](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT** to potężna platforma umożliwiająca tworzenie, wdrażanie i zarządzanie ciągłymi agentami AI automatyzującymi złożone procesy.

## Opcje Hostingu
   - Pobierz do samodzielnego hostowania
   - [Dołącz do listy oczekujących](https://bit.ly/3ZDijAI) na wersję beta hostowaną w chmurze

## Jak skonfigurować do samodzielnego hostowania
> [!NOTE]
> Konfiguracja i samodzielne hostowanie platformy AutoGPT to proces techniczny.
> Jeśli wolisz rozwiązanie, które po prostu działa, zalecamy [dołączenie do listy oczekujących](https://bit.ly/3ZDijAI) na wersję beta hostowaną w chmurze.

### Wymagania systemowe

Przed rozpoczęciem instalacji upewnij się, że Twój system spełnia następujące wymagania:

#### Wymagania sprzętowe
- CPU: Zalecane 4+ rdzenie
- RAM: Minimum 8GB, zalecane 16GB
- Pamięć: Co najmniej 10GB wolnego miejsca

#### Wymagania programowe
- Systemy operacyjne:
  - Linux (zalecany Ubuntu 20.04 lub nowszy)
  - macOS (10.15 lub nowszy)
  - Windows 10/11 z WSL2
- Wymagane oprogramowanie (z minimalnymi wersjami):
  - Docker Engine (20.10.0 lub nowszy)
  - Docker Compose (2.0.0 lub nowszy)
  - Git (2.30 lub nowszy)
  - Node.js (16.x lub nowszy)
  - npm (8.x lub nowszy)
  - VSCode (1.60 lub nowszy) lub dowolny nowoczesny edytor kodu

#### Wymagania sieciowe
- Stabilne połączenie internetowe
- Dostęp do wymaganych portów (zostaną skonfigurowane w Dockerze)
- Możliwość nawiązywania połączeń wychodzących HTTPS

### Zaktualizowane instrukcje konfiguracji:
Przenieśliśmy się na w pełni utrzymywaną i regularnie aktualizowaną stronę dokumentacji.

👉 [Postępuj według oficjalnego przewodnika po samodzielnym hostingu tutaj](https://docs.agpt.co/platform/getting-started/)

Ten samouczek zakłada, że masz zainstalowane Docker, VSCode, git oraz npm.

### 🧱 AutoGPT Frontend

Frontend AutoGPT to miejsce, gdzie użytkownicy wchodzą w interakcję z naszą potężną platformą automatyzacji AI. Oferuje wiele sposobów angażowania się i wykorzystywania naszych agentów AI. To interfejs, w którym ożywisz swoje pomysły na automatyzację AI:

   **Agent Builder:** Dla tych, którzy chcą dostosować agenta, nasz intuicyjny, niskokodowy interfejs pozwala zaprojektować i skonfigurować własnych agentów AI.

   **Zarządzanie workflow:** Buduj, modyfikuj i optymalizuj swoje procesy automatyzacji z łatwością. Tworzysz agenta, łącząc bloki, z których każdy wykonuje pojedynczą akcję.

   **Kontrola wdrożenia:** Zarządzaj cyklem życia swoich agentów, od testowania po produkcję.

   **Gotowe agenty:** Nie chcesz budować? Wybierz z naszej biblioteki gotowych agentów i od razu zacznij z nich korzystać.

   **Interakcja z agentami:** Niezależnie czy zbudowałeś własnego, czy korzystasz z gotowych agentów, łatwo uruchamiaj i obsługuj je przez przyjazny interfejs użytkownika.

   **Monitorowanie i analityka:** Śledź wydajność swoich agentów i zdobywaj wiedzę, by stale ulepszać swoje procesy automatyzacji.

[Przeczytaj ten przewodnik](https://docs.agpt.co/platform/new_blocks/), aby dowiedzieć się, jak budować własne niestandardowe bloki.

### 💽 AutoGPT Server

Serwer AutoGPT to centrum naszej platformy. Tutaj działają Twoi agenci. Po wdrożeniu agenci mogą być wyzwalani przez źródła zewnętrzne i działać nieprzerwanie. Zawiera wszystkie istotne komponenty zapewniające płynne działanie AutoGPT.

   **Kod źródłowy:** Główna logika, która napędza naszych agentów i procesy automatyzacji.

   **Infrastruktura:** Solidne systemy zapewniające niezawodność i skalowalność.

   **Marketplace:** Kompleksowy rynek, gdzie znajdziesz i wdrożysz szeroką gamę gotowych agentów.

### 🐙 Przykładowi agenci

Oto dwa przykłady tego, co możesz zrobić z AutoGPT:

1. **Generowanie viralowych filmów z trendujących tematów**
   - Ten agent czyta tematy na Reddit.
   - Identyfikuje tematy na czasie.
   - Następnie automatycznie tworzy krótki film na podstawie treści.

2. **Wyszukiwanie najlepszych cytatów z filmów do social media**
   - Ten agent subskrybuje Twój kanał YouTube.
   - Po opublikowaniu nowego filmu, transkrybuje go.
   - Używa AI do identyfikacji najbardziej wpływowych cytatów i generuje podsumowanie.
   - Następnie pisze post i automatycznie publikuje go w Twoich mediach społecznościowych.

Te przykłady pokazują jedynie ułamek możliwości AutoGPT! Możesz tworzyć własne workflow i budować agentów pod dowolny przypadek użycia.

---
### Misja i licencjonowanie
Naszą misją jest dostarczać narzędzia, dzięki którym możesz skupić się na tym, co ważne:

- 🏗️ **Budowanie** – Połóż fundament pod coś niesamowitego.
- 🧪 **Testowanie** – Doprowadź swojego agenta do perfekcji.
- 🤝 **Delegowanie** – Pozwól AI pracować dla Ciebie i ożywiaj swoje pomysły.

Dołącz do rewolucji! **AutoGPT** zostaje na dłużej, będąc na czele innowacji AI.

**📖 [Dokumentacja](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [Współtwórz](CONTRIBUTING.md)**

**Licencjonowanie:**

Licencja MIT: Większość repozytorium AutoGPT jest objęta licencją MIT.

Polyform Shield License: Ta licencja dotyczy folderu autogpt_platform.

Więcej informacji znajdziesz na https://agpt.co/blog/introducing-the-autogpt-platform

---
## 🤖 AutoGPT Classic
> Poniżej znajdziesz informacje o klasycznej wersji AutoGPT.

**🛠️ [Zbuduj własnego agenta – Szybki start](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

**Stwórz własnego agenta!** &ndash; Forge to gotowy zestaw narzędzi do budowy własnej aplikacji agenta. Obsługuje większość kodu szablonowego, pozwalając Ci skupić się na tym, co wyróżnia *Twojego* agenta. Wszystkie samouczki znajdziesz [tutaj](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec). Komponenty z [`forge`](/classic/forge/) mogą być także używane pojedynczo, aby przyspieszyć rozwój i ograniczyć kod szablonowy w Twoim projekcie.

🚀 [**Pierwsze kroki z Forge**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) &ndash;
Ten przewodnik przeprowadzi Cię przez proces tworzenia własnego agenta oraz korzystania z benchmarków i interfejsu użytkownika.

📘 [Dowiedz się więcej](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge) o Forge

### 🎯 Benchmark

**Mierz wydajność swoich agentów!** `agbenchmark` można używać z każdym agentem obsługującym protokół agentów, a integracja z [CLI] projektu dodatkowo ułatwia korzystanie z AutoGPT i agentów opartych o forge. Benchmark zapewnia rygorystyczne środowisko testowe. Nasze ramy pozwalają na autonomiczne, obiektywne oceny wydajności, gwarantując, że Twoi agenci są gotowi do działania w rzeczywistych warunkach.

<!-- TODO: insert visual demonstrating the benchmark -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) na Pypi
&ensp;|&ensp;
📘 [Dowiedz się więcej](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark) o Benchmarku

### 💻 UI

**Ułatwia korzystanie z agentów!** `frontend` zapewnia przyjazny interfejs do sterowania i monitorowania agentów. Łączy się z agentami przez [agent protocol](#-agent-protocol), zapewniając kompatybilność z wieloma agentami zarówno z naszego ekosystemu, jak i spoza niego.

<!-- TODO: insert screenshot of front end -->

Frontend działa od razu ze wszystkimi agentami w repozytorium. Wystarczy użyć [CLI], aby uruchomić wybranego agenta!

📘 [Dowiedz się więcej](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend) o Frontendzie

### ⌨️ CLI

[CLI]: #-cli

Aby jak najbardziej ułatwić korzystanie ze wszystkich narzędzi oferowanych przez repozytorium, w katalogu głównym repozytorium znajduje się CLI:

```shell
$ ./run
Usage: cli.py [OPTIONS] COMMAND [ARGS]...

Options:
  --help  Show this message and exit.

Commands:
  agent      Commands to create, start and stop agents
  benchmark  Commands to start the benchmark and list tests and categories
  setup      Installs dependencies needed for your system.
```

Wystarczy sklonować repozytorium, zainstalować zależności poleceniem `./run setup` i możesz zaczynać!

## 🤔 Pytania? Problemy? Sugestie?

### Uzyskaj pomoc – [Discord 💬](https://discord.gg/autogpt)

[![Dołącz do nas na Discordzie](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

Aby zgłosić błąd lub zaproponować nową funkcję, utwórz [zgłoszenie na GitHubie](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose). Upewnij się, że ktoś nie zgłosił już podobnego tematu.

## 🤝 Projekty siostrzane

### 🔄 Agent Protocol

Aby utrzymać jednolity standard i zapewnić bezproblemową kompatybilność z wieloma obecnymi i przyszłymi aplikacjami, AutoGPT wykorzystuje standard [agent protocol](https://agentprotocol.ai/) stworzony przez AI Engineer Foundation. Standaryzuje to ścieżki komunikacji od Twojego agenta do frontend i benchmarku.

---

## Statystyki gwiazdek

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>


## ⚡ Współtwórcy

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="View Contributors">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Contributors" />
</a>


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://getcore.me">
    <img width="200px" alt="CORE logo" src="https://github.com/user-attachments/assets/bd4e5e79-05b8-4d40-9aff-f1cf9e5d70de" />
  </a>

# Twój osobisty AI OS.

**Uruchom swój system operacyjny.** Obserwuje Twoją pracę. Zapamiętuje to, co ważne. Działa we wszystkich Twoich narzędziach i agentach. Open source, do samodzielnego hostowania, na zawsze Twój.

<p align="center">
    <a href="https://getcore.me">
        <img src="https://img.shields.io/badge/Website-getcore.me-c15e50?style=for-the-badge&logo=safari&logoColor=white" alt="Strona internetowa" />
    </a>
    <a href="https://docs.getcore.me">
        <img src="https://img.shields.io/badge/Docs-docs.getcore.me-22C55E?style=for-the-badge&logo=readthedocs&logoColor=white" alt="Dokumentacja" />
    </a>
    <a href="https://discord.gg/YGUZcvDjUa">
        <img src="https://img.shields.io/badge/Discord-community-5865F2?style=for-the-badge&logo=discord&logoColor=white" alt="Discord" />
    </a>
    <a href="https://github.com/RedPlanetHQ/core/blob/main/LICENSE">
        <img src="https://img.shields.io/badge/License-AGPL%203.0-blue?style=for-the-badge" alt="Licencja: AGPL 3.0" />
    </a>
</p>
</div>

---

## Zobacz jak to działa

Obejrzyj, jak CORE wykonuje dwa zadania programistyczne od początku do końca:

[![CORE Demo](https://img.youtube.com/vi/7y_kt_UTYQs/maxresdefault.jpg)](https://www.youtube.com/watch?v=7y_kt_UTYQs)

---

## Czym jest CORE

CORE to otwartoźródłowa warstwa operacyjna dla pracy natywnej dla AI.

Wypisujesz, co trzeba zrobić, w notatniku. CORE pobiera zadanie, ładuje kontekst z pamięci i połączonych aplikacji, szkicuje plan, uruchamia odpowiedniego agenta przez gateway, radzi sobie z blokadami, gdzie to możliwe, i wraca, gdy potrzebna jest ocena człowieka.

To nie jest chatbot, którego musisz ciągle nakłaniać. To warstwa, która pamięta, koordynuje, działa i eskaluje.

### Architektura

| | |
|---|---|
| **Obserwuje** | Kontekst z Twoich rozmów AI przez MCP, 50+ połączonych aplikacji oraz na Macu – dowolną aplikację, której jawnie udzielisz dostępu. |
| **Pamięta** | Graf wiedzy, który śledzi nie tylko, co powiedziałeś, ale także co zdecydowałeś, kiedy i dlaczego, w każdym narzędziu i rozmowie. |
| **Działa** | Podejmuje bezpośrednie działania w połączonych aplikacjach i deleguje dłuższą pracę agentom kodującym oraz przeglądarkowym przez gateway. |
| **Polityki** | Ścieżki zatwierdzania, zasady eskalacji, plany i logi audytowe, aby autonomia była rozliczalna. |

CORE decyduje, co może zrobić bezpiecznie, pyta przed wrażliwymi działaniami i zostawia ślad do weryfikacji.

---

## CORE w praktyce

### Zdeleguj zadanie programistyczne, wróć do PR.

Powiedz CORE, co trzeba zrobić. Pobiera kontekst z repozytorium, aplikacji i pamięci, opracowuje plan, uruchamia sesję Claude Code lub Codex, radzi sobie z przeszkodami, gdy może, i przynosi PR. Ty oceniasz, gdy skończy.

`[ ] Napraw wyścig w przepływie checkout z problemu #312`

### Wyczyść backlog, gdy śpisz.

Ustaw cykliczne zadanie, aby pobierać z backlogu o określonej porze. CORE pracuje nad nim, gdy jesteś offline. Sprawne realizacje czekają rano na review. Zablokowane sesje wracają z konkretnym pytaniem, a nie zawieszoną kartą.

`[ ] Pracuj nad dzisiejszym backlogiem zaczynając o 23:00`

### Zbadaj alerty zanim staną się przerwami.

Ustaw cykliczne zadanie do obserwacji Sentry, logów lub dowolnego źródła alertów. Gdy coś się pojawi, CORE bada, pobiera powiązane ślady i wcześniejsze incydenty oraz decyduje, czy podjąć działanie, czy eskalować.

Alert Sentry pojawia się o 2:00. CORE bada, proponuje poprawkę i pingujesz Cię na Slacku do review.

### Poranny brief, który zna Twoją pracę.

Ustaw cykliczne zadanie, aby codziennie rano pobierać wiadomości z emaila, GitHub, Linear i Slack. CORE podsumowuje, co wymaga uwagi, pomija co nie, a follow-upy zamienia automatycznie w zadania.

### Deleguj skądkolwiek jesteś.

Twórz zadania z Slacka, WhatsApp, Telegrama, emaila lub weba. Gateway działa w Dockerze lub Railway, więc CORE może podjąć pracę nawet, gdy Twój laptop jest wyłączony.

---

## Co jest w środku CORE

| | |
|---|---|
| **Pamięć** | Śledzi Twoje preferencje, decyzje, cele i dyrektywy we wszystkich narzędziach i rozmowach, więc każde zadanie zaczyna się z załadowanym kontekstem. |
| **Zadania** | Jednorazowe lub cykliczne jednostki pracy ze specyfikacją, planem CORE, stanem na żywo i dedykowanym wątkiem czatu. Każde zadanie może uruchamiać sesje kodowania lub przeglądarki. |
| **Notatnik** | Codzienna strona na zadania, pomysły i prace w toku. Wpisz `[ ]` gdziekolwiek, a CORE wykryje to w ciągu 3 minut. |
| **Konektory** | Ponad 50 aplikacji przez jeden punkt MCP, plus wyzwalacze webhook do proaktywnej automatyzacji. GitHub, Linear, Jira, Slack, Gmail, Kalendarz, Sentry, Granola, Todoist i więcej. |
| **Umiejętności** | Ponad 100 wielokrotnego użytku instrukcji stosowanych automatycznie w zależności od kontekstu. Używaj wbudowanych umiejętności lub pisz własne do powtarzalnych procesów. |
| **Gateway** | Uruchamia Claude Code, Codex, agentów przeglądarki i polecenia lokalne na Twoim komputerze lub w Docker / Railway, więc CORE działa nawet po zamknięciu laptopa. |
| **Niezależny od modelu** | Wybierz własnego dostawcę: Anthropic, OpenAI lub modele open-weight. Samodzielnie hostuj cały stack dla izolacji. |

---

## Czym nie jest CORE

| | |
|---|---|
| **Nie jest opakowaniem RAG.** | Pamięć to nie tylko osadzone fragmenty. To graf wiedzy śledzący, co, kiedy i dlaczego zdecydowałeś. |
| **Nie jest kreatorem workflow.** | Bez drag-and-drop DAG. Piszesz, co trzeba zrobić. CORE ustala workflow i pyta, gdy potrzebuje decyzji. |
| **Nie jest kolejnym Devinem.** | CORE proponuje plany, Ty zatwierdzasz. CORE pyta o odblokowanie, Ty decydujesz. CORE przynosi PR, Ty przeglądasz. Agenci nie scalają sami. |
| **Nie jest zamkniętym asystentem chmurowym.** | CORE jest open source, możliwy do samodzielnego hostowania, niezależny od modelu i zaprojektowany pod Twoją infrastrukturę. |

---

## Szybki start

Open source i samodzielny hosting. Twoje dane pozostają w Twojej infrastrukturze.

**Zainstaluj i uruchom CORE:**

```bash
npm install -g @redplanethq/corebrain && corebrain setup
```

Kreator instalacji pyta o katalog instalacyjny, dostawcę AI, klucz API oraz model czatu. Generuje tajne dane, uruchamia stack i otwiera `http://localhost:3033`.

Większość lokalnych instalacji trwa kilka minut po uruchomieniu Dockera.

**Lub wdroż na Railway:**

[![Deploy on Railway](https://railway.app/button.svg)](https://railway.com/deploy/core)

**Podłącz bramę**, aby CORE mógł obsługiwać Twoją przeglądarkę, uruchamiać agentów kodowania i uzyskiwać dostęp do lokalnych folderów:

```bash
corebrain login
corebrain gateway setup
```

**Wymagania:** Docker 20.10+, Docker Compose 2.20+, 4 vCPU / 8GB RAM

[Pełny przewodnik po samodzielnym hostowaniu](https://docs.getcore.me/self-hosting/setup)

> Chcesz aplikację na Maca? Dołącz do listy oczekujących na [getcore.me](https://www.getcore.me/).

---

## Benchmark

CORE osiąga **88,24%** średniej dokładności w [benchmarku LoCoMo](https://github.com/RedPlanetHQ/core-benchmark) w zakresie pojedynczych i wieloetapowych zadań, otwartych domen i rozumowania czasowego.

---

## W co wierzymy

- Chat to interfejs. Nie system operacyjny.
- Inteligencja bez pamięci to ciekawostka.
- Twoja SI powinna znać Cię we wszystkich narzędziach, nie tylko w bieżącej karcie.
- Praca powinna przechodzić od intencji do działania bez Twojego udziału jako spoiwa.
- Automatyzacja bez odpowiedzialności to chaos.

---

## Dokumentacja

- [**Pamięć**](https://docs.getcore.me/memory/overview) – Graf wiedzy temporalnej, klasyfikacja faktów, wyszukiwanie na podstawie intencji
- [**Notatnik**](https://docs.getcore.me/concepts/scratchpad) – Codzienna przestrzeń, gdzie zaczynają się zadania i pomysły
- [**Zadania**](https://docs.getcore.me/concepts/tasks) – Plany, stan, prace cykliczne i kontekst związany z zadaniem
- [**Toolkit**](https://docs.getcore.me/concepts/toolkit) – Ponad 1000 akcji w 50+ aplikacjach przez MCP
- [**Agent CORE**](https://docs.getcore.me/concepts/meta-agent) – Wyzwalacze, pamięć, narzędzia i wykonanie
- [**Gateway**](https://docs.getcore.me/access-core/overview) – Dostęp przez WhatsApp, Slack, Telegram, e-mail, web i API
- [**Umiejętności**](https://docs.getcore.me/skills/overview) – Wielokrotnego użytku instrukcje do powtarzalnych procesów
- [**Samodzielny hosting**](https://docs.getcore.me/self-hosting/setup) – Pełny przewodnik wdrożenia
- [**Changelog**](https://docs.getcore.me/opensource/changelog) – Wysłane aktualizacje

---

## Bezpieczeństwo
- Certyfikat CASA Tier 2
- TLS 1.3 podczas transmisji
- AES-256 w spoczynku
- Twoje dane nigdy nie są używane do trenowania modeli
- Samodzielny hosting dla pełnej izolacji
- [Polityka bezpieczeństwa](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)
- Luki w zabezpieczeniach: harshith@poozle.dev

---

## Społeczność

Budujemy CORE publicznie.

Dzielimy się roadmapą i decyzjami architektonicznymi otwarcie, ponieważ najtrudniejsze problemy przy budowie osobistego systemu operacyjnego najlepiej rozwiązywać z jego użytkownikami. Oznacz repozytorium gwiazdką, uruchom je samodzielnie, podziel się tym, co zbudujesz, i zgłaszaj błędy lub braki.

- [Discord](https://discord.gg/YGUZcvDjUa) - pytania, pomysły, prezentacje
- [Dokumentacja dla współtwórców](https://docs.getcore.me/opensource/contributing) - jak dołączyć do CORE
- [`good-first-issue`](https://github.com/RedPlanetHQ/core/labels/good-first-issue) - zacznij tutaj

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>

---

<div align="center">

**Uruchom swój osobisty AI OS samodzielnie.**

[Oznacz repozytorium gwiazdką](https://github.com/RedPlanetHQ/core) · [Przeczytaj dokumentację](https://docs.getcore.me) · [Dołącz do Discorda](https://discord.gg/YGUZcvDjUa)

</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---
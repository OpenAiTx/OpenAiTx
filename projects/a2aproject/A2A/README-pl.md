# Protokół Agent2Agent (A2A)

[![PyPI - Wersja](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Licencja Apache](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Zapytaj Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 Język</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>Agent2Agent (A2A) Protocol</h1>
  </div>
</div>

**Otwarty protokół umożliwiający komunikację i interoperacyjność między nieprzejrzystymi aplikacjami agentowymi.**

Protokół Agent2Agent (A2A) rozwiązuje kluczowe wyzwanie w dziedzinie AI: umożliwienie agentom generatywnym AI, zbudowanym na różnych frameworkach przez różne firmy i działającym na oddzielnych serwerach, skutecznej komunikacji i współpracy – jako agenci, a nie tylko narzędzia. Celem A2A jest dostarczenie wspólnego języka dla agentów, wspierając bardziej połączony, potężny i innowacyjny ekosystem AI.

Dzięki A2A agenci mogą:

- Odkrywać wzajemne możliwości.
- Negocjować sposoby interakcji (tekst, formularze, multimedia).
- Bezpiecznie współpracować przy długotrwałych zadaniach.
- Działać bez ujawniania swojego stanu wewnętrznego, pamięci ani narzędzi.

## Kurs DeepLearning.AI

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

Dołącz do krótkiego kursu [A2A: The Agent2Agent Protocol](https://goo.gle/dlai-a2a), stworzonego we współpracy z Google Cloud i IBM Research, prowadzonego przez [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini) i [Sandi Besen](https://github.com/sandijean90).

**Czego się nauczysz:**

- **Zgodność agentów z A2A:** Udostępnij agentów zbudowanych w frameworkach takich jak Google ADK, LangGraph czy BeeAI jako serwery A2A.
- **Łączenie agentów:** Twórz klientów A2A od podstaw lub używając integracji do łączenia się z agentami zgodnymi z A2A.
- **Orkiestracja workflow:** Buduj sekwencyjne i hierarchiczne workflow agentów zgodnych z A2A.
- **Systemy multi-agentowe:** Stwórz system opieki zdrowotnej z udziałem wielu agentów, korzystając z różnych frameworków i zobacz, jak A2A umożliwia współpracę.
- **A2A i MCP:** Dowiedz się, jak A2A uzupełnia MCP, umożliwiając agentom wzajemną współpracę.

## Dlaczego A2A?

Wraz ze wzrostem popularności agentów AI, ich zdolność do współdziałania jest kluczowa dla tworzenia złożonych, wielofunkcyjnych aplikacji. Celem A2A jest:

- **Likwidacja silosów:** Łączenie agentów z różnych ekosystemów.
- **Umożliwienie złożonej współpracy:** Pozwól wyspecjalizowanym agentom współpracować nad zadaniami, których pojedynczy agent nie jest w stanie zrealizować samodzielnie.
- **Promowanie otwartych standardów:** Budowanie komunikacji agentów w oparciu o społeczność, wspierając innowacje i szeroką adopcję.
- **Zachowanie nieprzejrzystości:** Pozwól agentom na współpracę bez konieczności dzielenia się pamięcią wewnętrzną, logiką zastrzeżoną czy implementacją narzędzi, co zwiększa bezpieczeństwo i chroni własność intelektualną.

### Kluczowe funkcje

- **Standaryzowana komunikacja:** JSON-RPC 2.0 przez HTTP(S).
- **Odkrywanie agentów:** Za pomocą "Kart Agenta" zawierających informacje o możliwościach i połączeniu.
- **Elastyczna interakcja:** Obsługuje synchroniczne zapytania/odpowiedzi, streaming (SSE) oraz asynchroniczne powiadomienia push.
- **Bogata wymiana danych:** Obsługuje tekst, pliki oraz strukturalne dane JSON.
- **Gotowy dla przedsiębiorstw:** Zaprojektowany z myślą o bezpieczeństwie, uwierzytelnianiu i obserwowalności.

## Rozpoczęcie pracy

- 📚 **Przeglądaj dokumentację:** Odwiedź [Stronę Dokumentacji Protokołu Agent2Agent](https://a2a-protocol.org) aby uzyskać pełny przegląd, kompletną specyfikację protokołu, samouczki i przewodniki.
- 📝 **Zobacz specyfikację:** [Specyfikacja protokołu A2A](https://a2a-protocol.org/latest/specification/)
- Użyj SDK:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) używając maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) używając [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 Skorzystaj z naszych [przykładów](https://github.com/a2aproject/a2a-samples), aby zobaczyć A2A w akcji

## Współpraca

Zapraszamy do współtworzenia i rozwoju protokołu A2A przez społeczność!

- **Pytania i dyskusje:** Dołącz do naszych [Dyskusji na GitHub](https://github.com/a2aproject/A2A/discussions).
- **Zgłoszenia i opinie:** Zgłaszaj problemy lub proponuj ulepszenia przez [Zgłoszenia GitHub](https://github.com/a2aproject/A2A/issues).
- **Przewodnik współpracy:** Zobacz nasz [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) po szczegóły dotyczące współpracy.
- **Prywatna opinia:** Skorzystaj z [Google Form](https://goo.gle/a2a-feedback).
- **Program partnerski:** Klienci Google Cloud mogą dołączyć do programu partnerskiego przez ten [formularz](https://goo.gle/a2a-partner).

## Co dalej

### Ulepszenia protokołu

- **Odkrywanie agentów:**
    - Sformalizować włączenie schematów autoryzacji i opcjonalnych danych uwierzytelniających bezpośrednio w `AgentCard`.
- **Współpraca agentów:**
    - Zbadać metodę `QuerySkill()` do dynamicznego sprawdzania nieobsługiwanych lub nieoczekiwanych umiejętności.
- **Cykl życia zadania i UX:**
    - Wsparcie dla dynamicznego negocjowania UX _w trakcie_ zadania (np. agent dodający audio/wideo w trakcie rozmowy).
- **Metody klienta i transport:**
    - Rozważenie rozszerzenia wsparcia na metody inicjowane przez klienta (poza zarządzaniem zadaniami).
    - Ulepszenia w niezawodności streamingu i mechanizmach powiadomień push.

## Informacje

Protokół A2A to projekt open source pod egidą Linux Foundation, współtworzony przez Google. Jest licencjonowany na [licencji Apache 2.0](LICENSE) i otwarty na wkład społeczności.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---
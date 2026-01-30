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

**Otwarty protokół umożliwiający komunikację i interoperacyjność między nieprzezroczystymi aplikacjami agentowymi.**

Protokół Agent2Agent (A2A) rozwiązuje kluczowe wyzwanie w dziedzinie AI: umożliwienie agentom generatywnym AI, zbudowanym na różnych frameworkach przez różne firmy i działającym na odrębnych serwerach, efektywną komunikację i współpracę - jako agenci, nie tylko jako narzędzia. Celem A2A jest zapewnienie wspólnego języka dla agentów, sprzyjając bardziej połączonemu, potężnemu i innowacyjnemu ekosystemowi AI.

Dzięki A2A agenci mogą:

- Odkrywać wzajemne możliwości.
- Negocjować tryby interakcji (tekst, formularze, multimedia).
- Bezpiecznie współpracować przy długotrwałych zadaniach.
- Działać bez ujawniania swojego stanu wewnętrznego, pamięci ani narzędzi.

## Wideo Wprowadzenie do A2A

[![A2A Intro Video](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## Dlaczego A2A?

W miarę jak agenci AI stają się coraz bardziej powszechni, ich zdolność do współdziałania jest kluczowa dla budowania złożonych, wielofunkcyjnych aplikacji. Celem A2A jest:

- **Przełamywanie Silosów:** Łączenie agentów w różnych ekosystemach.
- **Umożliwienie Złożonej Współpracy:** Pozwalanie wyspecjalizowanym agentom na wspólne wykonywanie zadań, których pojedynczy agent nie jest w stanie obsłużyć.
- **Promowanie Otwartych Standardów:** Wspieranie podejścia społecznościowego do komunikacji agentów, zachęcanie do innowacji i szerokiego zastosowania.
- **Zachowanie Nieprzezroczystości:** Umożliwienie współpracy agentów bez konieczności udostępniania pamięci wewnętrznej, logiki własnościowej czy konkretnych implementacji narzędzi, zwiększając bezpieczeństwo i chroniąc własność intelektualną.

### Kluczowe Funkcje

- **Standaryzowana komunikacja:** JSON-RPC 2.0 przez HTTP(S).
- **Odkrywanie agentów:** Poprzez „Karty Agenta” opisujące możliwości i informacje połączeniowe.
- **Elastyczna interakcja:** Obsługuje synchroniczne żądania/odpowiedzi, strumieniowanie (SSE) oraz asynchroniczne powiadomienia push.
- **Bogata wymiana danych:** Obsługuje tekst, pliki i strukturalne dane JSON.
- **Gotowy dla biznesu:** Zaprojektowany z myślą o bezpieczeństwie, uwierzytelnianiu i obserwowalności.

## Pierwsze kroki

- 📚 **Przeglądaj dokumentację:** Odwiedź [Stronę Dokumentacji Protokołu Agent2Agent](https://a2a-protocol.org), aby uzyskać pełny przegląd, kompletną specyfikację protokołu, samouczki i przewodniki.
- 📝 **Zobacz specyfikację:** [Specyfikacja protokołu A2A](https://a2a-protocol.org/latest/specification/)
- Skorzystaj z SDK:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) używając maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) używając [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Skorzystaj z naszych [przykładów](https://github.com/a2aproject/a2a-samples), aby zobaczyć A2A w akcji

## Współtworzenie

Zapraszamy do współtworzenia i rozwijania protokołu A2A przez społeczność!

- **Pytania i dyskusje:** Dołącz do naszych [dyskusji na GitHubie](https://github.com/a2aproject/A2A/discussions).
- **Problemy i opinie:** Zgłaszaj problemy lub sugestie poprawek przez [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Przewodnik dla kontrybutorów:** Sprawdź [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md), aby dowiedzieć się, jak współtworzyć projekt.
- **Prywatna opinia:** Skorzystaj z [formularza Google](https://goo.gle/a2a-feedback).
- **Program partnerski:** Klienci Google Cloud mogą dołączyć do programu partnerskiego przez ten [formularz](https://goo.gle/a2a-partner).

## Co dalej

### Ulepszenia protokołu

- **Odnajdywanie agentów:**
    - Formalizacja uwzględniania schematów autoryzacji oraz opcjonalnych poświadczeń bezpośrednio w `AgentCard`.
- **Współpraca agentów:**
    - Badanie metody `QuerySkill()` do dynamicznego sprawdzania nieobsługiwanych lub nieprzewidzianych umiejętności.
- **Cykl życia zadania i UX:**
    - Wsparcie dla dynamicznej negocjacji UX _w ramach_ zadania (np. agent dodaje audio/wideo w trakcie rozmowy).
- **Metody klienta i transport:**
    - Rozważenie rozszerzenia wsparcia dla metod inicjowanych przez klienta (poza zarządzaniem zadaniami).
    - Ulepszenia niezawodności strumieniowania oraz mechanizmów powiadomień push.

## O projekcie

Protokół A2A jest projektem open source pod egidą Linux Foundation, z kontrybucją Google. Licencjonowany jest na [licencji Apache 2.0](LICENSE) i otwarty na współtworzenie przez społeczność.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---
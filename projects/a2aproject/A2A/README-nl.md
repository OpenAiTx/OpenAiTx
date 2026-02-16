# Agent2Agent (A2A) Protocol

[![PyPI - Versie](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache Licentie](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Vraag Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 Taal</summary>
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

**Een open protocol dat communicatie en interoperabiliteit tussen ondoorzichtige agent-applicaties mogelijk maakt.**

Het Agent2Agent (A2A) protocol pakt een cruciale uitdaging aan in het AI-landschap: het mogelijk maken dat gen AI-agenten, gebouwd op diverse frameworks door verschillende bedrijven op aparte servers, effectief kunnen communiceren en samenwerken - als agenten, niet slechts als tools. A2A biedt een gemeenschappelijke taal voor agenten en stimuleert zo een meer verbonden, krachtig en innovatief AI-ecosysteem.

Met A2A kunnen agenten:

- Elkaars mogelijkheden ontdekken.
- Interactie-modaliteiten onderhandelen (tekst, formulieren, media).
- Veilig samenwerken aan langdurige taken.
- Opereren zonder hun interne status, geheugen of tools bloot te geven.

## DeepLearning.AI Cursus

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

Doe mee aan deze korte cursus over [A2A: Het Agent2Agent Protocol](https://goo.gle/dlai-a2a), ontwikkeld in samenwerking met Google Cloud en IBM Research, en gegeven door [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini), en [Sandi Besen](https://github.com/sandijean90).

**Wat je zult leren:**

- **Maak agenten A2A-compatibel:** Stel agenten gebouwd met frameworks zoals Google ADK, LangGraph of BeeAI beschikbaar als A2A-servers.
- **Verbind agenten:** Maak A2A-clients vanaf nul of met integraties om verbinding te maken met A2A-compatibele agenten.
- **Orkestreer workflows:** Bouw sequentiële en hiërarchische workflows van A2A-compatibele agenten.
- **Multi-agent systemen:** Bouw een multi-agent systeem voor de gezondheidszorg met verschillende frameworks en zie hoe A2A samenwerking mogelijk maakt.
- **A2A en MCP:** Leer hoe A2A MCP aanvult door agenten in staat te stellen samen te werken.

## Waarom A2A?

Naarmate AI-agenten steeds vaker voorkomen, is hun vermogen om samen te werken cruciaal voor het bouwen van complexe, multifunctionele applicaties. A2A heeft als doel om:

- **Barrières afbreken:** Verbind agenten over verschillende ecosystemen heen.
- **Complexe samenwerking mogelijk maken:** Laat gespecialiseerde agenten samenwerken aan taken die één agent alleen niet aankan.
- **Open standaarden bevorderen:** Stimuleer een door de gemeenschap gedreven benadering van agent-communicatie, wat innovatie en brede adoptie aanmoedigt.
- **Ondoorzichtigheid behouden:** Sta agenten toe samen te werken zonder interne geheugen, eigendomslogica of specifieke tool-implementaties te delen, wat de veiligheid verhoogt en intellectueel eigendom beschermt.

### Belangrijkste Kenmerken

- **Gestandaardiseerde Communicatie:** JSON-RPC 2.0 over HTTP(S).
- **Agent Ontdekking:** Via "Agent Cards" met details over mogelijkheden en verbindingsinformatie.
- **Flexibele Interactie:** Ondersteunt synchrone request/response, streaming (SSE) en asynchrone push-notificaties.
- **Rijke Data-uitwisseling:** Verwerkt tekst, bestanden en gestructureerde JSON-data.
- **Enterprise-Ready:** Ontworpen met veiligheid, authenticatie en observability in gedachten.

## Aan de slag

- 📚 **Verken de Documentatie:** Bezoek de [Agent2Agent Protocol Documentatie Site](https://a2a-protocol.org) voor een compleet overzicht, de volledige protocol specificatie, tutorials en handleidingen.
- 📝 **Bekijk de Specificatie:** [A2A Protocol Specificatie](https://a2a-protocol.org/latest/specification/)
- Gebruik de SDK's:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) met maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) via [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Gebruik onze [voorbeelden](https://github.com/a2aproject/a2a-samples) om A2A in actie te zien

## Bijdragen

We verwelkomen bijdragen van de community om het A2A protocol te verbeteren en verder te ontwikkelen!

- **Vragen & Discussies:** Neem deel aan onze [GitHub Discussies](https://github.com/a2aproject/A2A/discussions).
- **Issues & Feedback:** Meld problemen of stel verbeteringen voor via [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Bijdragegids:** Zie onze [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) voor details over hoe je kunt bijdragen.
- **Privé Feedback:** Gebruik dit [Google Formulier](https://goo.gle/a2a-feedback).
- **Partnerprogramma:** Google Cloud klanten kunnen deelnemen aan ons partnerprogramma via dit [formulier](https://goo.gle/a2a-partner).

## Wat is de volgende stap

### Protocol Verbeteringen

- **Agent Ontdekking:**
    - Formaliseer de opname van autorisatieschema's en optionele credentials direct in de `AgentCard`.
- **Agent Samenwerking:**
    - Onderzoek een `QuerySkill()` methode voor het dynamisch controleren van niet-ondersteunde of onverwachte vaardigheden.
- **Taak Lifecycle & UX:**
    - Ondersteuning voor dynamische UX-onderhandeling _binnen_ een taak (bijv. agent voegt audio/video toe tijdens een gesprek).
- **Clientmethoden & Transport:**
    - Onderzoek naar uitbreiding van ondersteuning voor door de client geïnitieerde methoden (naast taakbeheer).
    - Verbeteringen in de betrouwbaarheid van streaming en pushmeldingsmechanismen.

## Over

Het A2A-protocol is een open source-project onder de Linux Foundation, bijgedragen door Google. Het is gelicentieerd onder de [Apache License 2.0](LICENSE) en staat open voor bijdragen van de community.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---
# Agent2Agent (A2A) Voorbeelden

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Probeer in Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 Taal</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
    </div>
  </details>
</div>

Welkom bij de officiële codevoorbeelden en demonstraties voor het [Agent2Agent (A2A) Protocol](https://goo.gle/a2a).

Wij zijn verheugd u hier te mogen verwelkomen! Of u nu voor het eerst multi-agent architecturen verkent of geavanceerde interoperabele agentnetwerken bouwt, deze repository biedt eenvoudige, inspirerende en toegankelijke leermiddelen om uw ontwikkeling te versnellen.

## Waarom Agent2Agent?

In een wereld van diverse AI-frameworks en ecosystemen hebben agents een gemeenschappelijke taal nodig om veilig te communiceren, samenwerken en taken te delegeren. Het A2A-protocol biedt een gestandaardiseerde, open standaard voor multi-agent interoperabiliteit.

Onze voorbeelden tonen aan hoe eenvoudig complexe multi-agent problemen opgelost kunnen worden, ongeacht verschillende talen en hosttoepassingen.

## Snel starten

Ga direct aan de slag door een Helloworld-agent te starten en ermee te communiceren via onze Python CLI-host.

1. **Start de Agent Server**:
   Open een terminal en start de Helloworld agent server:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **Start de Host Client**:
   Open een tweede terminal en start de CLI-client om een taak naar de agent te sturen:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## Repositorystructuur

De repository is georganiseerd in verschillende hoofd directories per programmeertaal:

| Directory | Beschrijving |
| --- | --- |
| [samples](/samples) | Kern A2A voorbeelden georganiseerd per programmeertaal. |
| [samples/python](/samples/python) | Demonstreert Python agent-implementaties met behulp van de A2A Python SDK. |
| [samples/go](/samples/go) | Demonstreert Go agent-implementaties met behulp van de A2A Go SDK. |
| [samples/dotnet](/samples/dotnet) | Demonstreert C# agent-implementaties met behulp van de A2A .NET SDK. |
| [samples/java](/samples/java) | Demonstreert Java agent-implementaties met behulp van de A2A Java SDK. |
| [samples/js](/samples/js) | Demonstreert Node.js agent-implementaties met behulp van de A2A JavaScript SDK. |

## Bijdragen

Wij verwelkomen en moedigen bijdragen aan van alle niveaus! Heb je een idee voor een nieuw voorbeeld, een bugfix of een verbetering in de documentatie, bekijk dan onze [Contributie Gids](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Hulp Nodig

Wij zetten ons in voor een gastvrije en ondersteunende community. Heb je vragen, feedback of loop je ergens tegenaan, neem dan contact op via onze [issues pagina](https://github.com/a2aproject/a2a-samples/issues).

## Gerelateerde Repositories

| Repository | Categorie | Beschrijving |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | Kern Specificatie | A2A Specificatie en documentatie. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | Tools | UI-tool voor het inspecteren van A2A-enabled agents. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | Testen | Test suite voor het valideren van A2A Protocol compliance. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | Testen | Toolkit om compatibiliteit te verifiëren tussen verschillende A2A SDK-implementaties en versies met behulp van multi-hop traversal model en diverse transportprotocollen. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | Officiële Python SDK voor A2A. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | Officiële Go SDK voor A2A. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | Officiële Java SDK voor A2A. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | Officiële Node.js/JavaScript SDK voor A2A. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | Officiële C#/.NET SDK voor A2A. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | Officiële Rust SDK voor A2A. |

## Disclaimer

**Belangrijk:** De meegeleverde voorbeeldcode is uitsluitend bedoeld ter demonstratie en illustreert de werking van de
Agent-to-Agent (A2A) protocol. Bij het bouwen van productieapplicaties is het cruciaal om elke agent
die buiten je directe controle opereert te behandelen als een mogelijk niet-vertrouwd entiteit.

Alle gegevens die van een externe agent worden ontvangen—including maar niet beperkt tot zijn AgentCard, berichten,
artefacten en taakstatussen—moeten worden behandeld als niet-vertrouwde input. Bijvoorbeeld, een kwaadwillende agent
kan een AgentCard leveren met gemanipuleerde gegevens in zijn velden (bijv. beschrijving, naam,
skills.beschrijving). Als deze gegevens zonder sanering worden gebruikt om prompts voor een Large
Language Model (LLM) te construeren, kan dit je applicatie blootstellen aan prompt injection attacks. Het niet
correct valideren en saneren van deze gegevens vóór gebruik kan beveiligingslekken in je
applicatie introduceren.

> Ontwikkelaars zijn verantwoordelijk voor het implementeren van geschikte beveiligingsmaatregelen, zoals inputvalidatie
> en veilige omgang met credentials om hun systemen en gebruikers te beschermen.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---
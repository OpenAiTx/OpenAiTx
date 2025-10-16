<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE-Logo" />
  </a>

### CORE: Ihre persönliche Gedächtnisschicht für KI-Anwendungen

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki-Abzeichen" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>Dokumentation</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 Forschungshighlights

CORE Memory erreicht **88,24%** durchschnittliche Genauigkeit im Locomo-Datensatz über alle Reasoning-Aufgaben und übertrifft damit andere Speicheranbieter deutlich. Schau dir diesen [Blog](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/) für weitere Informationen an.

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) Single-hop-Fragen erfordern Antworten, die auf einer einzelnen Sitzung basieren; (2) Multi-hop-Fragen erfordern die Synthese von Informationen aus mehreren verschiedenen Sitzungen; (3) Open-Domain-Wissensfragen können beantwortet werden, indem die vom Sprecher bereitgestellten Informationen mit externem Wissen wie Allgemeinwissen oder Weltfakten kombiniert werden; (4) Temporale Reasoning-Fragen können durch zeitliches Schlussfolgern und Erfassung zeitbezogener Datenhinweise innerhalb des Gesprächs beantwortet werden;

## Überblick

**Problem** 

Entwickler verschwenden Zeit damit, KI-Tools den Kontext immer wieder neu zu erklären. Token-Limit bei Claude erreicht? Von vorne anfangen und alles verlieren. Wechselst du von ChatGPT/Claude zu Cursor? Erkläre deinen Kontext erneut. Deine Gespräche, Entscheidungen und Erkenntnisse verschwinden zwischen den Sitzungen. Mit jedem neuen KI-Tool steigen die Kosten des Kontextwechsels.

**Lösung** - **CORE** (**Contextual Observation & Recall Engine**)

CORE ist eine quelloffene, einheitliche und persistente Memory-Schicht für all deine KI-Tools. Dein Kontext folgt dir von Cursor zu Claude zu ChatGPT zu Claude Code. Ein Wissensgraph merkt sich, wer was, wann und warum gesagt hat. Einmal verbinden, überall erinnern. Höre auf, Kontext zu verwalten, und fang an zu bauen.

## 🚀 CORE Selbst-Hosting
Möchtest du CORE auf deiner eigenen Infrastruktur betreiben? Selbst-Hosting gibt dir vollständige Kontrolle über deine Daten und die Bereitstellung.

**Voraussetzungen**:

- Docker (20.10.0+) und Docker Compose (2.20.0+) installiert
- OpenAI API-Schlüssel

> **Hinweis zu Open-Source-Modellen:** Wir haben OSS-Optionen wie Ollama und GPT-Modelle getestet, aber deren Faktenerkennung und Graphqualität waren unzureichend. Wir suchen aktiv nach Alternativen.

### Einrichtung

1. Klone das Repository:
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. Konfigurieren Sie Umgebungsvariablen in `core/.env`:
```
OPENAI_API_KEY=your_openai_api_key
```
3. Starten Sie den Dienst
```
docker-compose up -d
```

Nach der Bereitstellung kannst du deine KI-Anbieter (OpenAI, Anthropic) konfigurieren und mit dem Aufbau deines Memory-Graphen beginnen.

👉 [Vollständige Self-Hosting-Anleitung ansehen](https://docs.heysol.ai/self-hosting/docker)

Hinweis: Wir haben Open-Source-Modelle wie Ollama oder GPT OSS ausprobiert, aber die Faktengenerierung war nicht gut. Wir versuchen weiterhin, dies zu verbessern, und werden dann auch OSS-Modelle unterstützen.

## 🚀 CORE Cloud
**Erstelle deinen einheitlichen Memory-Graph in 5 Minuten:**

Du möchtest keine Infrastruktur verwalten? Mit CORE Cloud kannst du dein persönliches Memory-System sofort aufbauen – keine Einrichtung, keine Server, einfach funktionierende Erinnerung.

1. **Registriere dich** auf [core.heysol.ai](https://core.heysol.ai) und erstelle dein Konto
2. **Visualisiere deinen Memory-Graphen** und sieh, wie CORE automatisch Verbindungen zwischen Fakten herstellt
3. **Teste es aus** – frage "Was weißt du über mich?" im Konversationsbereich
4. Verbinde deine Tools:
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) – Programmieren mit Kontext
   - [Claude Code CLI](https://docs.heysol.ai/providers/claude-code) & [Codex CLI](https://docs.heysol.ai/providers/codex) – Terminal-basiertes Programmieren mit Memory
   - [Browser-Erweiterung hinzufügen](https://docs.heysol.ai/providers/browser-extension) – bring deine Erinnerung auf jede Webseite
   - [Linear](https://docs.heysol.ai/integrations/linear), [Github](https://docs.heysol.ai/integrations/github) – Projektkontext automatisch hinzufügen

## 🧩 Hauptfunktionen

### 🧠 **Vereinheitlichte, tragbare Erinnerung**: 
Füge deine Erinnerungen hinzu und rufe sie ab über **Cursor, Windsurf, Claude Desktop, Claude Code, Gemini CLI, AWS's Kiro, VS Code und Roo Code** via MCP

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **Temporaler + Reifizierter Wissensgraph**: 

Erinnere dich an die Geschichte hinter jedem Fakt – verfolge, wer was, wann und warum gesagt hat, mit reichen Beziehungen und vollständiger Herkunft, nicht nur flache Speicherung

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **Browser-Erweiterung**: 

Speichere Gespräche und Inhalte von ChatGPT, Grok, Gemini, Twitter, YouTube, Blogposts und jeder Webseite direkt in deinem CORE Memory.

**So verwenden Sie die Erweiterung**
1. [Laden Sie die Erweiterung herunter](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) aus dem Chrome Web Store.
2. Melden Sie sich beim [CORE-Dashboard](https://core.heysol.ai) an
   - Navigieren Sie zu Einstellungen (unten links)
   - Gehen Sie zu API-Schlüssel → Neuen Schlüssel generieren → Benennen Sie ihn „extension“.
3. Öffnen Sie die Erweiterung, fügen Sie Ihren API-Schlüssel ein und speichern Sie ihn.

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **Chatten mit Memory**: 
Stellen Sie Fragen wie „Was sind meine Schreibpräferenzen?“ und erhalten Sie sofort Einblicke aus Ihrem verbundenen Wissen

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **Automatische Synchronisierung aus Apps**:

Erfassen Sie automatisch relevante Kontexte aus Linear, Slack, Notion, GitHub und anderen verbundenen Apps in Ihrem CORE-Speicher

📖 **[Alle Integrationen anzeigen](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** – Vollständige Liste der unterstützten Dienste und deren Funktionen

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCP-Integrations-Hub**: 

Verbinden Sie Linear, Slack, GitHub, Notion einmal mit CORE—nutzen Sie dann alle deren Tools in Claude, Cursor oder jedem MCP-Client mit einer einzigen URL


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## Wie CORE Speicher erstellt

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

COREs Ingestion-Pipeline besteht aus vier Phasen, die darauf ausgelegt sind, sich entwickelnde Kontexte zu erfassen:

1. **Normalisierung**: Verknüpft neue Informationen mit dem aktuellen Kontext, zerlegt lange Dokumente in kohärente Abschnitte und hält Querverweise bei, standardisiert Begriffe, sodass CORE beim Extrahieren von Wissen mit sauberem, kontextualisiertem Input arbeitet statt mit chaotischem Text.
2. **Extraktion**: Zieht Bedeutung aus normalisiertem Text, indem es Entitäten (Personen, Werkzeuge, Projekte, Konzepte) identifiziert, sie in Aussagen mit Kontext, Quelle und Zeit verwandelt und Beziehungen abbildet. Zum Beispiel wird „Wir haben CORE in Next.js geschrieben“ zu: Entitäten (Core, Next.js), Aussage (CORE wurde mit Next.js entwickelt), und Beziehung (wurde entwickelt mit).
3. **Auflösung**: Erkennt Widersprüche, verfolgt, wie sich Präferenzen entwickeln, und bewahrt mehrere Perspektiven samt Herkunft, statt sie zu überschreiben, damit der Speicher deine gesamte Reise widerspiegelt und nicht nur den letzten Stand.
4. **Graph-Integration**: Verbindet Entitäten, Aussagen und Episoden in einem zeitlichen Wissensgraphen, der Fakten mit ihrem Kontext und ihrer Historie verknüpft und so isolierte Daten in ein lebendiges Wissensnetz verwandelt, das Agenten tatsächlich nutzen können.

Das Ergebnis: Statt einer flachen Datenbank bietet CORE ein Gedächtnis, das mit dir wächst und sich verändert – bewahrt Kontext, Entwicklung und Eigentum, sodass Agenten es wirklich nutzen können.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## Wie CORE aus dem Speicher abruft

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

Wenn du CORE eine Frage stellst, sucht es nicht nur Text – es durchsucht deinen gesamten Wissensgraphen, um die nützlichsten Antworten zu finden.

1. **Suche**: CORE durchsucht den Speicher gleichzeitig aus verschiedenen Perspektiven – Stichwortsuche für exakte Übereinstimmungen, semantische Suche für verwandte Ideen, auch wenn sie anders formuliert sind, und Graph-Durchlauf, um Verbindungen zwischen Konzepten zu verfolgen.
2. **Neu-Rangierung**: Die gefundenen Ergebnisse werden neu sortiert, um die relevantesten und vielfältigsten hervorzuheben, damit du nicht nur offensichtliche Treffer siehst, sondern auch tiefere Zusammenhänge.
3. **Filterung**: CORE setzt intelligente Filter ein, basierend auf Zeit, Zuverlässigkeit und Beziehungsstärke, sodass nur das bedeutsamste Wissen angezeigt wird.
4. **Ausgabe**: Du erhältst sowohl Fakten (klare Aussagen) als auch Episoden (den ursprünglichen Kontext), sodass der Abruf immer im Zusammenhang von Kontext, Zeit und Geschichte steht.

Das Ergebnis: CORE ruft nicht nur Fakten ab – es ruft sie im richtigen Kontext, zur passenden Zeit und in der Geschichte ab, sodass Agenten so reagieren können, wie du dich erinnern würdest.

## Dokumentation

Entdecke unsere Dokumentation, um das Beste aus CORE herauszuholen

- [Grundlagen](https://docs.heysol.ai/concepts/memory_graph)
- [Self Hosting](https://docs.heysol.ai/self-hosting/overview)
- [Core MCP mit Claude verbinden](https://docs.heysol.ai/providers/claude)
- [Core MCP mit Cursor verbinden](https://docs.heysol.ai/providers/cursor)
- [Core MCP mit Claude Code verbinden](https://docs.heysol.ai/providers/claude-code)
- [Core MCP mit Codex verbinden](https://docs.heysol.ai/providers/codex) 

- [Grundlagen](https://docs.heysol.ai/overview)
- [API Referenz](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 Sicherheit

CORE nimmt Sicherheit ernst. Wir setzen branchenübliche Sicherheitspraktiken ein, um deine Daten zu schützen:

- **Datenverschlüsselung**: Alle Daten während der Übertragung (TLS 1.3) und im Ruhezustand (AES-256)
- **Authentifizierung**: OAuth 2.0 und Magic-Link-Authentifizierung
- **Zugriffskontrolle**: Arbeitsbereich-basierte Isolierung und rollenbasierte Berechtigungen
- **Schwachstellenmeldung**: Bitte melden Sie Sicherheitsprobleme an harshith@poozle.dev

Für detaillierte Sicherheitsinformationen siehe unsere [Sicherheitsrichtlinie](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md).

## 🧑‍💻 Support

Haben Sie Fragen oder Feedback? Wir sind für Sie da:

- Discord: [Treten Sie dem core-support Kanal bei](https://discord.gg/YGUZcvDjUa)
- Dokumentation: [docs.heysol.ai](https://docs.heysol.ai)
- E-Mail: manik@poozle.dev

## Nutzungsrichtlinien

**Speichern:**

- Gesprächsverlauf
- Benutzereinstellungen
- Aufgaben-Kontext
- Referenzmaterialien

**Nicht speichern:**

- Sensible Daten (PII)
- Zugangsdaten
- Systemprotokolle
- Temporäre Daten

## 👥 Mitwirkende

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---
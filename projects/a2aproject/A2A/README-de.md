# Agent2Agent (A2A) Protokoll

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache Lizenz](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 Sprache</summary>
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
    <h1>Agent2Agent (A2A) Protokoll</h1>
  </div>
</div>

**Ein offenes Protokoll, das Kommunikation und Interoperabilität zwischen undurchsichtigen agentischen Anwendungen ermöglicht.**

Das Agent2Agent (A2A) Protokoll adressiert eine zentrale Herausforderung im KI-Bereich: Gen KI-Agenten, die auf unterschiedlichen Frameworks von verschiedenen Unternehmen auf separaten Servern laufen, effektiv kommunizieren und zusammenarbeiten zu lassen – als Agenten, nicht nur als Tools. A2A soll eine gemeinsame Sprache für Agenten bieten und damit ein vernetzteres, leistungsfähigeres und innovativeres KI-Ökosystem fördern.

Mit A2A können Agenten:

- Die Fähigkeiten anderer Agenten entdecken.
- Modalitäten der Interaktion verhandeln (Text, Formulare, Medien).
- Sicher an langlaufenden Aufgaben zusammenarbeiten.
- Ohne Offenlegung ihres internen Zustands, Gedächtnisses oder ihrer Tools agieren.

## DeepLearning.AI Kurs

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

Nehmen Sie an diesem kurzen Kurs zu [A2A: Das Agent2Agent Protokoll](https://goo.gle/dlai-a2a) teil, entwickelt in Partnerschaft mit Google Cloud und IBM Research und unterrichtet von [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini) und [Sandi Besen](https://github.com/sandijean90).

**Was Sie lernen werden:**

- **Agenten A2A-kompatibel machen:** Agenten, die mit Frameworks wie Google ADK, LangGraph oder BeeAI gebaut wurden, als A2A-Server bereitstellen.
- **Agenten verbinden:** A2A-Clients von Grund auf oder mit Integrationen erstellen, um A2A-kompatible Agenten zu verbinden.
- **Workflows orchestrieren:** Sequentielle und hierarchische Workflows aus A2A-kompatiblen Agenten bauen.
- **Multi-Agenten-Systeme:** Ein Multi-Agenten-System für das Gesundheitswesen mit verschiedenen Frameworks bauen und sehen, wie A2A die Zusammenarbeit ermöglicht.
- **A2A und MCP:** Lernen, wie A2A MCP ergänzt, indem Agenten die Zusammenarbeit miteinander ermöglicht wird.

## Warum A2A?

Da KI-Agenten immer häufiger eingesetzt werden, ist ihre Fähigkeit zur Interoperabilität entscheidend für den Aufbau komplexer, multifunktionaler Anwendungen. A2A zielt darauf ab:

- **Silos aufbrechen:** Agenten über verschiedene Ökosysteme hinweg verbinden.
- **Komplexe Zusammenarbeit ermöglichen:** Spezialisierten Agenten ermöglichen, gemeinsam an Aufgaben zu arbeiten, die ein einzelner Agent nicht bewältigen kann.
- **Offene Standards fördern:** Einen gemeinschaftsorientierten Ansatz für die Agentenkommunikation fördern und Innovation sowie breite Akzeptanz ermöglichen.
- **Opazität bewahren:** Agenten können zusammenarbeiten, ohne internes Gedächtnis, proprietäre Logik oder spezielle Tool-Implementierungen teilen zu müssen, wodurch Sicherheit und Schutz geistigen Eigentums verbessert werden.

### Hauptfunktionen

- **Standardisierte Kommunikation:** JSON-RPC 2.0 über HTTP(S).
- **Agentenerkennung:** Über "Agent Cards", die Fähigkeiten und Verbindungsinformationen beschreiben.
- **Flexible Interaktion:** Unterstützt synchrones Anfrage/Antwort, Streaming (SSE) und asynchrone Push-Benachrichtigungen.
- **Umfangreicher Datenaustausch:** Verarbeitet Text, Dateien und strukturierte JSON-Daten.
- **Unternehmensbereit:** Entwickelt mit Blick auf Sicherheit, Authentifizierung und Beobachtbarkeit.

## Einstieg

- 📚 **Dokumentation erkunden:** Besuchen Sie die [Agent2Agent Protocol Dokumentationsseite](https://a2a-protocol.org) für einen vollständigen Überblick, die komplette Protokollspezifikation, Tutorials und Anleitungen.
- 📝 **Spezifikation ansehen:** [A2A Protokollspezifikation](https://a2a-protocol.org/latest/specification/)
- Verwenden Sie die SDKs:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) mit Maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) mit [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 Verwenden Sie unsere [Beispiele](https://github.com/a2aproject/a2a-samples), um A2A in Aktion zu sehen

## Mitmachen

Wir freuen uns über Beiträge aus der Community zur Verbesserung und Weiterentwicklung des A2A-Protokolls!

- **Fragen & Diskussionen:** Treten Sie unseren [GitHub Discussions](https://github.com/a2aproject/A2A/discussions) bei.
- **Probleme & Feedback:** Melden Sie Probleme oder schlagen Sie Verbesserungen über [GitHub Issues](https://github.com/a2aproject/A2A/issues) vor.
- **Beitragsleitfaden:** Lesen Sie unsere [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) für Details zum Mitmachen.
- **Privates Feedback:** Nutzen Sie dieses [Google Formular](https://goo.gle/a2a-feedback).
- **Partnerprogramm:** Google Cloud-Kunden können über dieses [Formular](https://goo.gle/a2a-partner) am Partnerprogramm teilnehmen.

## Was kommt als Nächstes

### Protokollverbesserungen

- **Agentenerkennung:**
    - Die Aufnahme von Autorisierungsschemata und optionalen Zugangsdaten direkt in die `AgentCard` formalisieren.
- **Agentenzusammenarbeit:**
    - Untersuchung einer `QuerySkill()`-Methode zum dynamischen Prüfen nicht unterstützter oder unerwarteter Fähigkeiten.
- **Aufgabenlebenszyklus & UX:**
    - Unterstützung für dynamische UX-Aushandlung _innerhalb_ einer Aufgabe (z. B. Agent fügt Audio/Video während des Gesprächs hinzu).
- **Client-Methoden & Transport:**
    - Erweiterung der Unterstützung auf clientinitiierte Methoden (über das Aufgabenmanagement hinaus) prüfen.
    - Verbesserungen der Streaming-Zuverlässigkeit und Push-Benachrichtigungsmechanismen.

## Über

Das A2A-Protokoll ist ein Open-Source-Projekt unter der Linux Foundation, beigesteuert von Google. Es steht unter der [Apache License 2.0](LICENSE) und ist offen für Beiträge aus der Community.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---
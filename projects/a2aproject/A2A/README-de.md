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

Das Agent2Agent (A2A) Protokoll adressiert eine zentrale Herausforderung im KI-Bereich: Es ermöglicht generativen KI-Agenten, die auf unterschiedlichen Frameworks von verschiedenen Unternehmen auf getrennten Servern laufen, effektiv zu kommunizieren und zusammenzuarbeiten – als Agenten, nicht nur als Werkzeuge. A2A soll eine gemeinsame Sprache für Agenten bieten und ein stärker vernetztes, leistungsfähiges und innovatives KI-Ökosystem fördern.

Mit A2A können Agenten:

- Die Fähigkeiten anderer Agenten entdecken.
- Modalitäten der Interaktion verhandeln (Text, Formulare, Medien).
- Sicher an langwierigen Aufgaben zusammenarbeiten.
- Arbeiten, ohne ihren internen Zustand, Speicher oder Werkzeuge preiszugeben.

## Einführungsvideo zu A2A

[![A2A Einführungsvideo](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## Warum A2A?

Mit der zunehmenden Verbreitung von KI-Agenten ist deren Fähigkeit zur Interoperabilität entscheidend für den Aufbau komplexer, multifunktionaler Anwendungen. A2A hat folgende Ziele:

- **Silos aufbrechen:** Agenten über verschiedene Ökosysteme hinweg verbinden.
- **Komplexe Zusammenarbeit ermöglichen:** Spezialisierte Agenten gemeinsam an Aufgaben arbeiten lassen, die ein einzelner Agent nicht allein bewältigen kann.
- **Offene Standards fördern:** Einen gemeinschaftsgetriebenen Ansatz für die Agentenkommunikation unterstützen, um Innovation und breite Akzeptanz zu fördern.
- **Opazität bewahren:** Agenten ermöglichen, zusammenzuarbeiten, ohne internen Speicher, proprietäre Logik oder spezifische Tool-Implementierungen teilen zu müssen, was Sicherheit und den Schutz geistigen Eigentums erhöht.

### Hauptmerkmale

- **Standardisierte Kommunikation:** JSON-RPC 2.0 über HTTP(S).
- **Agenten-Entdeckung:** Über "Agent Cards", die Fähigkeiten und Verbindungsinfos enthalten.
- **Flexible Interaktion:** Unterstützt synchrone Anfragen/Antworten, Streaming (SSE) und asynchrone Push-Benachrichtigungen.
- **Reicher Datenaustausch:** Handhabt Text, Dateien und strukturierte JSON-Daten.
- **Enterprise-tauglich:** Entwickelt mit Fokus auf Sicherheit, Authentifizierung und Beobachtbarkeit.

## Erste Schritte

- 📚 **Dokumentation erkunden:** Besuchen Sie die [Agent2Agent-Protokoll-Dokumentationsseite](https://a2a-protocol.org) für einen vollständigen Überblick, die komplette Protokollspezifikation, Tutorials und Anleitungen.
- 📝 **Spezifikation ansehen:** [A2A Protokoll-Spezifikation](https://a2a-protocol.org/latest/specification/)
- Verwenden Sie die SDKs:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) via Maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) über [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Nutzen Sie unsere [Beispiele](https://github.com/a2aproject/a2a-samples), um A2A in Aktion zu sehen

## Beitrag leisten

Wir begrüßen Beiträge aus der Community, um das A2A-Protokoll zu verbessern und weiterzuentwickeln!

- **Fragen & Diskussionen:** Treten Sie unseren [GitHub Discussions](https://github.com/a2aproject/A2A/discussions) bei.
- **Probleme & Feedback:** Melden Sie Probleme oder schlagen Sie Verbesserungen über [GitHub Issues](https://github.com/a2aproject/A2A/issues) vor.
- **Beitragsleitfaden:** Siehe unseren [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) für Details zur Mitarbeit.
- **Privates Feedback:** Verwenden Sie dieses [Google-Formular](https://goo.gle/a2a-feedback).
- **Partnerprogramm:** Google Cloud-Kunden können unserem Partnerprogramm über dieses [Formular](https://goo.gle/a2a-partner) beitreten.

## Was kommt als Nächstes

### Protokoll-Verbesserungen

- **Agentenerkennung:**
    - Die Aufnahme von Autorisierungsschemata und optionalen Anmeldedaten direkt in die `AgentCard` formalisieren.
- **Agentenzusammenarbeit:**
    - Untersuchung einer `QuerySkill()`-Methode zur dynamischen Überprüfung nicht unterstützter oder unerwarteter Fähigkeiten.
- **Aufgabenlebenszyklus & UX:**
    - Unterstützung für dynamische UX-Verhandlungen _innerhalb_ einer Aufgabe (z. B. Agent fügt Audio/Video während des Gesprächs hinzu).
- **Client-Methoden & Transport:**
    - Ausweitung der Unterstützung auf client-initiierte Methoden (über das Aufgabenmanagement hinaus) prüfen.
    - Verbesserungen der Streaming-Zuverlässigkeit und der Mechanismen für Push-Benachrichtigungen.

## Über

Das A2A-Protokoll ist ein Open-Source-Projekt unter der Linux Foundation, beigetragen von Google. Es steht unter der [Apache License 2.0](LICENSE) und ist für Beiträge aus der Community offen.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---
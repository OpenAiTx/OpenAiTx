# AutoGPT: Erstellen, Bereitstellen und Ausführen von KI-Agenten

[![Discord Follow](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Follow](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT** ist eine leistungsstarke Plattform, mit der Sie kontinuierliche KI-Agenten erstellen, bereitstellen und verwalten können, um komplexe Workflows zu automatisieren.

## Hosting-Optionen
   - Download zum Selbst-Hosting
   - [Warteliste für die Cloud-Hosted Beta beitreten](https://bit.ly/3ZDijAI)

## Einrichtung für Selbst-Hosting

> [!HINWEIS]
> Die Einrichtung und das Hosting der AutoGPT-Plattform ist ein technischer Prozess.
> Wenn Sie lieber eine Lösung möchten, die einfach funktioniert, empfehlen wir Ihnen, [sich für die Cloud-Hosted Beta auf die Warteliste zu setzen](https://bit.ly/3ZDijAI).

### Systemanforderungen

Stellen Sie vor der Installation sicher, dass Ihr System die folgenden Anforderungen erfüllt:

#### Hardware-Anforderungen
- CPU: 4+ Kerne empfohlen
- RAM: Mindestens 8 GB, 16 GB empfohlen
- Speicher: Mindestens 10 GB freier Speicherplatz

#### Software-Anforderungen
- Betriebssysteme:
  - Linux (Ubuntu 20.04 oder neuer empfohlen)
  - macOS (10.15 oder neuer)
  - Windows 10/11 mit WSL2
- Benötigte Software (mit Mindestversionen):
  - Docker Engine (20.10.0 oder neuer)
  - Docker Compose (2.0.0 oder neuer)
  - Git (2.30 oder neuer)
  - Node.js (16.x oder neuer)
  - npm (8.x oder neuer)
  - VSCode (1.60 oder neuer) oder ein moderner Code-Editor

#### Netzwerk-Anforderungen
- Stabile Internetverbindung
- Zugang zu den benötigten Ports (wird in Docker konfiguriert)
- Möglichkeit, ausgehende HTTPS-Verbindungen herzustellen

### Aktualisierte Installationsanleitung:
Wir sind auf eine vollständig gepflegte und regelmäßig aktualisierte Dokumentationsseite umgestiegen.

👉 [Folgen Sie hier der offiziellen Self-Hosting-Anleitung](https://docs.agpt.co/platform/getting-started/)

Diese Anleitung setzt voraus, dass Docker, VSCode, git und npm installiert sind.

### 🧱 AutoGPT-Frontend

Das AutoGPT-Frontend ist der Ort, an dem Benutzer mit unserer leistungsstarken KI-Automatisierungsplattform interagieren. Es bietet verschiedene Möglichkeiten, mit unseren KI-Agenten zu arbeiten und diese zu nutzen. Über diese Oberfläche setzen Sie Ihre Automatisierungsideen in die Tat um:

   **Agent Builder:** Für alle, die anpassen möchten, bietet unsere intuitive, Low-Code-Oberfläche die Möglichkeit, eigene KI-Agenten zu entwerfen und zu konfigurieren.
   
   **Workflow-Management:** Erstellen, verändern und optimieren Sie Ihre Automatisierungs-Workflows ganz einfach. Sie bauen Ihren Agenten, indem Sie Blöcke verbinden, wobei jeder Block eine einzelne Aktion ausführt.
   
   **Deployment-Steuerung:** Verwalten Sie den Lebenszyklus Ihrer Agenten, vom Testen bis zur Produktion.
   
   **Einsatzbereite Agenten:** Sie möchten nicht selbst bauen? Wählen Sie einfach aus unserer Bibliothek vorkonfigurierter Agenten und setzen Sie diese sofort ein.
   
   **Agenten-Interaktion:** Egal, ob Sie eigene Agenten gebaut haben oder vorkonfigurierte nutzen – führen Sie diese einfach über unsere benutzerfreundliche Oberfläche aus und interagieren Sie damit.

   **Monitoring und Analytics:** Behalten Sie die Leistung Ihrer Agenten im Blick und gewinnen Sie Einblicke, um Ihre Automatisierungsprozesse kontinuierlich zu verbessern.

[Lesen Sie diese Anleitung](https://docs.agpt.co/platform/new_blocks/), um zu erfahren, wie Sie eigene benutzerdefinierte Blöcke erstellen.

### 💽 AutoGPT-Server

Der AutoGPT-Server ist das Herzstück unserer Plattform. Hier laufen Ihre Agenten. Nach der Bereitstellung können Agenten von externen Quellen ausgelöst werden und kontinuierlich arbeiten. Er enthält alle wichtigen Komponenten, die einen reibungslosen Ablauf von AutoGPT gewährleisten.

   **Quellcode:** Die Kernlogik, die unsere Agenten und Automatisierungsprozesse antreibt.
   
   **Infrastruktur:** Robuste Systeme für zuverlässige und skalierbare Performance.
   
   **Marketplace:** Ein umfassender Marktplatz, auf dem Sie eine Vielzahl vorgefertigter Agenten finden und bereitstellen können.

### 🐙 Beispiel-Agenten

Hier sind zwei Beispiele, was Sie mit AutoGPT umsetzen können:

1. **Virale Videos aus Trendthemen generieren**
   - Dieser Agent liest Themen auf Reddit aus.
   - Er identifiziert aktuelle Trends.
   - Anschließend erstellt er automatisch ein Kurzvideo basierend auf dem Inhalt.

2. **Top-Zitate aus Videos für soziale Medien identifizieren**
   - Dieser Agent abonniert Ihren YouTube-Kanal.
   - Bei Veröffentlichung eines neuen Videos transkribiert er dieses.
   - Mithilfe von KI werden die aussagekräftigsten Zitate extrahiert und eine Zusammenfassung generiert.
   - Anschließend erstellt er einen Beitrag, der automatisch in Ihren sozialen Medien veröffentlicht wird.

Diese Beispiele geben nur einen kleinen Einblick, was Sie mit AutoGPT erreichen können! Sie können individuelle Workflows gestalten, um Agenten für jeden Anwendungsfall zu erstellen.

---
### Mission und Lizenzierung

Unsere Mission ist es, Ihnen die Werkzeuge bereitzustellen, damit Sie sich auf das Wesentliche konzentrieren können:

- 🏗️ **Bauen** – Legen Sie das Fundament für etwas Großartiges.
- 🧪 **Testen** – Feilen Sie Ihren Agenten zur Perfektion.
- 🤝 **Delegieren** – Lassen Sie die KI für sich arbeiten und Ihre Ideen Wirklichkeit werden.

Seien Sie Teil der Revolution! **AutoGPT** bleibt an der Spitze der KI-Innovation.

**📖 [Dokumentation](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [Mitwirken](CONTRIBUTING.md)**

**Lizenzierung:**

MIT-Lizenz: Der Großteil des AutoGPT-Repositoriums steht unter der MIT-Lizenz.

Polyform Shield License: Diese Lizenz gilt für den Ordner autogpt_platform.

Weitere Informationen finden Sie unter https://agpt.co/blog/introducing-the-autogpt-platform

---
## 🤖 AutoGPT Classic
> Nachfolgend finden Sie Informationen zur klassischen Version von AutoGPT.

**🛠️ [Eigenen Agenten bauen – Schnellstart](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

**Schmieden Sie Ihren eigenen Agenten!** – Forge ist ein sofort einsatzbereites Toolkit zur Entwicklung eigener Agenten-Anwendungen. Es übernimmt den Großteil des Boilerplate-Codes, sodass Sie Ihre Kreativität auf das konzentrieren können, was *Ihren* Agenten einzigartig macht. Alle Tutorials finden Sie [hier](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec). Komponenten aus [`forge`](/classic/forge/) können auch einzeln verwendet werden, um die Entwicklung zu beschleunigen und Boilerplate-Code im Agentenprojekt zu reduzieren.

🚀 [**Erste Schritte mit Forge**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) –
Diese Anleitung führt Sie durch den Prozess der Erstellung eines eigenen Agenten und der Nutzung von Benchmark und Benutzeroberfläche.

📘 [Mehr erfahren](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge) über Forge

### 🎯 Benchmark

**Messen Sie die Leistung Ihres Agenten!** Das `agbenchmark` kann mit jedem Agenten verwendet werden, der das Agentenprotokoll unterstützt. Die Integration mit der [CLI] des Projekts macht die Nutzung mit AutoGPT- und forge-basierten Agenten noch einfacher. Der Benchmark bietet eine anspruchsvolle Testumgebung. Unser Framework ermöglicht autonome, objektive Performance-Evaluierungen und stellt sicher, dass Ihre Agenten für reale Einsätze bereit sind.

<!-- TODO: insert visual demonstrating the benchmark -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) auf Pypi
&ensp;|&ensp;
📘 [Mehr erfahren](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark) über den Benchmark

### 💻 UI

**Macht Agenten einfach bedienbar!** Das `frontend` bietet Ihnen eine benutzerfreundliche Oberfläche zur Steuerung und Überwachung Ihrer Agenten. Es verbindet sich über das [Agentenprotokoll](#-agent-protocol) mit Agenten und gewährleistet so die Kompatibilität mit vielen Agenten innerhalb und außerhalb unseres Ökosystems.

<!-- TODO: insert screenshot of front end -->

Das Frontend funktioniert sofort mit allen Agenten im Repo. Starten Sie einfach den gewünschten Agenten über die [CLI]!

📘 [Mehr erfahren](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend) über das Frontend

### ⌨️ CLI

[CLI]: #-cli

Um die Nutzung aller im Repository bereitgestellten Werkzeuge so einfach wie möglich zu machen, ist eine CLI im Root-Verzeichnis enthalten:

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

Klonen Sie einfach das Repository, installieren Sie die Abhängigkeiten mit `./run setup` und schon kann es losgehen!

## 🤔 Fragen? Probleme? Vorschläge?

### Hilfe erhalten – [Discord 💬](https://discord.gg/autogpt)

[![Join us on Discord](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

Um einen Fehler zu melden oder eine Funktion anzufordern, erstellen Sie ein [GitHub Issue](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose). Bitte prüfen Sie zuvor, ob bereits ein Issue zum gleichen Thema existiert.

## 🤝 Schwesterprojekte

### 🔄 Agent Protocol

Um einen einheitlichen Standard zu gewährleisten und die nahtlose Kompatibilität mit vielen aktuellen und zukünftigen Anwendungen zu sichern, verwendet AutoGPT den [Agent Protocol](https://agentprotocol.ai/) Standard der AI Engineer Foundation. Dieser standardisiert die Kommunikationswege von Ihrem Agenten zum Frontend und zum Benchmark.

---

## Sterne-Statistik

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>

## ⚡ Mitwirkende

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="View Contributors">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Contributors" />
</a>


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
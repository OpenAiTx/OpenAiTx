# Agent2Agent (A2A) Beispiele

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
      alt="Im Firebase Studio ausprobieren"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 Sprache</summary>
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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
    </div>
  </details>
</div>

Willkommen bei den offiziellen Code-Beispielen und Demonstrationen für das [Agent2Agent (A2A) Protokoll](https://goo.gle/a2a).

Wir freuen uns, dass Sie hier sind! Egal, ob Sie zum ersten Mal Multi-Agenten-Architekturen erkunden oder fortschrittliche, interoperable Agenten-Netzwerke aufbauen, dieses Repository bietet einfache, inspirierende und zugängliche Lernressourcen, um Ihre Entwicklung zu beschleunigen.

## Warum Agent2Agent?

In einer Welt vielfältiger KI-Frameworks und Ökosysteme benötigen Agenten eine gemeinsame Sprache, um sicher zu kommunizieren, zusammenzuarbeiten und Aufgaben zu delegieren. Das A2A-Protokoll schafft einen standardisierten, offenen Standard für die Interoperabilität von Multi-Agenten-Systemen.

Unsere Beispiele zeigen, wie einfach komplexe Multi-Agenten-Probleme über verschiedene Programmiersprachen und Host-Anwendungen hinweg gelöst werden können.

## Schnellstart

Starten Sie sofort, indem Sie einen Helloworld-Agenten ausführen und über unser Python CLI-Host mit ihm kommunizieren.

1. **Starten Sie den Agent-Server**:
   Öffnen Sie ein Terminal und starten Sie den Helloworld-Agenten-Server:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **Starten Sie den Host-Client**:
   Öffnen Sie ein zweites Terminal und führen Sie den CLI-Client aus, um eine Aufgabe an den Agenten zu senden:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## Repository-Struktur

Das Repository ist in mehrere wichtige Verzeichnisse nach Programmiersprache organisiert:

| Verzeichnis | Beschreibung |
| --- | --- |
| [samples](/samples) | Kern-A2A-Beispiele organisiert nach Programmiersprache. |
| [samples/python](/samples/python) | Zeigt Python-Agentenimplementierungen mit dem A2A Python SDK. |
| [samples/go](/samples/go) | Zeigt Go-Agentenimplementierungen mit dem A2A Go SDK. |
| [samples/dotnet](/samples/dotnet) | Zeigt C#-Agentenimplementierungen mit dem A2A .NET SDK. |
| [samples/java](/samples/java) | Zeigt Java-Agentenimplementierungen mit dem A2A Java SDK. |
| [samples/js](/samples/js) | Zeigt Node.js-Agentenimplementierungen mit dem A2A JavaScript SDK. |

## Mitwirken

Wir begrüßen und fördern Beiträge aller Erfahrungsstufen! Wenn Sie eine Idee für ein neues Beispiel, einen Bugfix oder eine Verbesserung der Dokumentation haben, schauen Sie bitte in unseren [Contributing Guide](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Hilfe erhalten

Wir setzen uns für eine einladende und unterstützende Community ein. Wenn Sie Fragen, Feedback oder Probleme haben, wenden Sie sich bitte an unsere [Issues-Seite](https://github.com/a2aproject/a2a-samples/issues).

## Verwandte Repositories

| Repository | Kategorie | Beschreibung |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | Kern-Spezifikation | A2A-Spezifikation und Dokumentation. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | Tooling | UI-Tool zum Inspizieren von A2A-fähigen Agenten. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | Testing | Testsuite zur Validierung der A2A-Protokoll-Konformität. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | Testing | Toolkit zur Überprüfung der Kompatibilität verschiedener A2A SDK-Implementierungen und Versionen mittels Multi-Hop-Traversal-Modell und variierenden Transportprotokollen. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | Offizielles Python SDK für A2A. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | Offizielles Go SDK für A2A. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | Offizielles Java SDK für A2A. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | Offizielles Node.js/JavaScript SDK für A2A. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | Offizielles C#/.NET SDK für A2A. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | Offizielles Rust SDK für A2A. |

## Haftungsausschluss

**Wichtig:** Der bereitgestellte Beispielcode dient zu Demonstrationszwecken und illustriert die Mechanik des
Agent-to-Agent (A2A) Protokoll. Beim Aufbau von Produktionsanwendungen ist es entscheidend, jeden Agenten,
der außerhalb Ihrer direkten Kontrolle agiert, als potenziell nicht vertrauenswürdige Entität zu behandeln.

Alle von einem externen Agenten empfangenen Daten – einschließlich, aber nicht beschränkt auf dessen AgentCard,
Nachrichten, Artefakte und Aufgabenstatus – sollten als nicht vertrauenswürdige Eingaben behandelt werden. Ein bösartiger Agent
könnte beispielsweise eine AgentCard mit manipulierten Daten in seinen Feldern bereitstellen (z. B. Beschreibung, Name,
skills.description). Wenn diese Daten ohne Bereinigung zur Erstellung von Prompts für ein Large
Language Model (LLM) verwendet werden, könnte Ihre Anwendung Angriffen durch Prompt Injection ausgesetzt werden. Wenn diese Daten
vor der Verwendung nicht ordnungsgemäß validiert und bereinigt werden, können dadurch Sicherheitslücken in
Ihrer Anwendung entstehen.

> Entwickler sind dafür verantwortlich, geeignete Sicherheitsmaßnahmen wie Eingabevalidierung
> und sichere Handhabung von Zugangsdaten zu implementieren, um ihre Systeme und Nutzer zu schützen.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---
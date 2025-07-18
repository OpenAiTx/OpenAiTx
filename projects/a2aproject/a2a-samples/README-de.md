# Agent2Agent (A2A) Beispiele

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

Dieses Repository enthält Codebeispiele und Demos, die das [Agent2Agent (A2A) Protokoll](https://goo.gle/a2a) verwenden.

## Verwandte Repositories

- [A2A](https://github.com/a2aproject/A2A) – A2A Spezifikation und Dokumentation.
- [a2a-python](https://github.com/a2aproject/a2a-python) – A2A Python SDK.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) – UI-Tool zur Inspektion von A2A-fähigen Agents.

## Beitrag leisten

Beiträge sind willkommen! Siehe den [Beitragsleitfaden](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Hilfe erhalten

Bitte nutzen Sie die [Issues-Seite](https://github.com/a2aproject/a2a-samples/issues), um Vorschläge, Feedback oder Fehlerberichte einzureichen.

## Haftungsausschluss

Dieses Repository selbst ist kein offiziell unterstütztes Google-Produkt. Der Code in diesem Repository dient nur zu Demonstrationszwecken.

Wichtig: Der bereitgestellte Beispielcode dient Demonstrationszwecken und veranschaulicht die Mechanik des Agent-to-Agent (A2A) Protokolls. Beim Entwickeln von Produktionsanwendungen ist es entscheidend, jeden Agenten, der außerhalb Ihrer direkten Kontrolle arbeitet, als potenziell nicht vertrauenswürdig zu betrachten.

Alle von einem externen Agenten empfangenen Daten – einschließlich, aber nicht beschränkt auf seine AgentCard, Nachrichten, Artefakte und Aufgabenstatus – sollten als nicht vertrauenswürdige Eingaben behandelt werden. Beispielsweise könnte ein bösartiger Agent eine AgentCard mit manipulierten Daten in seinen Feldern (z. B. Beschreibung, Name, skills.description) bereitstellen. Wenn diese Daten ohne Bereinigung zur Erstellung von Prompts für ein Large Language Model (LLM) verwendet werden, könnte Ihre Anwendung Angriffen durch Prompt Injection ausgesetzt werden. Fehlerhafte Validierung und Bereinigung dieser Daten vor der Nutzung kann Sicherheitslücken in Ihrer Anwendung verursachen.

Entwickler sind dafür verantwortlich, geeignete Sicherheitsmaßnahmen wie Eingabevalidierung und sichere Handhabung von Zugangsdaten zu implementieren, um ihre Systeme und Nutzer zu schützen.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
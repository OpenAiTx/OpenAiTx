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

Dieses Repository enthält Codebeispiele und Demos, die das [Agent2Agent (A2A) Protokoll](https://goo.gle/a2a) verwenden.

## Verwandte Repositories

- [A2A](https://github.com/a2aproject/A2A) – A2A Spezifikation und Dokumentation.
- [a2a-python](https://github.com/a2aproject/a2a-python) – A2A Python SDK.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) – UI-Tool zur Inspektion von A2A-fähigen Agenten.

## Beitrag leisten

Beiträge sind willkommen! Siehe den [Beitragsleitfaden](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Hilfe erhalten

Bitte nutzen Sie die [Issues-Seite](https://github.com/a2aproject/a2a-samples/issues), um Vorschläge oder Feedback zu geben oder einen Fehler zu melden.

## Haftungsausschluss

Dieses Repository selbst ist kein offiziell unterstütztes Google-Produkt. Der Code in diesem Repository dient ausschließlich Demonstrationszwecken.

Wichtig: Der bereitgestellte Beispielcode dient Demonstrationszwecken und veranschaulicht die Mechanik des Agent-to-Agent (A2A) Protokolls. Beim Erstellen von Produktionsanwendungen ist es entscheidend, jeden Agenten außerhalb Ihrer direkten Kontrolle als potenziell nicht vertrauenswürdige Entität zu behandeln.

Alle von einem externen Agenten empfangenen Daten – einschließlich, aber nicht beschränkt auf dessen AgentCard, Nachrichten, Artefakte und Aufgabenstatus – sollten als nicht vertrauenswürdige Eingabe behandelt werden. Beispielsweise könnte ein böswilliger Agent eine AgentCard mit manipulierten Daten in seinen Feldern bereitstellen (z. B. Beschreibung, Name, skills.description). Wenn diese Daten ohne Bereinigung zur Erstellung von Prompts für ein Large Language Model (LLM) verwendet werden, könnte dies Ihre Anwendung anfällig für Prompt-Injection-Angriffe machen. Das Versäumnis, diese Daten vor der Verwendung ordnungsgemäß zu validieren und zu bereinigen, kann Sicherheitslücken in Ihrer Anwendung verursachen.

Entwickler sind dafür verantwortlich, geeignete Sicherheitsmaßnahmen zu implementieren, wie z. B. Eingabevalidierung und sichere Handhabung von Zugangsdaten, um ihre Systeme und Benutzer zu schützen.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---
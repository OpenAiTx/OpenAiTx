# Esempi di Agent2Agent (A2A)

<div style="text-align: right;">
  <details>
    <summary>🌐 Lingua</summary>
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

Questo repository contiene esempi di codice e demo che utilizzano il [Protocollo Agent2Agent (A2A)](https://goo.gle/a2a).

## Repository correlati

- [A2A](https://github.com/a2aproject/A2A) - Specifiche e documentazione A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK Python per A2A.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Strumento UI per l'ispezione degli agenti abilitati A2A.

## Contribuire

Contributi benvenuti! Consulta la [Guida ai Contributi](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Ottenere aiuto

Utilizza la [pagina delle issues](https://github.com/a2aproject/a2a-samples/issues) per fornire suggerimenti, feedback o segnalare un bug.

## Disclaimer

Questo repository non è un prodotto Google ufficialmente supportato. Il codice presente in questo repository è solo a scopo dimostrativo.

Importante: Il codice di esempio fornito è solo a scopo dimostrativo e illustra la meccanica del protocollo Agent-to-Agent (A2A). Quando si sviluppano applicazioni di produzione, è fondamentale trattare qualsiasi agente che operi al di fuori del proprio controllo diretto come un'entità potenzialmente non affidabile.

Tutti i dati ricevuti da un agente esterno—compresi, ma non solo, AgentCard, messaggi, artefatti e stati dei task—devono essere considerati come input non affidabili. Ad esempio, un agente malevolo potrebbe fornire una AgentCard contenente dati creati appositamente nei suoi campi (ad esempio, descrizione, nome, skills.description). Se questi dati vengono utilizzati senza sanificazione per costruire prompt per un Large Language Model (LLM), si potrebbe esporre la propria applicazione ad attacchi di prompt injection. La mancata validazione e sanificazione di questi dati prima dell'uso può introdurre vulnerabilità di sicurezza nella propria applicazione.

Gli sviluppatori sono responsabili dell'implementazione di adeguate misure di sicurezza, come la validazione degli input e la gestione sicura delle credenziali, per proteggere i propri sistemi e utenti.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
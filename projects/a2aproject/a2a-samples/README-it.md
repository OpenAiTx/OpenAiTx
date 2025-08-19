# Esempi Agent2Agent (A2A)

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
      alt="Prova in Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
    </div>
  </details>
</div>

Questo repository contiene esempi di codice e demo che utilizzano il [Protocollo Agent2Agent (A2A)](https://goo.gle/a2a).

## Repository correlati

- [A2A](https://github.com/a2aproject/A2A) - Specifiche e documentazione A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK Python per A2A.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Strumento UI per l'ispezione di agenti abilitati A2A.

## Contribuire

Contributi benvenuti! Consulta la [Guida alla Contribuzione](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Ottenere assistenza

Utilizza la [pagina delle issues](https://github.com/a2aproject/a2a-samples/issues) per fornire suggerimenti, feedback o segnalare un bug.

## Dichiarazione di non responsabilità

Questo repository non è un prodotto Google ufficialmente supportato. Il codice presente è solo a scopo dimostrativo.

Importante: Il codice di esempio fornito è solo a scopo dimostrativo e illustra le meccaniche del protocollo Agent-to-Agent (A2A). Quando si sviluppano applicazioni di produzione, è fondamentale trattare qualsiasi agente operante al di fuori del proprio controllo diretto come potenzialmente non affidabile.

Tutti i dati ricevuti da un agente esterno—inclusi, ma non limitati a, AgentCard, messaggi, artefatti e stati dei task—devono essere gestiti come input non affidabile. Ad esempio, un agente malevolo potrebbe fornire una AgentCard con dati manipolati nei suoi campi (ad es. descrizione, nome, skills.description). Se questi dati vengono utilizzati senza sanificazione per costruire prompt per un Large Language Model (LLM), si potrebbe esporre l'applicazione ad attacchi di prompt injection. La mancata validazione e sanificazione di questi dati prima dell'uso può introdurre vulnerabilità di sicurezza nell'applicazione.

Gli sviluppatori sono responsabili dell'implementazione di misure di sicurezza adeguate, come la validazione degli input e la gestione sicura delle credenziali, per proteggere i propri sistemi e utenti.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---
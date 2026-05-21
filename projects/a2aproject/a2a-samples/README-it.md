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

Benvenuto negli esempi di codice ufficiali e nelle dimostrazioni per il [Protocollo Agent2Agent (A2A)](https://goo.gle/a2a).

Siamo entusiasti di averti qui! Che tu stia esplorando architetture multi-agente per la prima volta o costruendo reti di agenti interoperabili avanzate, questo repository offre risorse di apprendimento semplici, stimolanti e accessibili per accelerare il tuo sviluppo.

## Perché Agent2Agent?

In un mondo di ecosistemi e framework di intelligenza artificiale diversi, gli agenti hanno bisogno di un linguaggio comune per comunicare, collaborare e delegare compiti in modo sicuro. Il protocollo A2A stabilisce uno standard aperto e standardizzato per l'interoperabilità multi-agente.

I nostri esempi dimostrano quanto sia facile risolvere problemi complessi tra più agenti in diversi linguaggi e applicazioni host.

## Avvio rapido

Inizia subito avviando un agente Helloworld e comunicando con esso tramite il nostro host Python CLI.

1. **Avvia il server dell'agente**:
   Apri un terminale e avvia il server dell'agente Helloworld:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **Avvia il Client Host**:
   Apri un secondo terminale ed esegui il client CLI per inviare un compito all'agente:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## Struttura del Repository

Il repository è organizzato in diverse directory chiave per lingua:

| Directory | Descrizione |
| --- | --- |
| [samples](/samples) | Esempi A2A principali organizzati per linguaggio di programmazione. |
| [samples/python](/samples/python) | Dimostra implementazioni di agenti Python usando l’SDK Python A2A. |
| [samples/go](/samples/go) | Dimostra implementazioni di agenti Go usando l’SDK Go A2A. |
| [samples/dotnet](/samples/dotnet) | Dimostra implementazioni di agenti C# usando l’SDK .NET A2A. |
| [samples/java](/samples/java) | Dimostra implementazioni di agenti Java usando l’SDK Java A2A. |
| [samples/js](/samples/js) | Dimostra implementazioni di agenti Node.js usando l’SDK JavaScript A2A. |

## Contributi

Accogliamo e incoraggiamo contributi di tutti i livelli di esperienza! Se hai un’idea per un nuovo esempio, una correzione di bug o un miglioramento della documentazione, consulta la nostra [Guida ai Contributi](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Richiedere Assistenza

Siamo dedicati a fornire una comunità accogliente e di supporto. Se hai domande, feedback o incontri problemi, contattaci sulla nostra [pagina delle issue](https://github.com/a2aproject/a2a-samples/issues).

## Repository Correlati

| Repository | Categoria | Descrizione |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | Specifica Principale | Specifica A2A e documentazione. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | Strumenti | Strumento UI per ispezionare agenti abilitati A2A. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | Test | Suite di test per la validazione della conformità al protocollo A2A. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | Test | Toolkit per verificare la compatibilità tra diverse implementazioni e versioni di SDK A2A tramite modello di attraversamento multi-hop e diversi protocolli di trasporto. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | SDK Python ufficiale per A2A. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | SDK Go ufficiale per A2A. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | SDK Java ufficiale per A2A. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | SDK Node.js/JavaScript ufficiale per A2A. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | SDK C#/.NET ufficiale per A2A. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | SDK Rust ufficiale per A2A. |

## Disclaimer

**Importante:** Il codice di esempio fornito è solo a scopo dimostrativo e illustra le meccaniche del
Protocollo Agent-to-Agent (A2A). Quando si costruiscono applicazioni di produzione, è fondamentale trattare qualsiasi agente
che opera al di fuori del proprio controllo diretto come un'entità potenzialmente non affidabile.

Tutti i dati ricevuti da un agente esterno—inclusi, ma non limitati a, AgentCard, messaggi,
artifacts e stati dei task—devono essere gestiti come input non affidabile. Ad esempio, un agente malevolo
potrebbe fornire un'AgentCard contenente dati manipolati nei suoi campi (ad es. descrizione, nome,
skills.description). Se questi dati vengono utilizzati senza essere sanitizzati per costruire prompt per un Large
Language Model (LLM), potrebbero esporre la tua applicazione ad attacchi di prompt injection. Il mancato
valido e sanificazione corretta di questi dati prima dell'uso può introdurre vulnerabilità di sicurezza nella
tua applicazione.

> Gli sviluppatori sono responsabili dell'implementazione di misure di sicurezza appropriate, come la validazione degli input
> e la gestione sicura delle credenziali per proteggere i loro sistemi e utenti.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---
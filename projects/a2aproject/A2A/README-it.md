# Protocollo Agent2Agent (A2A)

[![PyPI - Versione](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Licenza Apache](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Chiedi a Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 Lingua</summary>
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
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Logo del Protocollo Agent2Agent" width="100">
    <h1>Protocollo Agent2Agent (A2A)</h1>
  </div>
</div>

**Un protocollo aperto che consente comunicazione e interoperabilità tra applicazioni agentiche opache.**

Il protocollo Agent2Agent (A2A) affronta una sfida critica nel panorama dell’IA: permettere agli agenti generativi di IA, costruiti su framework diversi da aziende differenti e operanti su server separati, di comunicare e collaborare efficacemente - come agenti, non solo come strumenti. A2A mira a fornire un linguaggio comune per gli agenti, favorendo un ecosistema IA più interconnesso, potente e innovativo.

Con A2A, gli agenti possono:

- Scoprire le reciproche capacità.
- Negoziare le modalità di interazione (testo, moduli, media).
- Collaborare in modo sicuro su compiti di lunga durata.
- Operare senza esporre stato interno, memoria o strumenti.

## Video Introduttivo A2A

[![Video Intro A2A](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## Perché A2A?

Man mano che gli agenti IA diventano più diffusi, la loro capacità di interoperare è fondamentale per costruire applicazioni complesse e multifunzionali. A2A mira a:

- **Abbattere i Silos:** Collegare agenti tra diversi ecosistemi.
- **Abilitare Collaborazioni Complesse:** Consentire agli agenti specializzati di lavorare insieme su compiti che un singolo agente non può gestire da solo.
- **Promuovere Standard Aperti:** Favorire un approccio comunitario alla comunicazione tra agenti, incoraggiando innovazione e ampia adozione.
- **Preservare l’Opacità:** Permettere agli agenti di collaborare senza condividere memoria interna, logica proprietaria o implementazioni specifiche di strumenti, aumentando la sicurezza e proteggendo la proprietà intellettuale.

### Caratteristiche Principali

- **Comunicazione Standardizzata:** JSON-RPC 2.0 via HTTP(S).
- **Scoperta degli Agenti:** Tramite “Agent Card” con dettagli su capacità e informazioni di connessione.
- **Interazione Flessibile:** Supporta richiesta/risposta sincrona, streaming (SSE) e notifiche push asincrone.
- **Scambio Dati Ricco:** Gestione di testo, file e dati strutturati in JSON.
- **Pronto per l’Enterprise:** Progettato con sicurezza, autenticazione e osservabilità integrate.

## Per iniziare

- 📚 **Esplora la Documentazione:** Visita il [Sito della Documentazione del Protocollo Agent2Agent](https://a2a-protocol.org) per una panoramica completa, la specifica integrale del protocollo, tutorial e guide.
- 📝 **Visualizza la Specifica:** [Specifica del Protocollo A2A](https://a2a-protocol.org/latest/specification/)
- Usa gli SDK:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) tramite maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) tramite [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Usa i nostri [esempi](https://github.com/a2aproject/a2a-samples) per vedere A2A in azione

## Contribuire

Accogliamo con piacere contributi dalla comunità per migliorare ed evolvere il protocollo A2A!

- **Domande & Discussioni:** Unisciti alle nostre [Discussioni su GitHub](https://github.com/a2aproject/A2A/discussions).
- **Problemi & Feedback:** Segnala problemi o suggerisci miglioramenti tramite [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Guida alla Contribuzione:** Consulta il nostro [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) per dettagli su come contribuire.
- **Feedback Privato:** Usa questo [Google Form](https://goo.gle/a2a-feedback).
- **Programma Partner:** I clienti Google Cloud possono aderire al programma partner tramite questo [form](https://goo.gle/a2a-partner).

## Cosa succede ora

### Miglioramenti al Protocollo

- **Scoperta degli Agent:**
    - Formalizzare l'inclusione di schemi di autorizzazione e credenziali opzionali direttamente all'interno della `AgentCard`.
- **Collaborazione tra Agent:**
    - Esplorare un metodo `QuerySkill()` per verificare dinamicamente skill non supportati o inattesi.
- **Ciclo di Vita dei Task & UX:**
    - Supporto per la negoziazione dinamica della UX _all'interno_ di un task (es. agent che aggiunge audio/video durante la conversazione).
- **Metodi Client & Trasporto:**
    - Valutare l'estensione del supporto ai metodi avviati dal client (oltre la gestione dei task).
    - Miglioramenti all'affidabilità dello streaming e ai meccanismi di push notification.

## Informazioni

Il Protocollo A2A è un progetto open source sotto la Linux Foundation, contribuito da Google. È distribuito con licenza [Apache License 2.0](LICENSE) ed è aperto ai contributi della comunità.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---
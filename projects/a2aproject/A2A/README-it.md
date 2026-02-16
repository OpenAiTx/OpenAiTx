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
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Logo Protocollo Agent2Agent" width="100">
    <h1>Protocollo Agent2Agent (A2A)</h1>
  </div>
</div>

**Un protocollo aperto che permette comunicazione e interoperabilità tra applicazioni agentiche opache.**

Il protocollo Agent2Agent (A2A) affronta una sfida cruciale nel panorama AI: consentire agli agenti gen AI, costruiti su framework diversi da aziende differenti e in esecuzione su server separati, di comunicare e collaborare efficacemente - come agenti, non solo come strumenti. A2A mira a fornire un linguaggio comune per gli agenti, promuovendo un ecosistema AI più interconnesso, potente e innovativo.

Con A2A, gli agenti possono:

- Scoprire le capacità degli altri.
- Negoziare le modalità di interazione (testo, moduli, media).
- Collaborare in modo sicuro su compiti a lungo termine.
- Operare senza esporre il proprio stato interno, memoria o strumenti.

## Corso DeepLearning.AI

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

Partecipa a questo breve corso su [A2A: Il Protocollo Agent2Agent](https://goo.gle/dlai-a2a), realizzato in collaborazione con Google Cloud e IBM Research, e tenuto da [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini), e [Sandi Besen](https://github.com/sandijean90).

**Cosa imparerai:**

- **Rendi gli agenti compatibili con A2A:** Esporre agenti costruiti con framework come Google ADK, LangGraph, o BeeAI come server A2A.
- **Collega gli agenti:** Crea client A2A da zero o usando integrazioni per connetterti ad agenti compatibili A2A.
- **Orchestra flussi di lavoro:** Costruisci flussi di lavoro sequenziali e gerarchici di agenti compatibili A2A.
- **Sistemi multi-agente:** Crea un sistema multi-agente sanitario usando diversi framework e scopri come A2A permette la collaborazione.
- **A2A e MCP:** Scopri come A2A completa MCP permettendo agli agenti di collaborare tra loro.

## Perché A2A?

Man mano che gli agenti AI diventano più diffusi, la loro capacità di interoperare è cruciale per creare applicazioni complesse e multi-funzionali. A2A mira a:

- **Abbattere i silos:** Collegare agenti di diversi ecosistemi.
- **Permettere collaborazione complessa:** Consentire ad agenti specializzati di lavorare insieme su compiti che un singolo agente non può gestire da solo.
- **Promuovere standard aperti:** Favorire un approccio guidato dalla comunità per la comunicazione tra agenti, stimolando innovazione e ampia adozione.
- **Preservare l’opacità:** Permettere agli agenti di collaborare senza dover condividere memoria interna, logica proprietaria o implementazioni specifiche di strumenti, rafforzando la sicurezza e proteggendo la proprietà intellettuale.

### Caratteristiche principali

- **Comunicazione standardizzata:** JSON-RPC 2.0 su HTTP(S).
- **Scoperta degli agenti:** Tramite "Schede Agente" che dettagliano capacità e informazioni di connessione.
- **Interazione flessibile:** Supporta richieste/risposte sincrone, streaming (SSE) e notifiche push asincrone.
- **Scambio dati avanzato:** Gestisce testo, file e dati strutturati in JSON.
- **Pronto per l’Enterprise:** Progettato con sicurezza, autenticazione e osservabilità.

## Per iniziare

- 📚 **Esplora la documentazione:** Visita il [Sito della Documentazione del Protocollo Agent2Agent](https://a2a-protocol.org) per una panoramica completa, la specifica del protocollo, tutorial e guide.
- 📝 **Visualizza la specifica:** [Specifica del Protocollo A2A](https://a2a-protocol.org/latest/specification/)
- Usa gli SDK:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) tramite maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) tramite [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Usa i nostri [esempi](https://github.com/a2aproject/a2a-samples) per vedere A2A in azione

## Contribuire

Accogliamo con piacere i contributi della community per migliorare ed evolvere il protocollo A2A!

- **Domande e discussioni:** Unisciti alle nostre [GitHub Discussions](https://github.com/a2aproject/A2A/discussions).
- **Segnalazioni e feedback:** Riporta problemi o suggerisci miglioramenti tramite [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Guida al contributo:** Consulta il nostro [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) per dettagli su come contribuire.
- **Feedback privato:** Usa questo [Google Form](https://goo.gle/a2a-feedback).
- **Programma Partner:** I clienti Google Cloud possono unirsi al nostro programma partner tramite questo [form](https://goo.gle/a2a-partner).

## Prossimi passi

### Miglioramenti del protocollo

- **Scoperta degli agenti:**
    - Formalizzare l’inclusione di schemi di autorizzazione e credenziali opzionali direttamente nella `AgentCard`.
- **Collaborazione tra agenti:**
    - Esplorare un metodo `QuerySkill()` per verificare dinamicamente le skill non supportate o impreviste.
- **Ciclo di vita dei task & UX:**
    - Supporto per la negoziazione dinamica della UX _all'interno_ di un'attività (ad es., agente che aggiunge audio/video durante la conversazione).
- **Metodi Client & Trasporto:**
    - Esplorare l'estensione del supporto ai metodi avviati dal client (oltre la gestione delle attività).
    - Miglioramenti all'affidabilità dello streaming e ai meccanismi di push notification.

## Informazioni

Il Protocollo A2A è un progetto open source sotto la Linux Foundation, contribuito da Google. È concesso in licenza secondo la [Apache License 2.0](LICENSE) ed è aperto ai contributi della comunità.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---
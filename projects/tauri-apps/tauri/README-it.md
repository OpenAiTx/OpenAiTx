<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stabile-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20o%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## Introduzione

Tauri è un framework per costruire binari piccoli e incredibilmente veloci per tutte le principali piattaforme desktop. Gli sviluppatori possono integrare qualsiasi framework front-end che compili in HTML, JS e CSS per costruire la propria interfaccia utente. Il backend dell'applicazione è un binario scritto in Rust con un'API con cui il front-end può interagire.

L'interfaccia utente nelle app Tauri attualmente sfrutta [`tao`](https://docs.rs/tao) come libreria di gestione delle finestre su macOS, Windows, Linux, Android e iOS. Per il rendering dell'applicazione, Tauri utilizza [WRY](https://github.com/tauri-apps/wry), una libreria che fornisce un'interfaccia unificata al webview di sistema, sfruttando WKWebView su macOS & iOS, WebView2 su Windows, WebKitGTK su Linux e Android System WebView su Android.

Per approfondire i dettagli su come tutti questi componenti si integrano, consulta questo documento [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md).

## Per Iniziare

Se sei interessato a creare un'app Tauri, visita il [sito della documentazione](https://tauri.app).

Il modo più veloce per iniziare è installare i [prerequisiti](https://v2.tauri.app/start/prerequisites/) per il tuo sistema e creare un nuovo progetto con [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage). Ad esempio con `npm`:

```sh
npm create tauri-app@latest
```

## Caratteristiche

L'elenco delle funzionalità di Tauri include, ma non è limitato a:

- Bundler integrato per creare pacchetti app in formati come `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` e installer per Windows come `.exe` (tramite NSIS) e `.msi` (tramite WiX).
- Aggiornamento automatico integrato (solo desktop)
- Icone nella system tray
- Notifiche native
- Protocollo Native WebView (tauri non crea un server http(s) localhost per servire i contenuti del WebView)
- GitHub action per CI semplificato
- Estensione per VS Code

### Piattaforme

Tauri attualmente supporta lo sviluppo e la distribuzione sulle seguenti piattaforme:

| Piattaforma | Versioni                                                                                                      |
| :---------- | :------------------------------------------------------------------------------------------------------------ |
| Windows     | 7 e successive                                                                                                |
| macOS       | 10.15 e successive                                                                                            |
| Linux       | webkit2gtk 4.0 per Tauri v1 (ad esempio Ubuntu 18.04). webkit2gtk 4.1 per Tauri v2 (ad esempio Ubuntu 22.04). |
| iOS/iPadOS  | 9 e successive                                                                                                |
| Android     | 7 e successive (attualmente 8 e successive)                                                                   |

## Contribuire

Prima di iniziare a lavorare su qualcosa, è meglio controllare se esiste già una issue. È anche una buona idea passare dal server Discord e confermare con il team se ha senso o se qualcun altro ci sta già lavorando.

Assicurati di leggere la [Guida al Contributo](./.github/CONTRIBUTING.md) prima di effettuare una pull request.

Grazie a tutti coloro che contribuiscono a Tauri!

### Documentazione

La documentazione in un sistema poliglotta è una questione delicata. Per questo preferiamo utilizzare la documentazione inline nel codice sorgente Rust & JS quanto più possibile. Consulta il repository che ospita il sito della documentazione per ulteriori informazioni: <https://github.com/tauri-apps/tauri-docs>

## Partner

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

Per l'elenco completo degli sponsor visita il nostro [sito web](https://tauri.app#sponsors) e [Open Collective](https://opencollective.com/tauri).

## Organizzazione

Tauri mira ad essere un collettivo sostenibile basato su principi che guidano [comunità di software libero e open source sostenibili](https://sfosc.org). A tal fine è diventato un Programma all'interno della [Commons Conservancy](https://commonsconservancy.org/), e puoi contribuire finanziariamente tramite [Open Collective](https://opencollective.com/tauri).

## Licenze

Codice: (c) 2015 - Presente - Il Programma Tauri all'interno della Commons Conservancy.

MIT o MIT/Apache 2.0 dove applicabile.

Logo: CC-BY-NC-ND

- Design originali del logo Tauri di [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) e [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---
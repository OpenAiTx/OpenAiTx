<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Desktop App](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI Support](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## Esempi di Immagini

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## Assicurati di scaricare la Latest Stable Release (LSR) e non l'ultima/LFR! LSR attuale: 2.4.9

`pip install winup==2.4.9`

**Un framework estremamente Pythonic e potente per costruire bellissime applicazioni desktop.**

WinUp è un moderno framework UI per Python che incapsula la potenza di PySide6 (Qt) in una API semplice, dichiarativa e amichevole per gli sviluppatori. È progettato per permetterti di costruire applicazioni più velocemente, scrivere codice più pulito e goderti il processo di sviluppo.

### ✨ Ora con Supporto Web!
WinUp ora supporta anche la creazione di applicazioni web completamente interattive e stateful utilizzando lo stesso approccio Python-centrico basato su componenti. Il modulo web utilizza FastAPI e WebSockets sotto il cofano per portare la semplicità di WinUp nel browser.

[Documentazione Web](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **Disclaimer:** Il supporto web è una funzionalità opzionale. Per utilizzarla, devi installare le dipendenze web:
> ```bash
> pip install "winup[web]"
> ```

[Contribuire](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[Changelog](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[Licenza](LICENSE)

---

## Perché WinUp? (Invece di PySide6 puro o Tkinter)

Lo sviluppo desktop in Python può risultare macchinoso. WinUp è stato creato per risolvere questo problema.

| Caratteristica           | WinUp Way ✨                                                                   | PySide6 / Tkinter Puro 😟                                                               |
| ----------------------- | ------------------------------------------------------------------------------ | --------------------------------------------------------------------------------------- |
| **Layouts**             | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`              |
| **Stilizzazione**       | `props={"background-color": "blue", "font-size": "16px"}`                      | Stringhe QSS manuali, `widget.setStyleSheet(...)`, oggetti stile complessi.             |
| **Gestione Stato**      | `state.bind(widget, "prop", "key")`                                            | Callback manuali, getters/setters, `StringVar()`, boilerplate ovunque.                  |
| **Two-Way Binding**     | `state.bind_two_way(input_widget, "key")`                                      | Non esistente. Richiede handler `on_change` manuali per aggiornare stato e UI.          |
| **Strumenti Dev**       | **Hot Reloading integrato**, profiler, strumenti finestra inclusi.             | Non presenti. Riavvia l'intera app per ogni cambiamento UI.                             |
| **Struttura Codice**    | Componenti riutilizzabili e autonomi con `@component`.                         | Spesso porta a classi monolitiche o script procedurali.                                 |

**In breve, WinUp offre le "killer feature" dei moderni framework web (come React o Vue) per il desktop, facendoti risparmiare tempo e permettendoti di concentrarti su ciò che conta: la logica della tua applicazione.**

# 🧊 WinUp vs 🧱 PyEdifice (Richiesta Utente Reddit)

| Caratteristica                   | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 Architettura                  | Stile React + stato         | Stile React + stato              |
| 🌐 Routing Integrato             | ✅ Sì (`Router(routes={...})`)       | ❌ Nessun routing integrato       |
| ♻️ Lifecycle Hooks               | ✅ `on_mount`, `on_unmount`, ecc.    | ⚠️ Limitato (`did_mount`, ecc.)  |
| 🎨 Sistema Temi/Stili            | ✅ Temi globali & scoped             | ❌ CSS manuale                    |
| 🔲 Opzioni Layout                | ✅ Row, Column, Grid, Stack, Flexbox | ⚠️ Principalmente Box & HBox/VBox |
| 🎞️ Animazioni                   | ✅ Integrate (fade, scale, ecc.)     | ❌ Nessuna integrata              |
| 🔁 Hot Reloading (LHR)           | ✅ Stabile + veloce (`loadup dev`)   | ⚠️ Sperimentale, supporto limitato|
| 📦 Packaging                     | ✅ Con LoadUp (basato su PyInstaller)| ❌ PyInstaller da integrare manualmente |
| 🧩 Riutilizzo Componenti         | ✅ Alto, dichiarativo                | ✅ Alto                           |

| 🛠 Strumenti per Sviluppatori       | ✅ DevTools pianificati, Inspector presto | ❌ Nessuno al momento                |
| 📱 Supporto Mobile                 | ❌ Non ancora supportato                  | ❌ Non supportato                    |
| 🧠 Curva di Apprendimento          | ✅ Facile per utenti Python+React         | ✅ Facile ma meno strumenti          |

> ✅ = Integrato o robusto  
> ⚠️ = Parziale o limitato  
> ❌ = Mancante completamente
---

## Funzionalità Principali

*   **UI Dichiarativa & Pythonica:** Costruisci layout complessi con semplici oggetti `Row` e `Column` invece di layout a scatola complicati.
*   **Architettura Basata su Componenti:** Usa il decoratore `@component` per creare widget UI modulari e riutilizzabili da semplici funzioni.
*   **Potente Sistema di Stili:** Stila i tuoi widget con semplici dizionari Python tramite `props`. Crea classi globali "simili al CSS" con `style.add_style_dict`.
*   **Shell Applicativa Completa:** Crea applicazioni professionali con API dichiarativa per `MenuBar`, `ToolBar`, `StatusBar` e `SystemTrayIcon`.
*   **Gestore di Task Asincroni:** Esegui operazioni di lunga durata in background senza bloccare la UI usando il semplice decoratore `@tasks.run`.
*   **Performance di Default:** Include il decoratore opzionale `@memo` per memorizzare i rendering dei componenti ed evitare ricalcoli inutili.
*   **Estendibilità Avanzata:**
    *   **Widget Factory:** Sostituisci qualsiasi widget di default con una tua implementazione personalizzata (es. basata su C++) usando `ui.register_widget()`.
    *   **Finestre Multiple:** Crea e gestisci più finestre indipendenti per applicazioni complesse come palette strumenti o lettori musicali.
*   **Gestione Stato Reattiva:**
    *   **Binding a Senso Unico:** Aggiorna automaticamente la tua UI quando i dati cambiano con `state.bind()`.
    *   **Binding a Doppio Senso:** Sincronizza facilmente i widget di input con lo stato tramite `state.bind_two_way()`.
    *   **Sottoscrizioni:** Attiva qualsiasi funzione in risposta a cambiamenti di stato con `state.subscribe()`.
*   **Strumenti per Sviluppatori:**
    *   **Hot Reloading:** Vedi subito i cambiamenti della UI senza riavviare l’app.
    *   **Profiler:** Misura facilmente la performance di qualsiasi funzione con il decoratore `@profiler.measure()`.
    *   **Window Tools:** Centra, lampeggia o gestisci la finestra della tua applicazione con semplicità.
*   **Routing Integrato:** Crea facilmente applicazioni multi-pagina con un router intuitivo basato sullo stato.
*   **Layer Dati Flessibile:** Include connettori semplici e coerenti per SQLite, PostgreSQL, MySQL, MongoDB e Firebase.

---

# Documentazione

Approfondisci le funzionalità di WinUp:

## Concetti Base
- [**Modello a Componenti & Styling**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**Gestione dello Stato**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**Lifecycle Hooks**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**Routing**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**Posizionamento Assoluto (Avanzato)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## Strumenti per Sviluppatori
- [**Live Hot Reload (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**Performance Profiler**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**Memoization**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**Async Task Runner**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## Componenti UI
- [**Libreria Componenti Completa**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## Contribuire

WinUp è un progetto open-source. I contributi sono i benvenuti!

## Licenza

Questo progetto è distribuito sotto licenza MIT. Vedi **LICENSE** per maggiori informazioni.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---
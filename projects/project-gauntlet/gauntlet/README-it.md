# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

Launcher di applicazioni cross-platform web-first con plugin basati su React

> [!WARNING]
> Il launcher è sviluppato da un singolo sviluppatore nel suo tempo libero.
> I cambiamenti possono essere lenti ma costanti
>
> Ci saranno probabilmente cambiamenti che rompono la compatibilità e saranno documentati nel [changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md).

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## Demo

Demo leggermente datata

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## Funzionalità

- Plugin-first
  - I plugin sono scritti in TypeScript
  - API plugin estensiva
      - Creazione di viste UI
      - Comandi one-shot
      - Fornire dinamicamente una lista di comandi one-shot
      - Visualizzare contenuti rapidi "inline" direttamente sotto la barra di ricerca principale in base al valore inserito
      - Ottenere contenuto dalla Clipboard e aggiungerlo
  - I plugin sono distribuiti come branch separato nel repository Git, quindi la distribuzione dei plugin non richiede un server centrale
  - Gli ID dei plugin sono semplicemente URL di repository Git
  - UI per i plugin basata su [React](https://github.com/facebook/react)
    - Implementata usando un React Reconciler personalizzato (no Electron)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno consente di sandboxare il codice JavaScript del plugin per una maggiore sicurezza
    - I plugin devono specificare esplicitamente i permessi necessari per funzionare
    - Node.js è usato per gli strumenti di sviluppo dei plugin, ma come sviluppatore scriverai sempre codice che gira su Deno
- Progettato fin dall'inizio con il cross-platform in mente
- Comandi e Viste possono essere avviati/aperti usando scorciatoie globali personalizzate
- Alias di ricerca personalizzati possono essere assegnati a Comandi o Viste
- Supporto tema personalizzato
- Funzionalità integrate fornite da plugin inclusi
  - Applicazioni: mostra le applicazioni installate sul sistema nei risultati di ricerca
    - Il plugin tiene traccia anche delle finestre e a quale applicazione appartengono, quindi aprendo un'applicazione già aperta si porterà in primo piano la finestra già creata
      - Non tutti i sistemi sono attualmente supportati. Vedi [supporto funzionalità](https://gauntlet.sh/docs/feature-support)
  - Calcolatrice: mostra il risultato delle operazioni matematiche direttamente sotto la barra di ricerca principale
    - Include la conversione valutaria usando tassi di cambio
    - Basato su [Numbat](https://github.com/sharkdp/numbat)
- Ordinamento dei risultati di ricerca basato su Frecency
   - La Frecency è una combinazione di frequenza e recenza
   - Più spesso l'elemento viene usato, più in alto apparirà nei risultati, ma gli elementi usati molto in passato saranno classificati più in basso rispetto a quelli usati di recente lo stesso numero di volte
   - I risultati vengono abbinati per parola tramite sottostringa

##### Supporto OS

##### Ufficiale
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### Best-effort
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland non è ancora supportato, vedi [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## Per iniziare

### Installa Gauntlet

Vedi [Installazione](https://gauntlet.sh/docs/installation)

### Scorciatoia Globale

La finestra principale può essere aperta usando una scorciatoia globale o un comando CLI:
- Scorciatoia Globale (modificabile nelle Impostazioni)
  - Windows: <kbd>ALT</kbd> + <kbd>Space</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Space</kbd>
  - Linux Wayland
    - La scorciatoia globale potrebbe non essere supportata, vedi [supporto funzionalità](https://gauntlet.sh/docs/feature-support)
    - Si prega di usare invece il comando CLI e richiamarlo secondo le modalità specifiche del window manager
  - macOS: <kbd>CMD</kbd> + <kbd>Space</kbd>
- Comando CLI
  - `gauntlet open`

### Installa plugin

I plugin vengono installati tramite l'interfaccia delle Impostazioni. Usa l'URL del repository Git del plugin per installarlo, ad esempio `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### Crea il tuo plugin

Vedi [Guida allo sviluppo plugin](https://gauntlet.sh/docs/plugin-development/getting-started)

## Temi

Vedi [Theming](https://gauntlet.sh/docs/theming)

## Compilare Gauntlet

È necessario:
- NodeJS
- Rust
- Protobuf Compiler
- CMake (non usato direttamente dal progetto, ma richiesto da una dipendenza)
- Su Linux: `libxkbcommon-dev` (nota: il nome può variare a seconda della distribuzione)

### Dev

Per compilare in dev esegui:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
In modalità dev (senza la feature "release") l'applicazione userà SOLO directory all'interno della directory del progetto per memorizzare stato o cache, per evitare di interferire con installazioni globali

### Non ancora pacchettizzato

Per compilare un binario di release non ancora pacchettizzato, esegui:
```bash
npm ci
npm run build
cargo build --release --features release
```

### Pacchettizzato
Per compilare il pacchetto specifico per il sistema operativo, esegui uno dei seguenti:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

Ma il rilascio delle nuove versioni deve essere fatto tramite GitHub Actions

## Contribuire

Se vuoi aiutare a sviluppare Gauntlet puoi farlo in più modi oltre al semplice contributo di codice:
- Segnalare un bug o un problema UI/UX
- Creare un plugin

Per problemi semplici sentiti libero di aprire una issue o una PR e risolverlo tu stesso.
Per cambiamenti più significativi contatta gli autori su Discord (link di invito in cima al README) e discuti prima.

Tutti i contributi sono benvenuti.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---
<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">Dettatura senza interruzioni alimentata dal modello Whisper di OpenAI</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## Informazioni

Whispering è un'applicazione open-source di trascrizione che offre funzionalità di conversione da voce a testo a livello globale, con opzioni come scorciatoie da tastiera e copia/incolla automatico per rendere la dettatura il più fluida possibile.

Alla base, è alimentato dal modello Whisper di OpenAI, che lo rende significativamente più accurato rispetto alla dettatura integrata.

> **Nota Importante**: Whispering è pensato principalmente come strumento di trascrizione, non come strumento di registrazione. Per registrazioni più lunghe in cui l'affidabilità è fondamentale, si consiglia di utilizzare un'app dedicata sul telefono o sul dispositivo che utilizzi API di registrazione native. Questo garantisce qualità audio ottimale e stabilità della registrazione.

## Demo

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## Caratteristiche principali

1. **Trascrizione globale**: Accedi alla funzionalità di conversione da voce a testo di Whisper ovunque tramite una scorciatoia da tastiera globale o con due clic.
2. **Esperienza multipiattaforma**:
   - App desktop: Abilita la trascrizione globale su tutte le applicazioni.
   - Estensione browser: Fornisce trascrizione globale nel browser comunicando con l'app web.
3. **Integrazione chat**: L'estensione browser aggiunge un pulsante di registrazione ai siti ChatGPT e Claude, consentendo l'input vocale diretto e la trascrizione nell'interfaccia di chat.
4. **Gestione trascrizioni**: Rivedi e modifica le trascrizioni all'interno dell'app Whispering per garantire accuratezza e chiarezza.
5. **Integrazione automatica con clipboard**: Una volta completata la trascrizione, il testo viene automaticamente copiato negli appunti. È disponibile anche l'opzione per l'incolla automatico.

## Come vengono archiviati i miei dati?

Whispering memorizza localmente sul tuo dispositivo il maggior numero possibile di dati, incluse registrazioni e trascrizioni testuali. Questo approccio garantisce la massima privacy e sicurezza dei dati. Ecco una panoramica della gestione dei dati:

1. **Archiviazione locale**: Le registrazioni vocali e le trascrizioni vengono archiviate in IndexedDB, utilizzata come storage blob e come luogo per memorizzare tutti i tuoi dati come testo e trascrizioni.

2. **Servizio di trascrizione**: L'unico dato inviato all'esterno è la tua registrazione a un servizio di trascrizione esterno—se scegli di utilizzarne uno. Hai le seguenti opzioni:
   - Servizi esterni come OpenAI o Groq
   - Un servizio di trascrizione locale come `faster-whisper-server`, che mantiene tutto sul dispositivo

3. **Impostazioni configurabili**: Puoi cambiare il servizio di trascrizione nelle impostazioni per garantire la massima funzionalità locale.


## Installazione

### App Web

Visita [whispering.bradenwong.com](https://whispering.bradenwong.com/), che ospita l'ultima versione della cartella `apps/app` su Vercel.

### Estensione Chrome

Installa l'estensione Chrome dal Chrome Web Store [qui](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo).

### App Desktop

Per scaricare e installare l'app desktop Whispering, segui i passaggi per il tuo sistema operativo:

#### Windows

1. Scarica il pacchetto di installazione con estensione `.msi` dalla [pagina degli ultimi rilasci](https://github.com/braden-w/whispering/releases).
2. Apri il file `.msi` scaricato per avviare l'installazione.
3. Se viene segnalato come non sicuro, clicca su `Ulteriori informazioni` -> `Esegui comunque` per procedere.
4. Segui le istruzioni a schermo per completare l'installazione.

#### macOS

Per macOS, segui questi passaggi per installare Whispering:

1. **Scarica il pacchetto di installazione**:
   - Visita la [pagina degli ultimi rilasci](https://github.com/braden-w/whispering/releases).
   - Scegli il pacchetto appropriato:
     - Per Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - Per Intel: `Whispering_x.x.x_x64.dmg`

2. **Installa l'applicazione**:
   - Apri il file `.dmg` scaricato.
   - Trascina l'app Whispering nella cartella Applicazioni.

3. **Avvia Whispering**:
   - Apri Whispering dalla cartella Applicazioni.
   - Se visualizzi un avviso su sviluppatore non verificato:
     - Clicca su `Annulla`
     - Fai clic destro sull'app in Finder e seleziona `Apri`

4. **Risoluzione problemi** (solo Apple Silicon):
   Se riscontri l'errore `"Whispering" è danneggiato e non può essere aperto`:
   - Apri Terminale
   - Esegui il seguente comando:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - Prova ad aprire di nuovo l'applicazione

Dopo aver completato questi passaggi, Whispering dovrebbe essere pronta all'uso su macOS.

#### Linux

Per Linux, sono disponibili diverse opzioni di installazione. Scegli quella più adatta al tuo ambiente:

1. **AppImage**:

   - Scarica il file `.AppImage` dalla [pagina degli ultimi rilasci](https://github.com/braden-w/whispering/releases).
   - Rendi il file eseguibile:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - Esegui l'AppImage:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **Pacchetto DEB (Debian/Ubuntu)**:
   - Scarica il file `.deb` dalla [pagina degli ultimi rilasci](https://github.com/braden-w/whispering/releases).
   - Installa il pacchetto usando `dpkg`:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - Risolvi eventuali dipendenze:
     ```bash
     sudo apt-get install -f
     ```

Dopo l'installazione, l'app sarà pronta all'uso.

## Utilizzo

### Estensione Chrome

Dopo aver installato l'estensione Chrome, troverai un'icona di Whispering nella barra delle estensioni di Chrome. Clicca su questa icona per aprire l'estensione. Premi il pulsante del microfono per registrare la tua voce, quindi premi il pulsante quadrato quando hai finito. La trascrizione apparirà nel box di testo sottostante.

Per accedere alla funzione ChatGPT o Claude, vai alla pagina web di ChatGPT o Claude. Vedrai un nuovo pulsante di registrazione nell'interfaccia di chat. Premi questo pulsante per avviare e fermare la registrazione e il testo trascritto verrà inserito automaticamente nel campo di input della chat.

Per utilizzare la funzione di scorciatoia, premi <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> o <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (configurabile successivamente tramite le scorciatoie dell'estensione Chrome) per iniziare a registrare da qualsiasi sito web. La trascrizione verrà automaticamente copiata negli appunti e incollata nel campo di input corrente.

L'estensione Chrome comunica con [whispering.bradenwong.com](https://whispering.bradenwong.com) e cercherà automaticamente di creare una scheda in background se non ne trova una. La maggior parte dei problemi può essere attribuita a un malfunzionamento di questa comunicazione, come rari casi in cui la scheda va in sospensione.

### App Web

L'app web è accessibile tramite [whispering.bradenwong.com](https://whispering.bradenwong.com). Premi il pulsante del microfono per registrare la tua voce, quindi premi il pulsante quadrato quando hai finito. La trascrizione apparirà nel box di testo.

### App Desktop

Dopo aver installato l'app desktop Whispering, premi <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (configurabile nelle impostazioni) per iniziare a registrare da qualsiasi punto del desktop. La trascrizione verrà automaticamente copiata negli appunti e incollata, sebbene entrambe le funzioni possano essere attivate/disattivate nelle impostazioni.

## Realizzato con

#### Web e Desktop

L'app Whispering è costruita con le seguenti tecnologie e librerie:

- [Svelte 5](https://svelte.dev): La libreria di reattività UI scelta.
- [SvelteKit](https://kit.svelte.dev/docs): Per il routing e la generazione di siti statici, utilizzato sia per il sito web che per il frontend statico dell'app Tauri.
- [Tauri](https://tauri.studio/en/docs/intro/): Il framework per l'app desktop.
- [Effect-TS](https://github.com/Effect-TS/effect): Per aggiungere programmazione funzionale e scrivere funzioni estremamente type-safe, dove gli errori sono inclusi nel tipo di ritorno della funzione.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Una semplice libreria di toast personalizzabile per applicazioni Svelte. Utilizzata per catturare e mostrare errori propagati tramite Effect-TS usando la funzione `renderAsToast`.
- [TanStack Table](https://tanstack.com/table): Per alimentare tutte le tabelle dati.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): Un'API di basso livello per l'archiviazione di grandi quantità di dati strutturati nel browser. Sincronizzata con Tanstack Table.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): La libreria di componenti UI scelta.
- [TailwindCSS](https://tailwindcss.com/docs): Un framework CSS utility-first per costruire rapidamente interfacce utente personalizzate.
- [Turborepo](https://turborepo.org/): Per la gestione del monorepo, così che `apps/app` e `apps/extension` possano condividere la stessa codebase, riducendo drasticamente la duplicazione di codice e, soprattutto, mantenendo una singola fonte di verità.
- [Rust](https://www.rust-lang.org): Per estendere le funzionalità dell'app desktop, come l'utilizzo del crate `enigo` per la gestione dell'incolla automatico.
- [Vercel](https://vercel.com/): Hosting adatto a progetti hobbistici e con buone integrazioni Turborepo.
- [Zapsplat.com](https://www.zapsplat.com/): Una libreria di effetti sonori royalty-free.

#### Estensione

L'estensione Chrome Whispering è costruita utilizzando:

- [Plasmo](https://docs.plasmo.com/): Un framework per la creazione di estensioni Chrome. Usiamo il [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) per comunicare con il sito Whispering.
- [Effect-TS](https://github.com/Effect-TS/effect): Per aggiungere programmazione funzionale e scrivere funzioni estremamente type-safe, dove gli errori sono inclusi nel tipo di ritorno della funzione.
- [React](https://reactjs.org): La libreria di reattività UI per l'estensione Chrome, poiché Plasmo purtroppo non supporta Svelte 5.
- [ShadCN](https://github.com/shadcn): La libreria di componenti UI per l'estensione Chrome.
- [TailwindCSS](https://tailwindcss.com/docs): Un framework CSS utility-first per costruire rapidamente interfacce utente personalizzate.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): L'API delle estensioni di Chrome.
- [Zapsplat.com](https://www.zapsplat.com/): Una libreria di effetti sonori royalty-free.

## Esegui Whispering in modalità di sviluppo locale

Per configurare il progetto sulla tua macchina locale, segui questi passaggi:

1. Clona il repository: `git clone https://github.com/braden-w/whispering.git`
2. Entra nella directory del progetto: `cd whispering`
3. Installa le dipendenze necessarie: `pnpm i`

Per eseguire l'app desktop e il sito web di Whispering in modalità di sviluppo:

4. Entra nella directory dell'app: `cd apps/app`
5. Avvia il server di sviluppo: `pnpm tauri dev`

L'app desktop dovrebbe aprirsi automaticamente per lo sviluppo locale. Per sviluppare l'app web, apri il tuo browser e vai su `http://localhost:5173`.

Per eseguire l'estensione Chrome di Whispering in modalità di sviluppo:

4. Entra nella directory dell'estensione: `cd apps/extension`
5. Avvia il server di sviluppo: `pnpm dev --target=chrome-mv3`

Per sviluppare l'estensione Chrome, caricala in Chrome andando su `chrome://extensions`, abilitando la modalità sviluppatore e caricando la cartella `apps/extension/build/{platform}-{manifest-version}-dev` come estensione non impacchettata.

## Compila l'eseguibile autonomamente

Se hai dubbi riguardo l'affidabilità degli installer o desideri avere più controllo, puoi sempre compilare l'eseguibile autonomamente. Questo richiede una configurazione aggiuntiva, ma garantisce che tu stia eseguendo il codice che ti aspetti. Questa è la bellezza del software open-source!

### Chrome

1. Entra nella directory dell'estensione: `cd apps/extension`
2. Installa le dipendenze necessarie: `pnpm i`
3. Esegui la build di Plasmo: `pnpm plasmo build --target=chrome-mv3`
4. L'output si troverà in `apps/extension/build/chrome-mv3-prod`, che può essere caricato in Chrome come estensione non impacchettata.
5. In alternativa, puoi compilare l'estensione per il Chrome Web Store: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. Entra nella directory dell'estensione: `cd apps/extension`
2. Installa le dipendenze necessarie: `pnpm i`
3. Esegui la build di Plasmo: `pnpm plasmo build --target=firefox-mv3`
4. L'output si troverà in `apps/extension/build/firefox-mv3-prod`, che può essere caricato in Chrome come estensione non impacchettata.
5. In alternativa, puoi compilare l'estensione per il Chrome Web Store: `pnpm plasmo build --target=firefox-mv3 --release`

### Desktop

1. Entra nella directory dell'app: `cd apps/app`
2. Installa le dipendenze necessarie: `pnpm i`
3. Esegui la build di Tauri: `pnpm tauri build`
4. Puoi trovare l'eseguibile nella cartella `apps/app/target/release`.

## Contribuire

Accogliamo con piacere contributi dalla community! Se desideri contribuire a Whispering, segui questi passaggi:

1. Fai un fork del repository.
2. Crea un nuovo branch per la tua funzionalità o bugfix: `git checkout -b feature/your-feature-name` oppure `git checkout -b fix/your-bugfix-name`
3. Apporta le tue modifiche e falle il commit con un messaggio descrittivo.
4. Fai il push del tuo branch sul tuo fork: `git push origin your-branch-name`
5. Crea una pull request dal tuo fork al repository originale.

Assicurati che il tuo codice segua le convenzioni stabilite e sia ben documentato.

## Licenza

Whispering è rilasciato sotto [Licenza MIT](https://opensource.org/licenses/MIT).

## Sponsor

Questo progetto è supportato dalle seguenti persone e organizzazioni straordinarie:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## Supporto e feedback

Se riscontri problemi o hai suggerimenti per miglioramenti, apri una issue sulla [scheda GitHub issues](https://github.com/braden-w/whispering/issues) o contattami via [whispering@bradenwong.com](mailto:whispering@bradenwong.com). Apprezzo davvero il tuo feedback!

Grazie per aver scelto Whispering e buona scrittura!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---
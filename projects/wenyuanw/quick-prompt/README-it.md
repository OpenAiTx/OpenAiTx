# Quick Prompt

<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

Un'estensione potente per browser, focalizzata sulla gestione dei prompt e sull'inserimento rapido. Aiuta gli utenti a creare, gestire e organizzare una libreria di prompt e inserire rapidamente i contenuti preimpostati in qualsiasi campo di input su una pagina web, migliorando l'efficienza lavorativa.

> Poiché le estensioni del browser funzionano solo sul web, è stato reso open source anche un [plugin Raycast](https://github.com/wenyuanw/quick-prompt-raycast) con le stesse funzionalità, compatibile con il formato dati dell'estensione browser e supporta la migrazione fluida tramite gli stessi dati JSON.

## ✨ Caratteristiche

- 📚 **Gestione prompt**: crea, modifica e gestisci facilmente la tua libreria di prompt
- 🚀 **Inserimento rapido**: attiva velocemente il selettore dei prompt in qualsiasi campo di input web con `/p`
- ⌨️ Supporta la configurazione di scorciatoie per aprire il selettore prompt e salvare il testo selezionato come prompt
- 📑 Supporta il salvataggio diretto del testo selezionato come prompt tramite il menu contestuale
- 🎯 Supporta prompt personalizzati, inclusi categorie, titolo, contenuto, tag e variabili
- 🧑‍💻 **Supporto variabili**: nei prompt puoi usare variabili in formato `{{nome_variabile}}`, da compilare all'uso
- 💾 **Backup dati**: esporta e importa la libreria dei prompt per una facile migrazione e backup su più dispositivi
- 🔗 **Sincronizzazione Notion**: supporta la sincronizzazione della libreria dei prompt con un database Notion
- 🔍 Supporta ricerca e filtro dei prompt
- 🌙 Adattamento automatico al tema chiaro/scuro del sistema

## ⚠️ Problemi noti

- Su doubao.com, dopo aver attivato il selettore prompt con `/p`, alcuni campi di input non eliminano correttamente `/p`. Non preoccuparti, io e il mio fidato partner Cursor stiamo lavorando giorno e notte per risolvere il problema il prima possibile!

## 🚀 Come si usa

1. **Attivazione rapida**: digita `/p` in qualsiasi campo di testo di una pagina web per attivare il selettore prompt
2. **Scorciatoia per aprire il selettore**: usa `Ctrl+Shift+P` (Windows/Linux) o `Command+Shift+P` (macOS) per aprire il selettore prompt
3. **Scegli un prompt**: clicca sul prompt desiderato dal selettore a comparsa; verrà inserito automaticamente nel campo di input corrente
4. **Salvataggio rapido prompt**: seleziona qualsiasi testo e usa `Ctrl+Shift+S` (Windows/Linux) o `Command+Shift+S` (macOS) per salvarlo rapidamente come prompt
5. **Salva tramite menu contestuale**: seleziona qualsiasi testo, clicca col tasto destro e scegli "Salva come prompt" per aggiungerlo alla libreria
6. **Esporta libreria prompt**: dalla pagina di gestione, clicca su "Esporta" per salvare tutti i prompt in un file JSON locale
7. **Importa libreria prompt**: dalla pagina di gestione, clicca su "Importa" per caricare prompt da un file JSON locale (supporta unione o sovrascrittura)

## 📸 Anteprima interfaccia

Quick Prompt offre un'interfaccia utente intuitiva e amichevole per gestire e utilizzare i prompt con facilità.

### Selettore prompt

![提示词选择器](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![提示词选择器](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Usando il comando rapido `/p` o la scorciatoia puoi richiamare velocemente il selettore prompt in qualsiasi campo di input, per scegliere e inserire il prompt desiderato.

### Pagina gestione prompt

![提示词管理](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

Nella pagina di gestione puoi creare nuovi prompt, modificare quelli esistenti, aggiungere tag e gestire le categorie. L'interfaccia è semplice e intuitiva.

### Salvataggio tramite menu contestuale

![右键菜单保存](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Basta selezionare qualsiasi testo su una pagina web e con un click destro salvarlo rapidamente come prompt, per aumentare la produttività.

### Inserimento variabili prompt

![提示词变量弹窗](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

I prompt supportano la configurazione delle variabili; dopo la selezione si aprirà una finestra per inserire i valori richiesti.

## ⚙️ Configurazione personalizzata

1. Clicca sull'icona dell'estensione, poi sul pulsante "Gestisci prompt"
2. Nella pagina di gestione, puoi:
   - Aggiungere nuovi prompt
   - Modificare i prompt esistenti
   - Eliminare i prompt non necessari
   - Aggiungere etichette ai prompt per classificarli
   - Esportare la libreria dei prompt per il backup
   - Importare una libreria di prompt precedentemente salvata

## 📦 Guida all’installazione

### Installazione dallo store delle applicazioni

Ora disponibile su Chrome Web Store! [Clicca qui per scaricare e installare](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Scarica da GitHub Releases

1. Visita la [pagina GitHub Releases](https://github.com/wenyuanw/quick-prompt/releases)
2. Scarica l’ultima versione del pacchetto dell’estensione già costruita
3. Estrai i file scaricati
4. Segui le istruzioni qui sotto per installare l’estensione costruita

### Compilazione dal codice sorgente

1. Clona il repository
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. Installazione delle dipendenze
   ```bash
   pnpm install
   ```
3. Sviluppo e costruzione

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```
### Installazione dell'estensione compilata

#### Chrome / Edge
1. Apri la pagina di gestione delle estensioni (`chrome://extensions` o `edge://extensions`)
2. Abilita la "Modalità sviluppatore"
3. Clicca su "Carica estensione non pacchettizzata"
4. Seleziona la directory `.output/chrome-mv3/` del progetto

#### Firefox
1. Apri `about:debugging`
2. Clicca su "Questo Firefox"
3. Clicca su "Carica componente aggiuntivo temporaneo"
4. Seleziona il file `manifest.json` nella directory `.output/firefox-mv2/` del progetto

## 📄 Licenza

MIT

## 🤝 Guida al Contributo

Sono benvenuti Pull Request e Issue!

1. Fai un fork di questo repository
2. Crea il tuo branch delle funzionalità (`git checkout -b feature/amazing-feature`)
3. Esegui il commit delle tue modifiche (`git commit -m 'Add some amazing feature'`)
4. Fai il push del branch (`git push origin feature/amazing-feature`)
5. Apri una Pull Request

## 👏 Elenco dei Contributori

Grazie a tutti gli sviluppatori che hanno contribuito al progetto!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---
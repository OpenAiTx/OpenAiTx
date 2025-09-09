
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Disegno Magico con AI

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![Licenza](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Un'applicazione di disegno AI sviluppata con Next.js, con le seguenti funzionalità principali:
- 🎨 Supporto per molteplici modelli AI (Sora, DALL-E, GPT, GEMINI, ecc.) e aggiunta di modelli personalizzati
- 🖼️ Funzioni di generazione da testo a immagine e da immagine a immagine, con supporto per riferimento multiplo e modifica per aree
- 🔐 Tutti i dati e le chiavi API sono memorizzati localmente, garantendo la sicurezza della privacy
- 💻 Supporto per versione web e pacchettizzazione desktop, utilizzo multipiattaforma

## Esperienza online

Indirizzo di accesso: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Screenshot dell'applicazione

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="Screenshot App 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="Screenshot App 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="Screenshot App 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="Screenshot App 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="Screenshot App 3" width="800" style="margin-bottom: 20px"/>
</div>

## Caratteristiche principali

- 🎨 Supporto per molteplici modelli AI
  - Modello GPT Sora_Image
  - Modello GPT 4o_Image
  - Modello GPT Image 1
  - Modello DALL-E 3
  - Modello GEMINI
  - 🆕 Modelli personalizzati (supporto per l'aggiunta di modelli privati)
- 🔄 Cambio tra modelli multipli
  - Supporto per passaggio rapido tra diversi modelli
  - Ogni modello ha opzioni di configurazione indipendenti
- ✍️ Funzione testo-immagine
  - Supporto per prompt personalizzati
  - Possibilità di scegliere il rapporto dell'immagine
  - Supporto per diverse dimensioni immagine
- 🖼️ Funzione immagine-immagine
  - Supporto per modifica immagini
  - Supporto per modifica tramite maschere di area
  - Supporto per regolazione della qualità dell'immagine
  - Supporto per riferimenti multipli di immagini (caricamento simultaneo di più immagini)
- 🔒 Sicurezza dei dati
  - Tutte le immagini generate e la cronologia sono salvate solo nel browser locale
  - Supporto per indirizzo proxy API personalizzato
  - Supporto per configurazione API Key
- 📱 Design dell'interfaccia utente
  - Interfaccia utente moderna
  - Esperienza di interazione fluida
  - Visualizzazione in formato Markdown
  - Supporto per evidenziazione del codice
- 🖥️ Supporto multipiattaforma
  - Supporto per il packaging come applicazione desktop (Windows, macOS, Linux)
  - Supporto per l'uso offline (richiede la configurazione dell'API)

## Stack Tecnologico

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (packaging applicazione desktop)

## Sviluppo Locale

1. Clona il progetto
```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. Installazione delle dipendenze

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. Avvia il server di sviluppo

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. Visita [http://localhost:3000](http://localhost:3000)

## Pacchettizzazione dell'applicazione desktop

Questo progetto utilizza Tauri per la creazione di pacchetti desktop, supportando sistemi Windows, macOS e Linux.

### Preparazione dell'ambiente

Prima di impacchettare l'app desktop, è necessario installare le seguenti dipendenze:

1. **Installa Rust**:
   - Visita [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - Segui le istruzioni per installare Rust e Cargo

2. **Dipendenze di sistema**:
   - **Windows**: Installa [Visual Studio C++ Build Tools](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: Installa gli strumenti da riga di comando Xcode (`xcode-select --install`)
   - **Linux**: Installa le dipendenze necessarie, vedi [Documentazione Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)

### Modalità di sviluppo


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### Creazione di applicazioni desktop


```bash
# 构建桌面应用安装包
npm run desktop
```
Dopo la compilazione, è possibile trovare il pacchetto di installazione per il sistema corrispondente nella directory `src-tauri/target/release/bundle`.

## Deploy su Vercel

1. Fai il fork di questo progetto sul tuo account GitHub

2. Crea un nuovo progetto su [Vercel](https://vercel.com)

3. Importa il tuo repository GitHub

4. Clicca su deploy

## Istruzioni per l'uso

1. Al primo utilizzo è necessario configurare la chiave API
   - Clicca su "Impostazioni chiave" in alto a destra
   - Inserisci la chiave API e l'indirizzo di base
   - Clicca su salva
   - Puoi anche configurare velocemente tramite parametri nell'URL:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     Nota: i caratteri speciali nell'URL devono essere codificati come URL

2. Scegli la modalità di generazione
   - Testo in immagine: genera immagini tramite descrizione testuale
   - Immagine in immagine: carica un'immagine per modificarla

3. Imposta i parametri di generazione
   - Seleziona il modello AI (modello integrato o personalizzato)
   - Imposta il rapporto dell'immagine
   - Regola la qualità dell'immagine (modalità immagine in immagine)

4. Gestione dei modelli personalizzati
   - Clicca sull'icona delle impostazioni accanto al selettore dei modelli
   - Aggiungi nuovo modello: inserisci nome, valore e tipo del modello
   - Modifica modello: clicca sul pulsante di modifica di un modello esistente
   - Elimina modello: clicca sul pulsante di eliminazione di un modello esistente
   - Seleziona modello: clicca sul pulsante con il segno più per selezionare e usare subito il modello

5. Spiegazione dei tipi di modelli
   - Formato DALL-E: utilizza l'interfaccia di generazione immagini (/v1/images/generations)
   - Formato OpenAI: utilizza l'interfaccia chat (/v1/chat/completions)

6. Genera immagini
   - Inserisci le parole chiave
   - Clicca sul pulsante "Genera immagine"
   - Attendi il completamento della generazione

7. Gestione immagini
   - Visualizza la cronologia
   - Scarica le immagini generate
   - Modifica immagini esistenti

## Avvertenze

- Tutte le immagini generate e la cronologia sono salvate solo nel browser locale
- L'uso della modalità privata o il cambio dispositivo può causare la perdita dei dati
- Scarica e fai regolarmente backup delle immagini importanti
- La configurazione API sarà memorizzata in modo sicuro nel tuo browser e non sarà caricata sul server
- Il caricamento di risorse HTTP su siti HTTPS verrà bloccato dal browser, l'app convertirà automaticamente le API HTTP in HTTPS

## Guida ai contributi

Sei il benvenuto a inviare Issue e Pull Request per aiutare a migliorare il progetto.

## Licenza

Questo progetto utilizza la licenza [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

In base alla licenza, puoi:
- ✅ Uso commerciale: puoi utilizzare il software per scopi commerciali
- ✅ Modifica: puoi modificare il codice sorgente del software
- ✅ Distribuzione: puoi distribuire il software
- ✅ Uso privato: puoi utilizzare il software privatamente
- ✅ Autorizzazione brevetti: questa licenza fornisce anche l'autorizzazione sui brevetti

Ma devi rispettare le seguenti condizioni:
- 📝 Dichiarazione di licenza e copyright: devi includere la licenza originale e la dichiarazione di copyright
- 📝 Dichiarazione delle modifiche: devi dichiarare le modifiche significative al codice originale
- 📝 Dichiarazione dei marchi: non puoi utilizzare i marchi dei contributori

---

## Offrimi un caffè

Se questo progetto ti è stato utile, sei il benvenuto a offrirmi un caffè ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="Codice pagamento WeChat" width="300" />
  <p>Offrimi un caffè</p>
</div>

## Contatti

Se hai domande o suggerimenti, sei il benvenuto a contattarmi tramite WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="Contatto WeChat" width="300" />
  <p>Scansiona il codice QR per aggiungere WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---
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

# Magia AI Disegno

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Un'applicazione di disegno AI sviluppata su Next.js, con le seguenti funzionalità principali:
- 🎨 Supporta vari modelli AI (Sora, DALL-E, GPT, ecc.) e aggiunta di modelli personalizzati
- 🖼️ Fornisce funzionalità testo-immagine e immagine-immagine, supporta riferimenti multipli e modifica per area
- 🔐 Tutti i dati e le chiavi API sono archiviati localmente, garantendo la privacy
- 💻 Supporta versione web e pacchettizzazione desktop, utilizzo multipiattaforma

## Esperienza online

Indirizzo di accesso: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Screenshot applicazione

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="Screenshot applicazione 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="Screenshot applicazione 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="Screenshot applicazione 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="Screenshot applicazione 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="Screenshot applicazione 3" width="800" style="margin-bottom: 20px"/>
</div>

## Caratteristiche principali

- 🎨 Supporto per vari modelli AI
  - Modello GPT Sora_Image
  - Modello GPT 4o_Image
  - Modello GPT Image 1
  - Modello DALL-E 3
  - 🆕 Modello personalizzato (supporto per aggiunta di modelli privati)
- ✍️ Funzionalità testo-immagine
  - Supporto per prompt personalizzati
  - Possibilità di scegliere il rapporto immagine
  - Supporto per varie dimensioni immagine
- 🖼️ Funzionalità immagine-immagine
  - Supporto per modifica immagini
  - Supporto per modifica con maschere di area
  - Supporto per regolazione qualità immagine
  - Supporto per riferimenti multipli (caricamento contemporaneo di più immagini)
- 🔒 Sicurezza dei dati
  - Tutte le immagini generate e la cronologia sono salvate solo nel browser locale
  - Supporto per indirizzo proxy API personalizzato
  - Supporto per configurazione API Key
- 📱 Design UI
  - Interfaccia utente moderna
  - Esperienza di interazione fluida
  - Visualizzazione in formato Markdown
  - Supporto evidenziazione codice
- 🖥️ Supporto multipiattaforma
  - Supporta il pacchettizzamento come app desktop (Windows, macOS, Linux)
  - Supporta uso offline (richiede configurazione API)

## Stack tecnologico

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (pacchettizzazione app desktop)

## Sviluppo locale

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
     Nota: i caratteri speciali nell'URL devono essere codificati in URL

2. Seleziona la modalità di generazione
   - Testo in immagine: genera immagini tramite descrizione testuale
   - Immagine in immagine: carica un'immagine per modificarla

3. Imposta i parametri di generazione
   - Seleziona il modello AI (modello integrato o modello personalizzato)
   - Imposta il rapporto dell'immagine
   - Regola la qualità dell'immagine (modalità immagine in immagine)

4. Gestione dei modelli personalizzati
   - Clicca sull'icona delle impostazioni accanto alla casella di selezione del modello
   - Aggiungi nuovo modello: inserisci il nome, il valore del modello e scegli il tipo di modello
   - Modifica modello: clicca il pulsante di modifica del modello esistente
   - Elimina modello: clicca il pulsante di eliminazione del modello esistente
   - Seleziona modello: clicca il pulsante "+" sul modello per selezionarlo immediatamente

5. Descrizione dei tipi di modello
   - Formato DALL-E: utilizza l'API di generazione immagini (/v1/images/generations)
   - Formato OpenAI: utilizza l'API di chat (/v1/chat/completions)

6. Genera immagine
   - Inserisci le parole chiave
   - Clicca sul pulsante "Genera immagine"
   - Attendi il completamento della generazione

7. Gestione delle immagini
   - Visualizza la cronologia
   - Scarica le immagini generate
   - Modifica le immagini esistenti

## Avvertenze

- Tutte le immagini generate e la cronologia sono salvate solo localmente nel browser
- L'uso della modalità privata o il cambio dispositivo causeranno la perdita dei dati
- Scarica e fai il backup tempestivamente delle immagini importanti
- La configurazione dell'API sarà archiviata in modo sicuro nel tuo browser e non verrà caricata sul server
- I siti HTTPS che caricano risorse HTTP saranno bloccati dal browser, l'app convertirà automaticamente le API HTTP in HTTPS

## Guida ai contributi

Sono benvenuti Issue e Pull Request per migliorare il progetto.

## Licenza

Questo progetto è concesso in licenza sotto [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

Secondo la licenza, puoi:
- ✅ Uso commerciale: puoi utilizzare il software a fini commerciali
- ✅ Modifica: puoi modificare il codice sorgente del software
- ✅ Distribuzione: puoi distribuire il software
- ✅ Uso privato: puoi utilizzare il software privatamente
- ✅ Licenza sui brevetti: questa licenza fornisce anche una licenza sui brevetti

Ma devi rispettare le seguenti condizioni:
- 📝 Licenza e dichiarazione di copyright: devi includere la licenza originale e la dichiarazione di copyright
- 📝 Dichiarazione delle modifiche: devi dichiarare modifiche significative al codice originale
- 📝 Dichiarazione sui marchi: non puoi utilizzare i marchi dei contributori

---

## Offrimi un caffè

Se questo progetto ti è stato utile, sei invitato a offrirmi un caffè ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="Codice di pagamento WeChat" width="300" />
  <p>Offrimi un caffè</p>
</div>

## Contatti

Se hai domande o suggerimenti, sentiti libero di contattarmi tramite WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="Contatto WeChat" width="300" />
  <p>Scansiona il codice QR per aggiungere WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---
<h1 align="center">Benvenuto a&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Strumento di continuazione automatica per Cursor, tentativi automatici, conferma automatica, statistiche di utilizzo, strumenti potenziati per Cursor, strumenti di supporto, automazione, impostazioni tema, Cursor Auto Continue Tool, Cursor Auto Retry Tool, Cursor Auto Confirm Tool, Cursor Usage Statistics Tool, Cursor Efficiency Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor dopo 25 chiamate agli strumenti, Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [Homepage](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper è uno strumento di automazione avanzato progettato appositamente per Cursor IDE, in grado di mostrare in tempo reale l'utilizzo, gestire automaticamente il limite di 25 conversazioni, errori di connessione di rete, conferme e altri scenari, migliorando la tua esperienza di sviluppo.

**Video dimostrativo:** [Video dimostrativo di Cursor Auto Helper](https://www.bilibili.com/video/BV1cajKzCEzv/)

Con prompt di alta qualità e una buona pianificazione dei requisiti di progetto, questo programma permette a Cursor di completare automaticamente un progetto senza intervento umano.

> 🔒 **Compatibilità versione**: Attualmente testato e sviluppato sulle versioni Cursor 0.49.6 e Cursor 1.0.0, teoricamente compatibile con le versioni Cursor 0.48.x - 1.0.0.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖 Changelog

- 2025-06-01 Rilasciata la versione v2.3, aggiunta la funzione di impostazione del tema Cursor, ottimizzata la stabilità dell'iniezione del codice, corretta la visualizzazione dell'utilizzo per essere conforme al formato ufficiale
- 2025-05-21 Rilasciata la versione v2.1, architettura rifatta, supporto multipiattaforma, aggiunta la funzione di visualizzazione in tempo reale dell'utilizzo, ecc.
- 2025-04-25 Completata la versione v1.0, gestione automatica del limite di 25 conversazioni, errori di connessione di rete, conferme e altri scenari
- 2025-04-20 Avvio del progetto

## 🌟 Best practice per Cursor Auto Helper

Nota: la documentazione seguente può essere generata con il supporto di AI come Cursor, ma richiede verifica e regolazione manuale.

**STEP 1:** Progettazione dettagliata dei requisiti di sistema del progetto (più chiara è la raccolta dei requisiti, maggiore sarà la qualità del progetto), scrivere prompt di sviluppo di alta qualità **SYSTEM.md**

**STEP 2:** In base a **SYSTEM.md** produrre documentazione di progettazione di sistema di alta qualità **DESIGN.md**

**STEP 3:** In base a **SYSTEM.md** e **DESIGN.md** produrre un piano di sviluppo dettagliato **TODOLIST.md**

**STEP 4:** Utilizzare **Cursor Auto Helper**, specificare **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md**, utilizzare prompt di feedback di continuazione automatica, consentendo a Cursor di completare automaticamente lo sviluppo del progetto secondo il piano, fino a completamento

**Prompt di feedback automatico per Cursor Auto Helper:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md Si prega di seguire rigorosamente il piano di sviluppo in TODOLIST per le funzionalità successive, aggiornando in tempo reale il piano di sviluppo in TODOLIST. Dopo ogni attività completata, chiedimi "Continuare?", fino a quando il progetto non sarà completato e restituirà "Il progetto è stato completato".
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 Istruzioni per l'uso

Si invita a lasciare una stella di supporto; per eventuali domande aprire una [Issue](https://github.com/pen9un/cursor-auto-helper/issues).

### 📝 Descrizione del file di configurazione

Il file di configurazione `config.ini` **serve per personalizzare il comportamento automatizzato** (può essere impostato e testato secondo necessità), supporta le seguenti opzioni:

#### Configurazione di base
```ini
[common]
log_enable = true     # Abilita il log; se non si desidera registrare i log impostare su false

[cursor]
path = C:\Path\To\Cursor.exe  # Percorso di installazione di Cursor IDE; il programma cercherà automaticamente il percorso di Cursor, se non viene trovato sarà visualizzato un messaggio, modificare questa voce se necessario
```

#### Configurazione delle azioni automatiche
Ogni azione automatica ha come prefisso `nome_azione.`, sono supportati i seguenti campi:

- `type`: tipo di azione
  - `click`: clicca sul pulsante
  - `input_and_submit`: inserisce e invia

- `text` / `text_list`: contenuto di testo da abbinare
  - `text`: singola stringa
  - `text_list`: più stringhe separate da |; se il contenuto della pagina contiene una di queste, si attiva l'azione

- `button_selector`: selettore CSS del pulsante da cliccare (necessario solo per tipo `click`)
- `button_text`: testo del pulsante (opzionale, ulteriore restrizione)
- `input_box_selector`: selettore CSS del campo di input (necessario per tipo `input_and_submit`)
- `input_content`: contenuto da inserire automaticamente
- `submit_btn_selector`: selettore CSS del pulsante di invio
- `delay`: ritardo prima dell'esecuzione dell'azione (in millisecondi), utile per attendere il rendering della pagina

##### Esempio di configurazione
```ini
[auto_actions]
# Ritenta automaticamente in caso di errore di connessione
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# dopo 25 chiamate agli strumenti
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "Si prega di continuare"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_continue.delay = 1000

# Conferma automatica di continuazione
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **Nota:**
> 1. Il nome di ogni action (come `action_retry`, `action_continue`) è personalizzabile, ma il prefisso di tutti i campi della stessa action deve essere identico
> 2. Si consiglia di individuare i selettori CSS con gli strumenti di sviluppo del browser per garantire l'accuratezza
> 3. Dopo aver modificato il file di configurazione è necessario riavviare il programma affinché abbia effetto

## 🎯 Scenari di applicazione

### 💼 Sviluppo di dialoghi lunghi
- Gestione automatica del limite di 25 dialoghi, supporta lo sviluppo continuo di dialoghi lunghi, continua automaticamente il flusso di dialogo, migliorando l'efficienza dello sviluppo.

### 👥 Rete instabile
- Rilevamento automatico delle anomalie di rete, tentativi di riconnessione intelligenti, ripristino automatico del dialogo, garantendo la continuità dello sviluppo.

### 🏢 Scenari di conferma
- Riconoscimento intelligente degli scenari di conferma, gestione automatica delle richieste di conferma, riducendo l'intervento umano.

### 📚 Monitoraggio dell'utilizzo
- Conteggio in tempo reale del numero di dialoghi, monitoraggio dell'utilizzo di Cursor, registrazione dei dati di utilizzo e ottimizzazione dell'efficienza.

Visualizzazione dell'utilizzo su terminale:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Visualizzazione dell'utilizzo su Cursor IDE:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟Descrizione delle funzionalità

### 🤖Continua automaticamente dialoghi lunghi
- Gestione automatica del limite di 25 dialoghi di Cursor, supporto per dialoghi multi-turno continui.

### 🎨 Riconnessione automatica
- Rilevamento automatico dei fallimenti di connessione di rete, tentativi di riconnessione intelligenti, monitoraggio in tempo reale dello stato della connessione.

### 📱 Conferma automatica dei prompt
- Riconoscimento intelligente di molteplici scenari di conferma, gestione automatica dei popup di conferma.
- Supporto per contenuti di conferma e risposte personalizzabili, riduzione dell'intervento umano.
- Configurazione flessibile delle regole, adattamento a flussi di sviluppo diversificati.

### 🛍️ Statistiche di utilizzo
- Conteggio in tempo reale del numero di dialoghi e utilizzo, registrazione automatica dei dati.
- Visualizzazione dei dati di utilizzo, facilitando l’analisi e l’ottimizzazione.
- Supporta log colorati su terminale, pannello di utilizzo su IDE, migliorando la fruibilità.

### 💡 Sistema di log
- Log multi-livello (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL), output colorato su terminale.
- File di log generati automaticamente per data, supporto per la registrazione su file e visualizzazione tramite drag & drop.
- Pannello in tempo reale per facilitare il monitoraggio e la tracciabilità da parte degli sviluppatori.

### 🔒 Compatibilità delle versioni e ottimizzazione delle prestazioni
- Sviluppato su Cursor 0.49.6, funzionalità principali testate completamente.
- Ottimizzazione per versioni specifiche, aggiornamenti continui al passo con le nuove versioni di Cursor.
- Elevata stabilità e compatibilità, adatto all’uso in ambienti di produzione.

## 🔮Dimostrazione degli effetti

### 🤖 Continuazione automatica dei dialoghi

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Dimostrazione di completamento automatico su Cursor

Dai requisiti di progetto alla realizzazione completa, senza alcun intervento umano:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝Autore

👤 **pen9un**

* Sito web: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️Supporto

Se pensi che questo progetto sia utile, lascia una ⭐️⭐️ gratuita

## ✨Star History

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 Statistiche di accesso

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---
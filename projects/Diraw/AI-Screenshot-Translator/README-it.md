# AI Screenshot Translator (AI Screenshot Translator)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# Introduzione

Questo strumento, tramite **semplici operazioni di screenshot**, invia l'immagine al modello AI per il riconoscimento e la traduzione del testo, visualizzando il risultato della traduzione in formato HTML interattivo in una finestra indipendente.

Lo strumento supporta **scorciatoie personalizzate, gestione dei risultati su più finestre e funzionamento nella tray di sistema**, migliorando notevolmente l'efficienza della traduzione nel lavoro e nello studio quotidiani.

**Caratteristiche dello strumento**: 1. Traduzione tramite screenshot, avvio con scorciatoia; 2. Screenshot e traduzione a patch, trascinabili e ridimensionabili liberamente, possibilità di creare più gruppi di patch di traduzione; 3. Possibilità di passare al testo originale delle formule per una copia più agevole; 4. Interfaccia API personalizzabile

**Problemi che si vogliono risolvere**: 1. Attualmente la maggior parte degli strumenti di traduzione di documenti sono troppo pesanti; 2. Se si sceglie di copiare e incollare testo da PDF per la traduzione, spesso i blocchi formula sono disordinati o non copiabili; 3. Per i PDF scansionati come immagini, non è possibile copiare il testo

# Demo

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# Visualizzazione della finestra

Finestra di traduzione:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

Finestra di configurazione:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

Per una descrizione più dettagliata delle opzioni di configurazione, consultare l'interno del software oppure visualizzare la pagina web [Suggerimenti](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# Installazione

È possibile scaricare il codice sorgente e avviarlo, oppure andare alla pagina [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) per scaricare l'eseguibile.

### 1. Clonare il repository

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. Creare un ambiente virtuale ed eseguire

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# Piano di aggiornamento

- ~~Aggiunta della finestra GUI per la configurazione dell'API, ottimizzazione della logica di configurazione manuale del file yaml con generazione automatica da parte del software (completato in v0.3.0)~~
- Aggiunta di un sistema di archiviazione per immagini e formule, per un uso successivo facilitato (previsto per v0.4)
- (Altre funzionalità sono benvenute tramite issue o contributi PR)

# Altro

- L'icona del software proviene da [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- Grazie a Gemini 2.5 Flash e DeepSeek-V3-0324 per avermi aiutato a trovare bug

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
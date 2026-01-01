
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# AI Novel Editor

Editor di romanzi assistito da AI basato su PyQt6, offre strumenti professionali per la scrittura come completamento intelligente, gestione progetti, organizzazione dei concetti e altro.

## Installazione

1. Clona il progetto
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Creazione dell'ambiente virtuale
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. Installazione delle dipendenze
```bash
pip install -r requirements.txt
```

4. Eseguire il programma
```bash
python src/main.py
```

## Funzionalità Principali

### Gestione Progetti
- Struttura documentale gerarchica (Opera > Capitolo > Scena)
- Importazione ed esportazione progetti (supporta formati TEXT, MARKDOWN, DOCX, PDF, HTML)
- Backup automatico e controllo delle versioni
- Gestione multi-progetto

### Funzionalità di Completamento AI
- Tre modalità di completamento: completamento automatico, completamento manuale (consigliato: premi Tab una volta per attivare, premi Tab di nuovo per applicare), disabilita completamento
- Tre modalità di contesto:
  - Modalità veloce: contesto leggero, risposta rapida
  - Modalità bilanciata: contesto medio, equilibrio tra qualità e velocità
  - Modalità globale: contesto completo del progetto, effetto ottimale
- Supporto per vari servizi AI: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, ecc.

### Gestione Struttura
- Struttura ad albero visuale della struttura generale
- Ordinamento tramite trascinamento e modifica dei livelli
- Navigazione rapida del documento
- Analisi della struttura generale e suggerimenti di ottimizzazione

### Configurazione API
- Centro di configurazione AI unificato
- Configurazioni preimpostate per più fornitori di servizi
- Funzione di test della connessione
- Salvataggio ed esportazione/importazione delle configurazioni

### Impostazioni Completamento Intelligente
- Ritardo di attivazione regolabile
- Limite della lunghezza del completamento
- Configurazione della lunghezza del contesto
- Supporto risposta in streaming

### Modifica Prompt
- Diversi modelli di scrittura integrati
- Modelli di prompt personalizzabili
- Gestione della classificazione dei modelli
- Configurazione di modelli specifici per modalità

### Funzionalità dell'interfaccia
- Tema chiaro e scuro
- Layout a tre colonne (albero dei progetti, editor, pannello concetti)
- Barra laterale pieghevole
- Modalità scrittura a schermo intero
- Modalità concentrazione (frase, paragrafo, macchina da scrivere, modalità zen, modalità immersiva)

### Ricerca e sostituzione
- Ricerca testo in tutto il progetto
- Supporto per espressioni regolari
- Funzione di sostituzione in batch
- Opzioni di ricerca avanzata

### Gestione dei concetti
- Rilevamento automatico di personaggi, luoghi, oggetti
- Gestione delle relazioni tra concetti
- Sistema di etichette e categorie
- Inserimento rapido di concetti

## Scorciatoie da tastiera

- `Ctrl+N`: Nuovo progetto
- `Ctrl+O`: Apri progetto
- `Ctrl+S`: Salva documento
- `F11`: Modalità schermo intero
- `Tab`: Attiva completamento AI manuale (in modalità manuale)
- `Ctrl+F`: Trova
- `Ctrl+H`: Trova e sostituisci
- `Ctrl+Shift+H`: Trova e sostituisci avanzato


## Requisiti di sistema

- Python 3.8+
- PyQt6
- Sistema operativo: Windows, macOS, Linux

## Autore

**inliver**
- Email: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---
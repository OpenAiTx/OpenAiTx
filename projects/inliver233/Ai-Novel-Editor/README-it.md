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

Editor di romanzi AI assistito basato su PyQt6, che offre strumenti professionali di scrittura come completamento intelligente, gestione dei progetti, organizzazione dei concetti e altro.

## Installazione

1. Clona il progetto
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Crea un ambiente virtuale
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```
Usa uv
```bash
uv venv -p 3.11
```
3. Installazione delle dipendenze
```bash
pip install -r requirements.txt
```
Utilizzo di uv
```bash
uv sync
```


4. Avvio del programma
```bash
python -m src
```

## Funzionalità principali

### Gestione dei progetti
- Struttura documentale gerarchica (Opera > Capitolo > Scena)
- Importazione ed esportazione dei progetti (supporta formati TEXT, MARKDOWN, DOCX, PDF, HTML)
- Backup automatico e controllo delle versioni
- Gestione di più progetti
### Funzione di completamento AI
- Tre modalità di completamento: completamento automatico, completamento manuale (consigliato: premere una volta tab per attivare, premere di nuovo tab per applicare il completamento), disabilita completamento
- Tre modalità di contesto:
  - Modalità veloce: contesto leggero, risposta rapida
  - Modalità bilanciata: contesto medio, equilibrio tra qualità e velocità
  - Modalità globale: contesto completo del progetto, miglior risultato
- Supporto per vari servizi AI: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, ecc.

### Gestione della struttura
- Struttura ad albero visuale della struttura
- Ordinamento tramite trascinamento e regolazione dei livelli
- Navigazione rapida dei documenti
- Analisi della struttura e suggerimenti di ottimizzazione

### Configurazione API
- Centro di configurazione AI unificato
- Configurazioni preimpostate per diversi provider di servizi
- Funzione di test di connessione
- Salvataggio, importazione ed esportazione delle configurazioni
### Impostazioni di Completamento Intelligente
- Ritardo di attivazione regolabile
- Limite di lunghezza del completamento
- Configurazione della lunghezza del contesto
- Supporto per risposta in streaming

### Modifica dei Prompt
- Vari modelli di scrittura integrati
- Modelli di prompt personalizzati
- Gestione delle categorie di modelli
- Configurazione di modelli specifici per modalità

### Funzionalità dell'Interfaccia
- Tema chiaro e scuro
- Layout a tre colonne (albero del progetto, editor, pannello dei concetti)
- Barra laterale comprimibile
- Modalità di scrittura a schermo intero
- Modalità concentrazione (frase, paragrafo, macchina da scrivere, modalità zen, modalità immersiva)

### Ricerca e Sostituzione
- Ricerca in tutto il testo del progetto
- Supporto delle espressioni regolari
- Funzione di sostituzione in batch
- Opzioni di ricerca avanzate

### Gestione dei concetti
- Rilevamento automatico di ruoli, luoghi, oggetti
- Gestione delle relazioni tra concetti
- Sistema di etichette e classificazione
- Inserimento rapido dei concetti

## Scorciatoie da tastiera

- `Ctrl+N`: Nuovo progetto
- `Ctrl+O`: Apri progetto
- `Ctrl+S`: Salva documento
- `F11`: Modalità schermo intero
- `Tab`: Attiva manualmente il completamento AI (in modalità manuale)
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---
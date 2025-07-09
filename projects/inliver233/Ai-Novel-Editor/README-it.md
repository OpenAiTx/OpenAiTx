# AI Novel Editor

Editor di romanzi AI-assistito basato su PyQt6, che offre strumenti professionali di scrittura come completamento intelligente, gestione dei progetti, organizzazione dei concetti e altro ancora.

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

3. Installa le dipendenze
```bash
pip install -r requirements.txt
```
4. Esecuzione del programma
```bash
python src/main.py
```

## Funzionalità principali

### Gestione dei progetti
- Struttura documentale gerarchica (Opera > Capitolo > Scena)
- Importazione ed esportazione dei progetti (supporto per i formati TEXT, MARKDOWN, DOCX, PDF, HTML)
- Backup automatico e controllo delle versioni
- Gestione di più progetti

### Funzionalità di completamento AI
- Tre modalità di completamento: completamento automatico, completamento manuale (consigliato: premi Tab una volta per attivare, premi di nuovo Tab per applicare il completamento), disabilita completamento
- Tre modalità di contesto:
  - Modalità rapida: contesto leggero, risposta veloce
  - Modalità bilanciata: contesto medio, equilibrio tra qualità e velocità
  - Modalità globale: contesto completo del progetto, risultato migliore
- Supporto per vari servizi AI: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, ecc.
### Gestione dell’Outline
- Struttura ad albero dell’outline visualizzabile
- Ordinamento tramite trascinamento e regolazione dei livelli
- Navigazione rapida del documento
- Analisi dell’outline e suggerimenti di ottimizzazione

### Configurazione API
- Centro di configurazione AI unificato
- Configurazioni preimpostate per più fornitori di servizi
- Funzione di test della connessione
- Salvataggio, importazione ed esportazione delle configurazioni

### Impostazioni di Completamento Intelligente
- Ritardo di attivazione regolabile
- Limite di lunghezza del completamento
- Configurazione della lunghezza del contesto
- Supporto per risposta in streaming

### Modifica dei Prompt
- Diversi modelli di scrittura integrati
- Modelli di prompt personalizzati
- Gestione della classificazione dei modelli
- Configurazione di modelli specifici per modalità
### Funzionalità dell'interfaccia
- Tema chiaro e scuro
- Layout a tre colonne (albero del progetto, editor, pannello dei concetti)
- Barra laterale comprimibile
- Modalità di scrittura a schermo intero
- Modalità di concentrazione (frase, paragrafo, macchina da scrivere, modalità zen, modalità immersiva)

### Ricerca e sostituzione
- Ricerca testuale in tutto il progetto
- Supporto per espressioni regolari
- Funzione di sostituzione in batch
- Opzioni di ricerca avanzate

### Gestione dei concetti
- Rilevamento automatico di personaggi, luoghi, oggetti
- Gestione delle relazioni tra concetti
- Sistema di tag e categorie
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---
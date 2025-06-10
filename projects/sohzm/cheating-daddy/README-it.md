# Cheating Daddy

> [!NOTE]  
> Utilizza l'ultima versione di MacOS e Windows, le versioni precedenti hanno un supporto limitato

> [!NOTE]  
> Durante i test non risponderà se fai una domanda, devi simulare che l'intervistatore ponga la domanda, a cui risponderà

Un assistente AI in tempo reale che fornisce aiuto contestuale durante videochiamate, colloqui, presentazioni e riunioni utilizzando la cattura dello schermo e l'analisi audio.

## Funzionalità

- **Assistenza AI Live**: Aiuto in tempo reale alimentato da Google Gemini 2.0 Flash Live
- **Cattura Schermo & Audio**: Analizza ciò che vedi e senti per risposte contestuali
- **Profili Multipli**: Colloquio, Chiamata di Vendita, Riunione d'Affari, Presentazione, Negoziazione
- **Overlay Trasparente**: Finestra sempre in primo piano che può essere posizionata ovunque
- **Modalità Click-through**: Rendi la finestra trasparente ai clic quando necessario
- **Multipiattaforma**: Funziona su macOS, Windows e Linux (più o meno, non usare, solo per test al momento)

## Configurazione

1. **Ottieni una chiave API Gemini**: Visita [Google AI Studio](https://aistudio.google.com/apikey)
2. **Installa le dipendenze**: `npm install`
3. **Avvia l'applicazione**: `npm start`

## Utilizzo

1. Inserisci la tua chiave API Gemini nella finestra principale
2. Scegli il tuo profilo e la lingua nelle impostazioni
3. Clicca su "Avvia sessione" per iniziare
4. Posiziona la finestra usando le scorciatoie da tastiera
5. L'AI fornirà assistenza in tempo reale in base allo schermo e alle domande dell'intervistatore

## Scorciatoie da Tastiera

- **Movimento Finestra**: `Ctrl/Cmd + Frecce` - Muovi la finestra
- **Click-through**: `Ctrl/Cmd + M` - Attiva/disattiva eventi mouse
- **Chiudi/Indietro**: `Ctrl/Cmd + \` - Chiudi la finestra o torna indietro
- **Invia Messaggio**: `Invio` - Invia testo all'AI

## Cattura Audio

- **macOS**: [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) per audio di sistema 
- **Windows**: Cattura audio loopback
- **Linux**: Ingresso microfono

## Requisiti

- Sistema operativo compatibile con Electron (macOS, Windows, Linux)
- Chiave API Gemini
- Permessi di registrazione schermo
- Permessi microfono/audio

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
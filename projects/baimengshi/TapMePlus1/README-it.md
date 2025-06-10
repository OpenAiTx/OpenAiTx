# TapMePlus1 Script di Auto-Pulizia

Uno script utenti Greasemonkey potente per automatizzare il processo di pulizia del gioco TapMePlus1.

## Funzionalità

- 🎮 **Gioco completamente automatico**: Determina automaticamente la strategia di click ottimale
- ⚡ **Decisione intelligente**: Valuta i potenziali benefici di ogni click sulla base della funzione di valore
- 🔁 **Gestione delle reazioni a catena**: Simula completamente l’effetto di eliminazione a catena
- 🚀 **Algoritmo efficiente**: Supporta la strategia di operazione continua multi-click
- 🛠 **Modalità breakthrough**: Trova il miglior punto di svolta in una situazione sfavorevole
- 📊 **Monitoraggio in tempo reale**: Monitora lo stato del gioco in background e riavvia automaticamente il gioco
- 🖥 **Pannello di controllo**: Interfaccia GUI intuitiva per controllare il funzionamento dello script

## Istruzioni per l’installazione

1. Installa l’estensione browser [violentmonkey](https://violentmonkey.github.io/)
2. Clicca per installare lo [script TapmePlus1](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js)
3. Visita [TapMePlus1](https://tapmeplus1.com/) Avvia il gioco

## Opzioni di configurazione

Lo script contiene i seguenti parametri regolabili (modificare nel codice):

```javascript
// ====== Parametri di base ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== Funzione di peso dinamico ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== Strategia per fase ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: '基础', strategy: 'default' };
    };
```

## Licenza

Licenza GPL-3.0.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
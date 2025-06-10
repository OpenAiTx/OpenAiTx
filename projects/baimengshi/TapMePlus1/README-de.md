# TapMePlus1 Auto-Clearing Script

Ein leistungsstarkes Greasemonkey-Userscript zur Automatisierung des Löschvorgangs im TapMePlus1-Spiel.

## Funktionen

- 🎮 **Vollautomatisches Spiel**: Bestimmt automatisch die optimale Klickstrategie
- ⚡ **Intelligente Entscheidungsfindung**: Bewertet den potenziellen Nutzen jedes Klicks anhand der Wertfunktion
- 🔁 **Kettenreaktionsverarbeitung**: Simuliert den Ketteneliminationseffekt vollständig
- 🚀 **Effizienter Algorithmus**: Unterstützt Mehrfachklick-Strategien für kontinuierlichen Betrieb
- 🛠 **Durchbruchsmodus**: Findet den besten Durchbruchspunkt in ungünstigen Situationen
- 📊 **Echtzeitüberwachung**: Überwacht den Spielstatus im Hintergrund und startet das Spiel automatisch neu
- 🖥 **Bedienfeld**: Intuitive GUI-Oberfläche zur Steuerung des Skriptbetriebs

## Installationsanleitung

1. Installiere die [violentmonkey](https://violentmonkey.github.io/) Browser-Erweiterung
2. Klicke, um das [TapmePlus1 Script](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js) zu installieren
3. Besuche [TapMePlus1](https://tapmeplus1.com/) und starte das Spiel

## Konfigurationsoptionen

Das Skript enthält die folgenden anpassbaren Parameter (im Code ändern):

```javascript
// ====== Grundlegende Parameter ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== Dynamische Gewichtungsfunktion ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== Phasenstrategie ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: 'Basis', strategy: 'default' };
    };
```

## Lizenz

Die GPL-3.0 Lizenz.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
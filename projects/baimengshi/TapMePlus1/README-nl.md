# TapMePlus1 Auto-Clearing Script

Een krachtige Greasemonkey-userscript voor het automatiseren van het leegmaken van het TapMePlus1-spel.

## Functies

- 🎮 **Volledig automatisch spel**: Bepaalt automatisch de optimale klikstrategie
- ⚡ **Intelligente beslissing**: Evalueert de potentiële voordelen van elke klik op basis van de waardefunctie
- 🔁 **Ketenreactieverwerking**: Simuleert volledig het keten-eliminatie-effect
- 🚀 **Efficiënt algoritme**: Ondersteunt multi-klik continue bedieningsstrategie
- 🛠 **Doorbraakmodus**: Vindt het beste doorbraakpunt in een ongunstige situatie
- 📊 **Realtime monitoring**: Houdt de spelstatus op de achtergrond in de gaten en start het spel automatisch opnieuw
- 🖥 **Bedieningspaneel**: Intuïtieve GUI-interface om scriptbediening te regelen

## Installatie-instructies

1. Installeer de [violentmonkey](https://violentmonkey.github.io/) browserextensie
2. Klik om het [TapmePlus1-script](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js) te installeren
3. Bezoek [TapMePlus1](https://tapmeplus1.com/) Start het spel

## Configuratie-opties

Het script bevat de volgende aanpasbare parameters (wijzig in de code):

```javascript
// ====== Basisparameters ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== Dynamische gewichtfunctie ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== Fasestrategie ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: 'Basis', strategy: 'default' };
    };
```

## Licentie

De GPL-3.0 Licentie.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
# TapMePlus1 Script d’Auto-Nettoyage

Un puissant userscript Greasemonkey pour automatiser le processus de nettoyage du jeu TapMePlus1.

## Fonctionnalités

- 🎮 **Jeu entièrement automatique** : Détermine automatiquement la stratégie de clic optimale
- ⚡ **Décision intelligente** : Évalue les bénéfices potentiels de chaque clic en fonction de la fonction de valeur
- 🔁 **Traitement des réactions en chaîne** : Simule complètement l’effet d’élimination en chaîne
- 🚀 **Algorithme efficace** : Prend en charge une stratégie d’opérations continues à plusieurs clics
- 🛠 **Mode percée** : Trouve le meilleur point de percée dans une situation défavorable
- 📊 **Surveillance en temps réel** : Surveille l’état du jeu en arrière-plan et relance automatiquement la partie
- 🖥 **Panneau de contrôle** : Interface graphique intuitive pour contrôler le fonctionnement du script

## Instructions d’installation

1. Installez l’extension navigateur [violentmonkey](https://violentmonkey.github.io/)
2. Cliquez pour installer le [script TapmePlus1](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js)
3. Rendez-vous sur [TapMePlus1](https://tapmeplus1.com/) et lancez le jeu

## Options de configuration

Le script contient les paramètres ajustables suivants (à modifier dans le code) :

```javascript
// ====== Paramètres de base ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== Fonction de pondération dynamique ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== Stratégie par phase ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: '基础', strategy: 'default' };
    };
```

## Licence

La licence GPL-3.0.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---
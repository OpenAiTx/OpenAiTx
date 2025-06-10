# TapMePlus1 Skrypt Auto-Czyszczenia

Potężny skrypt użytkownika Greasemonkey do automatyzacji procesu czyszczenia gry TapMePlus1.

## Funkcje

- 🎮 **W pełni automatyczna gra**: Automatycznie określa optymalną strategię kliknięć
- ⚡ **Inteligentna decyzja**: Ocena potencjalnych korzyści każdego kliknięcia na podstawie funkcji wartości
- 🔁 **Obsługa reakcji łańcuchowych**: Całkowita symulacja efektu łańcuchowego usuwania
- 🚀 **Wydajny algorytm**: Obsługa strategii wielokrotnego, ciągłego klikania
- 🛠 **Tryb przełamania**: Znajduje najlepszy punkt przełamania w niekorzystnej sytuacji
- 📊 **Monitorowanie w czasie rzeczywistym**: Monitoruje stan gry w tle i automatycznie restartuje grę
- 🖥 **Panel sterowania**: Intuicyjny interfejs GUI do kontrolowania działania skryptu

## Instrukcja instalacji

1. Zainstaluj rozszerzenie przeglądarki [violentmonkey](https://violentmonkey.github.io/)
2. Kliknij, aby zainstalować [skrypt TapmePlus1](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js)
3. Odwiedź [TapMePlus1](https://tapmeplus1.com/) Rozpocznij grę

## Opcje konfiguracji

Skrypt zawiera następujące regulowane parametry (zmodyfikuj w kodzie):

```javascript
// ====== Podstawowe parametry ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== Dynamiczna funkcja wagowa ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== Strategia fazowa ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: '基础', strategy: 'default' };
    };
```

## Licencja

Licencja GPL-3.0.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---